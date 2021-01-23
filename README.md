![](.common/joels-private-stock.png?raw=true)

# Everyone is Authorized Client (.NET)

This project contains a class representing a client-side service component that authorizes a purchase 100%
of the time, as long as the credit card number is valid.
The purpose is to use this authorizer to demonstrate how to reduce tight-coupling by using dependency injection.
This project provides a non-deterministic result for making a purchase, which cannot be used in a unit or
integration test.

When paired with the Bankd of Random Credit project (https://github.com/jmussman/the-bank-of-random-credit-authorizer-dotnet)
it provides the foundation to introduce the Adapter
pattern and add a runtime reason for using dependency injection.

## License

The code is licensed under the MIT license.
You may use and modify all or part of it as you choose, as long as attribution to the source is provided per the license.
See the details in the [license file](./LICENSE.md) or at the [Open Source Initiative](https://opensource.org/licenses/MIT)

### Software Configuration

The library code targets .NET Core 3.1. The unit tests are built with xUnit.

### Dependencies

* [WonderfulWidgets.CreditCardValidator](https://github.com/jmussman/credit-card-validator-dotnet)

### Documentation

Read the JavaDoc at https://jmussman.github.io/everyone-is-authorized-client-dotnet/.

<hr>
Copyright © 2018-2021 Joel Mussman. All rights reserved.