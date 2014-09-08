
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
		///	Properties of an individual product catalog.
		///
		public class Catalog
		{
			///
			///The date and time the catalog was deleted.
			///
			public DateTime DeleteDate { get; set; }

			public int Id { get; set; }

			public DateTime CreateDate { get; set; }

			///
			///The default currency code for the product catalog. Currently, only "USD" is supported.
			///
			public string DefaultCurrencyCode { get; set; }

			///
			///The default locale code for the product catalog. Currently, only "en-US" is supported.
			///
			public string DefaultLocaleCode { get; set; }

			///
			///If true, the catalog has been deleted.
			///
			public bool IsDeleted { get; set; }

			public int MasterCatalogId { get; set; }

			///
			///The user-defined name of the product catalog.
			///
			public string Name { get; set; }

			public string Status { get; set; }

			public int TenantId { get; set; }

			public DateTime UpdateDate { get; set; }

		}

}