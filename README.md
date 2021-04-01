# F# Project Template

[![MIT license badge](https://img.shields.io/github/license/Release-Candidate/FSHARP_TEMPLATE)](https://github.com/Release-Candidate/FSHARP_TEMPLATE/blob/main/LICENSE)
[![Documentation Status](https://readthedocs.org/projects/fsharp-template/badge/?version=latest)](https://fsharp-template.readthedocs.io/en/latest/?badge=latest)
[![F# 5.0 badge](https://img.shields.io/badge/F%23-5.0-brightgreen?style=flat)](https://fsharp.org/)
[![.Net 5.0 badge](https://img.shields.io/badge/.Net-5.0-brightgreen?style=flat)](https://dotnet.microsoft.com/download)
[more badges](#badges)

This is a Github template for F#, using Paket as
Nuget package Manager, Fake as build system, MkDocs
to generate HTML documentation at [Read The Docs](https://readthedocs.org/), 
Expecto, Unquote and FsCheck for the testing, AltCover to generate
coverage reports at CodeCov, FSharpLint as statíc code checker and Github workflows. 

## Template Usage

1. Replace the string `FSHARP_TEMPLATE` (and *_TEMPALTE and FHARP_*) 
with the real project name(s), and my name too, if
you aren't mé ;). 
2. Add the Nuget key and the Codecov token as secrets
to the repository, named `CODECOV_SECRET` and `NUGET_PACKAGE`. 
3. Rename, move and edit the two project files, 
`src/LibTemplate/LibTemplate.fsproj` and `tests/TestsTemplate/TestsTemplate.fsproj`
Same with the source files in `src/LibTemplate`
and `tests/TestsTemplate`
4. Change this Readme.md
5. Change the documentation in `docs/`
6. Add a solution file (`.sln`) in this root directory
7. Add the source project(s) in `src/` and the test
projects in `tests/` to the solution

# Begin of the Template

## Installation and Usage

### Prerequisites

### Installation

### Usage

## Contributing

## License

All content of FSHARP_TEMPLATE is licensed under the MIT license, see file [LICENSE](https://github.com/Release-Candidate/FSHARP_TEMPLATE/blob/main/LICENSE).

## Badges

### GitHub Workflows/Actions

#### Static Code Checkers

[![FsharpLint Linter](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/fsharplint.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/fsharplint.yml)

#### Tests on various OSes

[![Tests Mac OS X latest](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/osx_test.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/osx_test.yml)
[![Tests Ubuntu 20.04](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/linux_test.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/linux_test.yml)
[![Tests Windows 2019](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/windows_test.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/windows_test.yml)
[![Mac OS X latest](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/osx.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/osx.yml)
[![Ubuntu 20.04](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/linux.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/linux.yml)
[![Windows 2019](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/windows.yml/badge.svg)](https://github.com/Release-Candidate/FSharp_Template/actions/workflows/windows.yml)



### External Websites

[![codecov](https://codecov.io/gh/Release-Candidate/FSharp_Template/branch/main/graph/badge.svg)](https://codecov.io/gh/Release-Candidate/FSharp_Template)
