<a name='assembly'></a>
# EveryoneIsAuthorizedClient

## Contents

- [AlwaysAuthorize](#T-EveryoneIsAuthorized-Client-AlwaysAuthorize 'EveryoneIsAuthorized.Client.AlwaysAuthorize')
  - [#ctor()](#M-EveryoneIsAuthorized-Client-AlwaysAuthorize-#ctor 'EveryoneIsAuthorized.Client.AlwaysAuthorize.#ctor')
  - [#ctor(creditCardValidator)](#M-EveryoneIsAuthorized-Client-AlwaysAuthorize-#ctor-OpenCardServices-Validator-ICreditCardValidator- 'EveryoneIsAuthorized.Client.AlwaysAuthorize.#ctor(OpenCardServices.Validator.ICreditCardValidator)')
  - [Authorize(amt,number)](#M-EveryoneIsAuthorized-Client-AlwaysAuthorize-Authorize-System-Double,System-String- 'EveryoneIsAuthorized.Client.AlwaysAuthorize.Authorize(System.Double,System.String)')

<a name='T-EveryoneIsAuthorized-Client-AlwaysAuthorize'></a>
## AlwaysAuthorize `type`

##### Namespace

EveryoneIsAuthorized.Client

##### Summary

Client interface to the credit card processing services for Everyone is Authorized.

<a name='M-EveryoneIsAuthorized-Client-AlwaysAuthorize-#ctor'></a>
### #ctor() `constructor`

##### Summary

Create an authorizer using an instance of CreditCardValidator.

##### Parameters

This constructor has no parameters.

<a name='M-EveryoneIsAuthorized-Client-AlwaysAuthorize-#ctor-OpenCardServices-Validator-ICreditCardValidator-'></a>
### #ctor(creditCardValidator) `constructor`

##### Summary

Create an authorizer using a provided credit card validator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| creditCardValidator | [OpenCardServices.Validator.ICreditCardValidator](#T-OpenCardServices-Validator-ICreditCardValidator 'OpenCardServices.Validator.ICreditCardValidator') | The ICreditCardValidator instance to use. |

<a name='M-EveryoneIsAuthorized-Client-AlwaysAuthorize-Authorize-System-Double,System-String-'></a>
### Authorize(amt,number) `method`

##### Summary

If an invalid card number is presented the card will always be rejected.
 Otherwide every request is authorized regardless of available credit.

##### Returns

A unique token tied to the transaction if the charge is allowed, or null if it is not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| amt | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The amount to charge. |
| number | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The card number to charge. |
