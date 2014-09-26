
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Credits resource to manage the store credit associated with a customer account. Store credit can represent a static amount the customer can redeem at any of the tenant's sites, or a gift card registered for a customer account. At this time, gift card functionality is reserved for future use.
	/// </summary>
	public partial class CreditClient 	{
		
		/// <summary>
		/// Retrieves a list of store credits applied to customer accounts, according any filter and sort criteria specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Credit.CreditCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCredits( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var creditCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditCollection> GetCreditsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CreditUrl.GetCreditsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a store credit applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code that identifies the store credit to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCredit( code,  responseFields);
		///   var creditClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> GetCreditClient(string code, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CreditUrl.GetCreditUrl(code, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new store credit for the customer account specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="credit">Properties of the store credit to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddCredit( credit,  responseFields);
		///   var creditClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> AddCreditClient(Mozu.Api.Contracts.Customer.Credit.Credit credit, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CreditUrl.AddCreditUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.Credit.Credit>(credit);
			return mozuClient;

		}

		/// <summary>
		/// Associates an unclaimed customer credit with the shopper user authenticated in the request header.
		/// </summary>
		/// <param name="code">The code that represents the credit to claim for the shopper.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AssociateCreditToShopper( code,  responseFields);
		///   var creditClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> AssociateCreditToShopperClient(string code, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CreditUrl.AssociateCreditToShopperUrl(code, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of a defined store credit applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code of the store credit to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="credit">Properties of the store credit to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCredit( credit,  code,  responseFields);
		///   var creditClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> UpdateCreditClient(Mozu.Api.Contracts.Customer.Credit.Credit credit, string code, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CreditUrl.UpdateCreditUrl(code, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.Credit.Credit>(credit);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a store credit previously applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code of the store credit to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCredit( code);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCreditClient(string code)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CreditUrl.DeleteCreditUrl(code);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


