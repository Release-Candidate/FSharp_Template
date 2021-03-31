# F# Project Template

[![MIT license badge](https://img.shields.io/github/license/Release-Candidate/FSHARP_TEMPLATE)](https://github.com/Release-Candidate/FSHARP_TEMPLATE/blob/main/LICENSE)
[![Documentation Status](https://readthedocs.org/projects/fsharp-template/badge/?version=latest)](https://fsharp-template.readthedocs.io/en/latest/?badge=latest)
[![F# 5.0 badge](https://img.shields.io/badge/F%23-5.0-brightgreen?style=flat)](https://fsharp.org/)
[![.Net 5.0 badge](https://img.shields.io/badge/.Net-5.0-brightgreen?style=flat)](https://dotnet.microsoft.com/download)
[more badges](#badges)



## What to do:

1. [Layout](https://gist.github.com/davidfowl/ed7564297c61fe9ab814#file-dotnetlayout-md)
2. set `--warnon:3390`
    set `Warning Level`to 5
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

    Better:

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

10. Install FAKE (globally)

    ```shell
    dotnet tool install fake-cli -g
    ```

11. Install Paket (globally)

    ```shell
    dotnet tool install paket -g
    ```

12. Install pip and Python to use Sphinx for the documentation. (until [DocFX](https://dotnet.github.io/docfx/index.html)
    is usable with F#)

## Installation and Usage

### Prerequisites

### Installation

### Usage

## Contributing

## License

All content of FHARP_TEMPLATE is licensed under the MIT license, see file [LICENSE](https://github.com/Release-Candidate/FSHARP_TEMPLATE/blob/main/LICENSE).

## Badges

### GitHub Workflows/Actions

[![FsharpLint Linter](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/fsharplint.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/fsharplint.yml)
[![Tests Mac OS X latest](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/osx_test.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/osx_test.yml)
[![Tests Ubuntu 20.04](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/linux_test.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/linux_test.yml)
[![Tests Windows 2019](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/windows_test.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/windows_test.yml)

### External Websites

[![codecov](https://codecov.io/gh/Release-Candidate/FSharp_Template/branch/main/graph/badge.svg)](https://codecov.io/gh/Release-Candidate/FSharp_Template)
