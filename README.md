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

Read the library documentation at https://jmussman.github.io/everyone-is-authorized-client-dotnet/.

### Demonstration Scenario 1 - Tightly Coupled

Create unit tests using the zero-argument constructor and try to verify that validation of the card number takes place.
Switch to the constructor that accepts an ICreditCardValidator and use Moq to verify that validation was performed.
This is the same (and only) test that is in the xUnit test project.

### Demonstration Scenario 2 - Non-Deterministic Dependency

Create a SalesOrderManager class that uses the authorization as part of a "checkout" flow.
It quickly becomes apparent that this scenario is not testable because the results of the request are always positive.

The solution requires several steps.
First, dependency injection is necessary to use a test-double with the SalesOrderManager.
Then, the adapter pattern must be used to put a common interface between the SalesOrderManager and the authorizer.
Bring in the sister class [The Bank of Random Credit Authorizer](https://github.com/jmussman/the-bank-of-random-credit-authorizer-dotnet)
to emphasize the need for the interface and fully demonstrate the adapter pattern.
Then it is a simple stretch to use Moq to build a test-double for testing SalesOrderManager.

<hr>
Copyright © 2018-2021 Joel Mussman. All rights reserved.