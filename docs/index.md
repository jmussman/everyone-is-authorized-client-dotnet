<a name='assembly'></a>
# Everyone-Is-Authorized-Client

## Contents

- [AlwaysAuthorize](#T-com-everyoneisauthorized-client-AlwaysAuthorize 'com.everyoneisauthorized.client.AlwaysAuthorize')
  - [#ctor()](#M-com-everyoneisauthorized-client-AlwaysAuthorize-#ctor 'com.everyoneisauthorized.client.AlwaysAuthorize.#ctor')
  - [#ctor(creditCardValidator)](#M-com-everyoneisauthorized-client-AlwaysAuthorize-#ctor-com-wonderfulwidgets-retail-ICreditCardValidator- 'com.everyoneisauthorized.client.AlwaysAuthorize.#ctor(com.wonderfulwidgets.retail.ICreditCardValidator)')
  - [Authorize(amt,number)](#M-com-everyoneisauthorized-client-AlwaysAuthorize-Authorize-System-Double,System-String- 'com.everyoneisauthorized.client.AlwaysAuthorize.Authorize(System.Double,System.String)')

<a name='T-com-everyoneisauthorized-client-AlwaysAuthorize'></a>
## AlwaysAuthorize `type`

##### Namespace

com.everyoneisauthorized.client

##### Summary

Client interface to the credit card processing services for Everyone is Authorized.

<a name='M-com-everyoneisauthorized-client-AlwaysAuthorize-#ctor'></a>
### #ctor() `constructor`

##### Summary

Create an authorizer using an instance of CreditCardValidator.

##### Parameters

This constructor has no parameters.

<a name='M-com-everyoneisauthorized-client-AlwaysAuthorize-#ctor-com-wonderfulwidgets-retail-ICreditCardValidator-'></a>
### #ctor(creditCardValidator) `constructor`

##### Summary

Create an authorizer using a provided credit card validator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| creditCardValidator | [com.wonderfulwidgets.retail.ICreditCardValidator](#T-com-wonderfulwidgets-retail-ICreditCardValidator 'com.wonderfulwidgets.retail.ICreditCardValidator') | The ICreditCardValidator instance to use. |

<a name='M-com-everyoneisauthorized-client-AlwaysAuthorize-Authorize-System-Double,System-String-'></a>
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
