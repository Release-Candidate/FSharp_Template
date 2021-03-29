# F# Project Template

## What to do:

1. [Layout](https://gist.github.com/davidfowl/ed7564297c61fe9ab814#file-dotnetlayout-md)
2. set `--warnon:3390`
2. set `Warning Level`to 5
3. install F# linter: 

   ```shell
   dotnet tool install -g dotnet-fsharplint
    ```
    Usage: 

    ```shell
    dotnet fsharplint lint FsharpTemplate.sln
    ```

5. build: 
    
   ```shell
   dotnet build
   ```


6. Clean:

    ```shell
    dotnet clean
    ```

7. Run tests:

    ```shell
    dotnet test
    ```

    Schöner:    

   ```shell
    dotnet run --project .\tests\TestsTemplate\TestsTemplate.fsproj
    ```

8. Coverage: [Altcover](https://github.com/SteveGilham/altcover/wiki/QuickStart-Guide)

    ```shell
    dotnet test /p:AltCover=true
    ```

9. Nuget Package: see [MS Documentation](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)

   ```shell
   dotnet pack
   ```

    ```text
    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
    ```

    Upload:

    ```text
    dotnet nuget push ???.1.0.0.nupkg --api-key XXX --source https://api.nuget.org/v3/index.json
    ```

9. Fsharp.Formatting [FSharp.Formatting](https://fsprojects.github.io/FSharp.Formatting/)

   ```shell
    dotnet tool install FSharp.Formatting.CommandTool
    ```

6. Fornax for documentation: [Fornax](https://github.com/ionide/Fornax)
   
   ```shell
    dotnet tool install fornax -g
    ```
6. Alternative: use [WayPoint](https://ionide.io/Libraries/waypoint.html)

    Doesn't really work right now ...

    ```shell
    dotnet new -i Waypoint
    ```

    To generate new template:

    ```shell
    dotnet new Waypoint
    ```
    