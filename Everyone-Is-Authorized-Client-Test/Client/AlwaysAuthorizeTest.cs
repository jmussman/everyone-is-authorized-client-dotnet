// AlwaysAuthorizeTests.java
// Copyright © 2020 Joel Mussman. All rights reserved.
//

using System;
using Xunit;
using Moq;
using com.wonderfulwidgets.retail;

namespace com.everyoneisauthorized.client {

    public class AlwaysAuthorizeTests {

        Mock<ICreditCardValidator> moqCreditCardValidator;
        AlwaysAuthorize authorizer;

        private void GivenMoqCreditCardValidator() {

            moqCreditCardValidator = new Mock<ICreditCardValidator>();
            authorizer = new AlwaysAuthorize(moqCreditCardValidator.Object);
        }

        // Verifies the requirement that the credit card validator is actually used
        // and passed the card number by using Mockito to verify the call.
        //
        [Fact]
        public void UsesCreditCardValidator() {

            String cardNumber = "1234";
            double amount = 100.0;

            GivenMoqCreditCardValidator();

            moqCreditCardValidator.Setup(m => m.ValidateCardNumber(cardNumber)).Returns(false);

            authorizer.Authorize(amount, cardNumber);

            moqCreditCardValidator.Verify(v => v.ValidateCardNumber(cardNumber), Times.Once);
        }
    }
}