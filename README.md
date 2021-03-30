# F# Project Template

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
