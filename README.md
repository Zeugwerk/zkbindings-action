# zkdoc-action

This [GitHub Action](https://github.com/features/actions) will build bindings for a TwinCAT PLC for various programming languages (atm C# only) 

[Register](https://zeugwerk.dev/wp-login.php?action=register) to use this action for public repositories, this will allow you to run this action 30 times per month. [Contact us](mailto:info@zeugwerk.at) to retrieve a subscription if you need more builds per month or use Zeugwerk Bindings for private repositories either on GitHub or any CI/CD server hosted in the cloud or on-premise or need support.


## Inputs

* `username`: Username of a Zeugwerk Useraccount (Required)

* `password`: Password of a Zeugwerk Useraccount (Required)

* `tmc`: Path to a tmc file, which will be used as a basic for the code generation. This file should be up-to-date with your PLC (Required)

* `filter`: Space seperated list of datatypes for which bindings should be generated for. If empty, bindings for all datatypes will be generated

* `languages`: Space seperated list of programming languages (cs cpp) for which bindings should be generated for

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
          tmc: 'Untitled1/Untitled1.tmc'
          filter: ''
```

