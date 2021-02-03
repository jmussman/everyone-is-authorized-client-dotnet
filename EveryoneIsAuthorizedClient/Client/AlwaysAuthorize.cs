// AlwaysAuthorize.java
// Copyright © 2020 Joel Mussman. All rights reserved.
//

using System;
using OpenCardServices.Validator;

namespace EveryoneIsAuthorized.Client {

    /// <summary>
    /// Client interface to the credit card processing services for Everyone is Authorized.
    /// </summary>
    public class AlwaysAuthorize {

        ICreditCardValidator creditCardValidator = new CreditCardValidator();

        /// <summary>Create an authorizer using an instance of CreditCardValidator.</summary>
        public AlwaysAuthorize() {

            creditCardValidator = new CreditCardValidator();
        }

        /// <summary>Create an authorizer using a provided credit card validator.</summary>
        /// <param name="creditCardValidator">The ICreditCardValidator instance to use.</param>
        public AlwaysAuthorize(ICreditCardValidator creditCardValidator) {

            this.creditCardValidator = creditCardValidator;
        }

        /// <summary>
        /// If an invalid card number is presented the card will always be rejected.
        /// Otherwide every request is authorized regardless of available credit.
        /// </summary>
        ///
        /// <param name="amt">The amount to charge.</param>
        /// <param name="number">The card number to charge.</param>
        /// <returns>A unique token tied to the transaction if the charge is allowed, or null if it is not.</returns>
        public String Authorize(double amt, String number) {

            String result = null;

            try {

                if (creditCardValidator.ValidateCardNumber(number)) {

                    result = System.Guid.NewGuid().ToString();
                }
            }

            catch (NullReferenceException) {

                // Do nothing, null will be returned as a failure to purchase.
            }

            return result;
        }
    }
}