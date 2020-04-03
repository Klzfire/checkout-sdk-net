using System;
using System.Collections.Generic;
using Checkout.Common;
using Checkout.Payments;
using Checkout.Sources;
using Checkout.Tokens;

namespace Checkout.Tests
{
    public static class TestHelper
    {
        public static PaymentRequest<CardSource> CreateCardPaymentRequest(long? amount = 100)
        {
            return new PaymentRequest<CardSource>(
                new CardSource(TestCardSource.Visa.Number, TestCardSource.Visa.ExpiryMonth, TestCardSource.Visa.ExpiryYear)
                {
                    Cvv = TestCardSource.Visa.Cvv
                },
                Currency.GBP,
                amount
            )
            {
                Capture = false,
                Customer = new Checkout.Payments.CustomerRequest() { Email = TestHelper.GenerateRandomEmail()},
                Reference = Guid.NewGuid().ToString()
            };
        }

        public static PaymentRequest<DlocalCardSource> CreateDlocalCardPaymentRequest(long? amount = 100)
        {
            var dlocalCardSource = new DlocalCardSource(TestCardSource.Visa.Number, TestCardSource.Visa.ExpiryMonth, TestCardSource.Visa.ExpiryYear)
            {
                Cvv = TestCardSource.Visa.Cvv
            };

            dlocalCardSource.Name = "Some Random Name";
            
            var dlocalCardPaymentRequest = new PaymentRequest<DlocalCardSource>(
                dlocalCardSource,
                Currency.BRL,
                amount
            )
            {
                Capture = false,
                Customer = new Checkout.Payments.CustomerRequest() { Email = TestHelper.GenerateRandomEmail() },
                Reference = Guid.NewGuid().ToString()
            };

            var dLocalProcessing = new
            {
                country = "BR", 
                payer = new
                {
                    document = "53033315550",
                    name = "Bill Gates",
                    email = "test@checkout.com"
                },
                installments = new { count = 4 }
            };

            
            dlocalCardPaymentRequest.Reference = "random";
            dlocalCardPaymentRequest.BillingDescriptor = new BillingDescriptor("billdescriptor", "gotham");
            dlocalCardPaymentRequest.Processing.Add("dlocal", dLocalProcessing);
            return dlocalCardPaymentRequest;
        }
        public static PaymentRequest<IRequestSource> CreateAlternativePaymentMethodRequest(IRequestSource alternativePaymentMethodRequestSource, string currency, long? amount = 100)
        {
            return new PaymentRequest<IRequestSource>(
                alternativePaymentMethodRequestSource,
                currency,
                amount
            )
            {
                Capture = false,
                Customer = new Checkout.Payments.CustomerRequest() { Email = TestHelper.GenerateRandomEmail() },
                Reference = Guid.NewGuid().ToString()
            };
        }

        public static CardTokenRequest CreateCardTokenRequest()
        {
            return new CardTokenRequest(TestCardSource.Visa.Number, TestCardSource.Visa.ExpiryMonth,
                TestCardSource.Visa.ExpiryYear)
            {
                Cvv = TestCardSource.Visa.Cvv
            };
        }

        public static string GenerateRandomEmail()
        {
            return Guid.NewGuid().ToString("n") + "@checkout-sdk-net.com";
        }

        public static PaymentRequest<TokenSource> CreateTokenPaymentRequest(string token)
        {
            return new PaymentRequest<TokenSource>(new TokenSource(token),
                    Currency.GBP,
                    100)
                    {
                        Capture = false
                    };
        }
    }
}
