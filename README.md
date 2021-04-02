# F# Project Template

[![MIT license badge](https://img.shields.io/github/license/Release-Candidate/FSHARP_TEMPLATE)](https://github.com/Release-Candidate/FSHARP_TEMPLATE/blob/main/LICENSE)
[![Documentation Status](https://readthedocs.org/projects/fsharp-template/badge/?version=latest)](https://fsharp-template.readthedocs.io/en/latest/?badge=latest)
[![F# 5.0 badge](https://img.shields.io/badge/F%23-5.0-brightgreen?style=flat)](https://fsharp.org/)
[![.Net 5.0 badge](https://img.shields.io/badge/.Net-5.0-brightgreen?style=flat)](https://dotnet.microsoft.com/download)
[more badges](#badges)

This is a Github template for F#, using Paket as
Nuget package manager, Fake as build system, MkDocs
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

## Fake

Before you can use the configured Tools of this template, 
You have to download and install (aka. `restore`) the packages
of the tools. 
1. First, download and install the "dotnet tools" using the command

    ```shell
    dotnet tool restore
    ```

    now you have installed Fake, Paket and FSharpLint, 
configured in the file `.config/dotnet-tools.json`

2. Download and install ("restore") the Paket Nuget packages. 

    ```shell
    dotnet paket restore
    ```
3. Delete the file `build.fsx.lock` and run Fake, 
To download and install (restore) it's nuget packages. 

    ```shell
    dotnet fake run build.fsx
    ```

4. To generate the documentation using MkDocs, a
virtual Python environment is needed. A virtual Python
environment is the same as the locally installed
Nuget packages above. 
So, first you need to install Python, if you don't
have it installed already. In the file `Pipfile`
there is a stanza saying

    ```ini
    [requires]
    python_version = "3.9"
    ```

    That's just because I used 3.9 when generating that
template, and Pipenv is picky with the version mentioned
there. Just edit that to match your installed
Python version. Install `pipenv` using the package
manager pip

    ```shell
    pip install pipenv
    ```
    Now you're ready to download and install the needed
packages using pipenv

    ```shell
    pipenv install --dev
    ```

### Build Targets

The Fake script `build.fsx` defines the following targets:

* `Clean`
* `Distclean`
* `Build` and `BuildDeb`
* `Docs`
* `Lint`
* `Tests` and `TestsDeb`
* `TestsCoverage` and `TestsCoverageDeb`
* `Publish`
* `Upload`
* `Release`
* `All`

## MkDocs Files

* `mkdocs.yml` the MkDocs configuration, specially
    the configuration of the navigation sidebar in `nav`
    Which you need to edit 

    ```yml
    nav:
    - Home: index.md
    - Project Links:
      - 'GitHub Project Page': 'https://github.com/Release-Candidate/FSHARP_TEMPLATE'
      - 'Nuget Package': 'https://pypi.org/project/FSHARP_TEMPLATE/'
      - 'Report a Bug or a Feature Request': 'https://github.com/Release-Candidate/FSHARP_TEMPLATE/issues/new/choose'
      - 'Issue Tracker at GitHub': 'https://github.com/Release-Candidate/FSHARP_TEMPLATE/issues'
    - 'Installation & Usage':
      - 'Installation & Usage': usage.md
      - License: license.md
    - Contributing:
      - Contributing: contributing.md
   ```

* `/docs` the markdown files that are used to generate the
   HTML sites in the directory `sites`

## Read the Docs Configuration

* `.readthedocs.yaml` the configuration for Read the Docs
* `/docs/requirements.txt` the packages needed by MkDocs 
   when generating the documentation at Read the Docs. 
   Locally needed packages are configured in `Pipfile`

## CodeCov Configuration



## GitHub Workflows

All tests and builds are executed on Linux, 
Mac OS X and Windows. 

There are the following GitHub workflows defined in
the directory `.github/workflows`

* `create_packages.yml`
* `fsharplint.yml`
* `linux.yml`
* `linux_test.yml`
* `osx.yml`
* `osx_test.yml`
* `windows.yml`
* `windows_test.yml`

## GitHub Issue Template

Issue templates for GitHub in `.github/ISSUE_TEMPLATE/`

* `bug_report.md` Bug report template 
* `feature_request.md` Feature request template

# Begin of the Template

## Download

[Link to the latest release](https://github.com/Release-Candidate/FSHARP_TEMPLATE/releases/latest)

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
