
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Tenant
{
		///
		///	Properties of a site associated with a tenant.
		///
		public class Site
		{
			///
			///The unique identifier of the catalog of products used by a site.
			///
			public int CatalogId { get; set; }

			public string CountryCode { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///The domain associated with the site and/or tenant.
			///
			public string Domain { get; set; }

			public int Id { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///The primary custom domain of the site.
			///
			public string PrimaryCustomDomain { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int TenantId { get; set; }

		}

}