
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


namespace Mozu.Api.Contracts.PaymentService
{
		///
		///	Properties of the payment gateway.
		///
		public class GatewayDefinition
		{
			///
			///The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.
			///
			public string CountryCode { get; set; }

			///
			///Credential fields for the payment gateway. For security purposes, Mozu does not return these credential fields.
			///
			public List<GatewayCredentialFieldDefinition> CredentialDefinitions { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///The implementing type name of the integration with the payment gateway.
			///
			public string IntegrationImplTypeName { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///Definition of the preauthorization gateway.
			///
			public PreAuthorizeDefinition PreAuthorizeDefinition { get; set; }

			///
			///URL of the production payment service.
			///
			public string ProdServiceURL { get; set; }

			///
			///The types of credit cards supported by the payment gateway.
			///
			public List<SupportedCard> SupportedCards { get; set; }

			///
			///URL of the test payment service environment.
			///
			public string TestServiceURL { get; set; }

		}

}