
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Payments
{
		///
		///	Properties of an interaction with the payment gateway.
		///
		public class PaymentGatewayInteraction
		{
			///
			///If required by the payment gateway, the authorization code of the transaction.
			///
			public string GatewayAuthCode { get; set; }

			///
			///AVS codes supplied by the payment gateway.
			///
			public string GatewayAVSCodes { get; set; }

			///
			///CVV2 codes supplied by the payment gateway.
			///
			public string GatewayCVV2Codes { get; set; }

			///
			///Unique identifier of the payment interaction from the payment gateway.
			///
			public int? GatewayInteractionId { get; set; }

			///
			///Response code from the gateway associated with the payment interaction. For example, if the gateway returns "Not Authorized," an interaction for voiding the payment transaction would result.
			///
			public string GatewayResponseCode { get; set; }

			///
			///Textual message returned by the payment gateway.
			///
			public string GatewayResponseText { get; set; }

			///
			///Unique identifier of the gateway transaction associated with the payment interaction.
			///
			public string GatewayTransactionId { get; set; }

		}

}