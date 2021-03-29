// SPDX-License-Identifier: MIT
// Copyright (C) 2021 Roland Csaszar
//
// Project:  FSHARP_TEMPLATE
// File:     Main.fs
//
//==============================================================================

module Main

open Expecto

open TemplateLibrary

/// <summary>Hugo</summary>
[<EntryPoint>]
let main argv =
    Say.hello "Bland"
    Tests.runTestsInAssembly defaultConfig argv
