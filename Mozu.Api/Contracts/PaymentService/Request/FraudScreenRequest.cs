
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Mozu.Api.Contracts.PaymentService;

namespace Mozu.Api.Contracts.PaymentService.Request
{
		///
		///	Mozu.PaymentService.Contracts.Request.FraudScreenRequest ApiType DOCUMENT_HERE 
		///
		public class FraudScreenRequest
		{
			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest avsCodes ApiTypeMember DOCUMENT_HERE 
			///
			public string AvsCodes { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest billingAddress ApiTypeMember DOCUMENT_HERE 
			///
			public Address BillingAddress { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest billingContact ApiTypeMember DOCUMENT_HERE 
			///
			public Contact BillingContact { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest cardId ApiTypeMember DOCUMENT_HERE 
			///
			public string CardId { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest cardNumberPart ApiTypeMember DOCUMENT_HERE 
			///
			public string CardNumberPart { get; set; }

			///
			///The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.
			///
			public string CountryCode { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest credentialFieldsOverride ApiTypeMember DOCUMENT_HERE 
			///
			public List<GatewayCredentialFieldValue> CredentialFieldsOverride { get; set; }

			///
			///The localized currency code for the monetary amount. 
			///
			public string CurrencyCode { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest customData ApiTypeMember DOCUMENT_HERE 
			///
			public List<CustomData> CustomData { get; set; }

			///
			///Unique identifier of the customer in Mozu, used to associate customers with data, orders, returns, and in-store credit.
			///
			public string CustomerId { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest cvV2Codes ApiTypeMember DOCUMENT_HERE 
			///
			public string CvV2Codes { get; set; }

			///
			///The two-digit month a credit card expires for a payment method.
			///
			public int ExpireMonth { get; set; }

			///
			///The four-digit year the credit card expires for a payment method.
			///
			public int ExpireYear { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest gatewayAccountId ApiTypeMember DOCUMENT_HERE 
			///
			public string GatewayAccountId { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest merchantTransactionId ApiTypeMember DOCUMENT_HERE 
			///
			public string MerchantTransactionId { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest orderItems ApiTypeMember DOCUMENT_HERE 
			///
			public List<OrderItem> OrderItems { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest orderNumber ApiTypeMember DOCUMENT_HERE 
			///
			public int OrderNumber { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest paymentTransactionId ApiTypeMember DOCUMENT_HERE 
			///
			public string PaymentTransactionId { get; set; }

			///
			///The type of payment, such as credit card, check, or PayPal Express. Additional payment types will be supported in future releases.
			///
			public string PaymentType { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest requestorIp ApiTypeMember DOCUMENT_HERE 
			///
			public string RequestorIp { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest requestorUrl ApiTypeMember DOCUMENT_HERE 
			///
			public string RequestorUrl { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest requestorUserAgent ApiTypeMember DOCUMENT_HERE 
			///
			public string RequestorUserAgent { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest shippingAddress ApiTypeMember DOCUMENT_HERE 
			///
			public Address ShippingAddress { get; set; }

			///
			///Mozu.PaymentService.Contracts.Request.FraudScreenRequest shippingContact ApiTypeMember DOCUMENT_HERE 
			///
			public Contact ShippingContact { get; set; }

			///
			///Total is used to indicate the monetary, estimated total amount of the cart or order, including items, sales tax, shipping costs, and other fees. Totals are not estimated for wish lists at this time.
			///
			public decimal Total { get; set; }

		}

}