# zkbindings-action

This [GitHub Action](https://github.com/features/actions) will build bindings for a TwinCAT PLC for various programming languages (atm C# and C++) 

[Register](https://zeugwerk.dev/wp-login.php?action=register) to use this action for public repositories, this will allow you to run this action 30 times per month. [Contact us](mailto:info@zeugwerk.at) to retrieve a subscription if you need more builds per month or use Zeugwerk Bindings for private repositories either on GitHub or any CI/CD server hosted in the cloud or on-premise or need support.


## Inputs

* `username`: Username of a Zeugwerk Useraccount (Required)

* `password`: Password of a Zeugwerk Useraccount (Required)

* `project`: Name of the project, the generated files will use this name for the generated classes, see [below](#remarks)

* `tmc`: Path to a tmc file, which will be used as a basic for the code generation. This file should be up-to-date with your PLC (Required)

* `filter`: Space seperated list of datatypes for which bindings should be generated for. If empty, bindings for all datatypes will be generated

* `languages`: Space seperated list of programming languages (cs cpp) for which bindings should be generated for

* `version`: The version number of your PLC, this value is written into a special file during code generation

### Creating secrets

We highly recommend to store the value for `username` and `password` in GitHub as secrets. GitHub Secrets are encrypted and allow you to store sensitive information, such as access tokens, in your repository. Do these steps for `username` and `password`

1. On GitHub, navigate to the main page of the repository.
2. Under your repository name, click on the "Settings" tab.
3. In the left sidebar, click Secrets.
4. On the right bar, click on "Add a new secret" 
5. Type a name for your secret in the "Name" input box. (i.e. `ACTIONS_ZGWK_USERNAME`, `ACTIONS_ZGWK_PASSWORD`)
6. Type the value for your secret.
7. Click Add secret. 

## Example usage

Checkout out how to use this action in this [repo](https://github.com/Zeugwerk/Tutorial-Quickstart), the configured action can be found in `.github/workflows/bindings.yml`. 

```yaml
name: Bindings
on:
  workflow_dispatch:
jobs:
  Build:
    name: Bindings
    runs-on: ubuntu-latest
    steps:
      - name: Build
        uses: Zeugwerk/zkdoc-bindings@1.0.0
        with:
          username: ${{ secrets.ACTIONS_ZGWK_USERNAME }}
          password: ${{ secrets.ACTIONS_ZGWK_PASSWORD }}
          project: 'Untitled1'
          tmc: 'Untitled1/Untitled1.tmc'
          filter: ''
      - name: Upload
        uses: actions/upload-artifact@v3
        with:
          name: Bindings
          path: |
            archive/**/*           
```

## Remarks

### C# code generation

The code that is generated for C# contains the following files
- *Project*Enums.cs, contains all enumerations of the PLC that are either directly listed in the *filter* or are used by any other item(s) of the datatypes specified in *filter*
- *Project*Structs.cs, contains binary compatible datatypes for DUTs of the PLC that are either directly listed in the *filter* or are used by any other item(s) of the datatypes specified in *filter*
- *Project*Classes.cs, contains wrappers for all structs in *Project*Structs.cs that make it very simply to interact with the PLC. The classes act as mirrors of the datatypes of the PLC. While normally you have to interact with the PLC with strings over ADS (e.g. the variable name is a string), these classes generate actual objects. Instead of getting runtime errors whenever the structure of the PLC doesnt match your C# application, using these classes will generate compile errors. The classes utilize [Beckhoff.TwinCAT.Ads](https://www.nuget.org/packages/Beckhoff.TwinCAT.Ads) to communicate with the PLC.
- *Project*Version.cs, contains a class with a single property that holds the value of *version* that was set during code generation. The file allows to compare the version of the bindings to an actual running PLC.
- *Project*Unittest.cs, contains unittests to check if the code generation works as intended. The generated code uses [Microsoft.VisualStudio.TestTools.UnitTesting](https://learn.microsoft.com/en-us/visualstudio/test/using-microsoft-visualstudio-testtools-unittesting-members-in-unit-tests?view=vs-2022)).

### C++ code generation

The code that is generated for C# contains the following files
- *Project*Enums.h, contains all enumerations of the PLC that are either directly listed in the *filter* or are used by any other item(s) of the datatypes specified in *filter*
- *Project*Structs.h, contains binary compatible datatypes for DUTs of the PLC that are either directly listed in the *filter* or are used by any other item(s) of the datatypes specified in *filter*
- *Project*Classes.h, contains wrappers for all structs in *Project*Structs.cs that make it very simply to interact with the PLC. The classes act as mirrors of the datatypes of the PLC. While normally you have to interact with the PLC with strings over ADS (e.g. the variable name is a string), these classes generate actual objects. Instead of getting runtime errors whenever the structure of the PLC doesnt match your C# application, using these classes will generate compile errors. The classes utilize [QAds](https://github.com/stefanbesler/QAds)) to communicate with the PLC. QAds also makes it very simple to use PLC variable for [Qt applications](https://github.com/qt).
- *Project*Version.h, contains a class with a single property that holds the value of *version* that was set during code generation. The file allows to compare the version of the bindings to an actual running PLC.
- *Project*Unittest.cpp, contains unittests to check if the code generation works as intended. The generated code uses [QtTest](https://doc.qt.io/qt-6/qtest-overview.html).


## Example (C#)

An example of the code, which can be generated by `zkbinding` can be found in the `example` subfolder.
The generated C# code can be used like this:

```cs
_ads = new TcAdsClient();
_ads.Connect(851);

// bind _quickstart to the PLC
_quickstart = new PLC.Mirror.QuickstartCom("ZGlobal.Com.Unit.Quickstart", _ads);

// synchronously write a struct to the PLC. Access is type-safe and the C# compiler will report an error during compilation if the symbols on the PLC changed
_quickstart.Subscribe.Equipment.LimitSwitchLeft.Sync = new PLC.Types.ZApplication_DigitalComSubscribe { Enable = 0, Write = 1 };	
```
