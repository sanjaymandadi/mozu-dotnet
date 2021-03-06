
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


namespace Mozu.Api.Contracts.SiteSettings.Order
{
		///
		///	Properties of an external payment processing workflow defined for the site. At this time, only PayPal Express is supported.
		///
		public class ExternalPaymentWorkflowDefinition
		{
			///
			///The credential fields required to communicate with the external payment processor.
			///
			public List<ThirdPartyCredentialField> Credentials { get; set; }

			///
			///The localized description in text for the object, displayed per the locale code. For example, descriptions are used for product descriptions, attributes, and pre-authorization transaction types.
			///
			public string Description { get; set; }

			///
			///Fully qualified name of the attribute for the order or customer. 
			///
			public string FullyQualifiedName { get; set; }

			///
			///Indicates if the object or process is enabled. This indicator is used on external payment workflows and product option values. For product options, if true, the product option value is available for a shopper to choose. During configuration, this property will be false if the option value is invalid with other selected options. For external payment workflows, if true, the workflow is enabled and available for routing payments for the submitted order.
			///
			public bool IsEnabled { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///If applicable, the registered namespace associated with objects, used to generate the fully qualified name. If no namespace is defined, the namespace associated with the tenant is automatically assigned.
			///
			public string Namespace { get; set; }

		}

}