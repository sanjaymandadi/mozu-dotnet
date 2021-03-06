
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.SiteSettings.Order
{
		///
		///	Mozu.SiteSettings.Order.Contracts.LocalizedContent ApiType DOCUMENT_HERE 
		///
		public class LocalizedContent
		{
			///
			///The two character locale code, per the country code provided. This code determines the localized content to use and display.
			///
			public string LocaleCode { get; set; }

			///
			///The value of a property, used by numerous objects within Mozu including facets, attributes, products, localized content, metadata, capabilities (Mozu and third-party), location inventory adjustment, and more. The value may be a string, integer, or double. Validation may be run against the entered and saved values depending on the object type.
			///
			public string Value { get; set; }

		}

}