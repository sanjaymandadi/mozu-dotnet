
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


namespace Mozu.Api.Contracts.Customer
{
		///
		///	Properties of a customer visit to one of a company's sites.
		///
		public class Visit
		{
			///
			///Unique identifier of the customer account generated by the system. Account IDs are generated at account creation.
			///
			public int? AccountId { get; set; }

			///
			///If the customer visit is made online, the location code associated with the website visited.
			///
			public string BrowserLocationCode { get; set; }

			///
			///The date and time recording for a customer action including a transaction and storefront visit.
			///
			public DateTime Date { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///The unique, user-defined code that identifies a location. This location can be the location where the order was entered, location for newly in-stock products, and where products are returned.
			///
			public string LocationCode { get; set; }

			///
			///Array list of transactions the customer performed during the visit. A customer can perform multiple transactions in a single visit, or the visit can have no associated transactions.
			///
			public List<Transaction> Transactions { get; set; }

			///
			///The type of customer visit, which is "Website," "Store," "Call," or "Unknown."
			///
			public string Type { get; set; }

			///
			///Unique identifier of the customer account (shopper or system user). System-supplied and read-only. If the shopper user is anonymous, the user ID represents a system-generated user ID string.
			///
			public string UserId { get; set; }

			///
			///The HTTP_Referrer that initiatied the visit started. If the shopper was not referred from another source, this value is null.
			///
			public string WebReferrer { get; set; }

			///
			///Unique identifier of the web session in which the cart, order, return, or wish list was created or last modified.
			///
			public string WebSessionId { get; set; }

			///
			///Unique identifier of the site.
			///
			public int? WebSiteId { get; set; }

			///
			///The user agent string for the browser.
			///
			public string WebUserAgent { get; set; }

		}

}