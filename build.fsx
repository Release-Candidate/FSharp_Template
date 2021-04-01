// SPDX-License-Identifier: MIT
// Copyright (C) 2021 Roland Csaszar
// File: build.fsx
//
//==============================================================================

#r "paket:
nuget AltCover.Api >= 7.0
nuget Fake.DotNet.Cli
nuget Fake.IO.FileSystem
nuget Fake.Core.Target //"
#load ".fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators

Target.initEnvironment ()

//==============================================================================
//                               Clean
//
Target.create "Clean" (fun _ ->
    !! "src/**/bin"
    ++ "src/**/obj"
    ++ "tests/**/bin"
    ++ "tests/**/obj"
    |> Shell.cleanDirs

    !! "src/**/*.exn"
    ++ "tests/**/*.exn"
    ++ "tests/**/coverage.xml"
    |> Seq.iter File.delete
)

//==============================================================================
//                               Distclean
//
Target.create "Distclean" (fun _ ->
    !! "site/"
    ++ ".ionide/"
    ++ ".fake"
    ++ ".paket"
    ++ ".paket-files"
    ++ ".vs"
    |> Shell.deleteDirs
)


//==============================================================================
//                               Lint
//
let execFSharpLint projFile = DotNet.exec id "fsharplint" (
                                        sprintf "lint %s" projFile)
                                        |> ignore

Target.create "Lint" (fun _ ->
    !! "src/**/*.*proj"
    ++ "tests/**/*.*proj"
    |> Seq.iter execFSharpLint
)


//==============================================================================
//                               Build
//
Target.create "Build" (fun _ ->
    !! "src/**/*.*proj"
    ++ "tests/**/*.*proj"
    |> Seq.iter (DotNet.build id)
)


//==============================================================================
//                               Docs
//
Target.create "Docs" (fun _ ->
    CreateProcess.fromRawCommand "pipenv" [ "run"; "mkdocs"; "build" ]
    |> CreateProcess.ensureExitCode // will make sure to throw on error
    |> CreateProcess.withWorkingDirectory "."
    |> Proc.run
    |> ignore
)

//==============================================================================
//                               Tests
//
let execTests projFile = DotNet.exec id "run" (
                                        sprintf "--project %s" projFile)
                                        |> ignore

Target.create "Tests" (fun _ ->
    !! "tests/**/*.*proj"
    |> Seq.iter execTests
)

//==============================================================================
//                           Tests & Coverage
//
let execTestsCoverage projFile = DotNet.exec id "test" (
                                    sprintf "/p:AltCover=true %s" projFile)
                                    |> ignore

Target.create "TestsCoverage" (fun _ ->
    !! "tests/**/*.*proj"
    |> Seq.iter execTestsCoverage
)


//==============================================================================
//                             Packages
//
let execMakePackage projFile = DotNet.exec id "pack" projFile |> ignore

Target.create "Packages" (fun _ ->
    !! "src/**/*.*proj"
    ++ "tests/**/*.*proj"
    |> Seq.iter execMakePackage
)

//==============================================================================
//                Tests & Coverage Altcover Coverage API
//
//open AltCover.Fake.DotNet // extension method WithAltCoverOptions
//let ForceTrue = AltCover.DotNet.CLIOptions.Force true

//let p =
//  { AltCover.Primitive.PrepareOptions.Create() with
//      CallContext = [| "[Fact]"; "0" |]
//      AssemblyFilter = [| "xunit" |]
//      Report = "" }

//let prepare = AltCover.AltCover.PrepareOptions.Primitive p
//let c = AltCover.Primitive.CollectOptions.Create()
//let collect = AltCover.AltCover.CollectOptions.Primitive c

//Target.create "TestsCoverage" (fun _ ->
//    !! "tests/**/*.*proj"
//    |> Seq.iter (DotNet.test
//            (fun to' -> to'.WithAltCoverOptions prepare collect ForceTrue)
//    )
//)

//==============================================================================
//                      Package Fake 4 API
//
//open Fake.DotNet.NuGet
//Target.create "Package" (fun _ ->
//    copyFiles packagingOutputDirectory allFilesToPackage
//    NuGet.NuGet (fun p ->
//        { p with
//            Version = buildVersion
//            Authors = authors
//            Project = projectName
//            Summary = projectSummary
//            Description = projectDescription
//            WorkingDir = packagingDirectory
//            OutputPath = artifactOutputDirectory
//            AccessKey = myAccessKey
//            Publish = true })
//        "template.nuspec"
//)

//==============================================================================
//                              All
//
Target.create "All" ignore


//==============================================================================
//                             Target Dependencies
//
"Clean" ==> "Distclean"

"Clean" ==> "Build" ==> "Lint"

"Clean" ==> "Build" ==> "TestsCoverage"

"Clean"
  ==> "Build"
  ==> "Docs"
  ==> "Tests"
  ==> "Packages"
  ==> "All"

Target.runOrDefault "All"
