//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use the Product Search resource to provide dynamic search results to shoppers as they browse and search for products on the web storefront, and to suggest possible search terms as the shopper enters text.
	/// </summary>
	public partial class StorefrontProductSearchResultFactory : BaseDataFactory
	{

		/// <summary> 
		/// Searches the categories displayed on the web storefront for products or product options that the shopper types in a search query.
		/// <example> 
		///  <code> 
		/// var result = ProductSearchResultFactory.Search(handler : handler,  query :  query,  filter :  filter,  facetTemplate :  facetTemplate,  facetTemplateSubset :  facetTemplateSubset,  facet :  facet,  facetFieldRangeQuery :  facetFieldRangeQuery,  facetHierPrefix :  facetHierPrefix,  facetHierValue :  facetHierValue,  facetHierDepth :  facetHierDepth,  facetStartIndex :  facetStartIndex,  facetPageSize :  facetPageSize,  facetSettings :  facetSettings,  facetValueFilter :  facetValueFilter,  sortBy :  sortBy,  pageSize :  pageSize,  startIndex :  startIndex,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductSearchResult/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.ProductSearchResult Search(ServiceClientMessageHandler handler, 
 		 string query = null, string filter = null, string facetTemplate = null, string facetTemplateSubset = null, string facet = null, string facetFieldRangeQuery = null, string facetHierPrefix = null, string facetHierValue = null, string facetHierDepth = null, string facetStartIndex = null, string facetPageSize = null, string facetSettings = null, string facetValueFilter = null, string sortBy = null, int? pageSize = null, int? startIndex = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.SearchClient(
				 query :  query,  filter :  filter,  facetTemplate :  facetTemplate,  facetTemplateSubset :  facetTemplateSubset,  facet :  facet,  facetFieldRangeQuery :  facetFieldRangeQuery,  facetHierPrefix :  facetHierPrefix,  facetHierValue :  facetHierValue,  facetHierDepth :  facetHierDepth,  facetStartIndex :  facetStartIndex,  facetPageSize :  facetPageSize,  facetSettings :  facetSettings,  facetValueFilter :  facetValueFilter,  sortBy :  sortBy,  pageSize :  pageSize,  startIndex :  startIndex,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Suggests possible search terms as the shopper enters search text.
		/// <example> 
		///  <code> 
		/// var result = ProductSearchResultFactory.Suggest(handler : handler,  query :  query,  groups :  groups,  pageSize :  pageSize,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<SearchSuggestionResult/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult Suggest(ServiceClientMessageHandler handler, 
 		 string query = null, string groups = null, int? pageSize = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.SuggestClient(
				 query :  query,  groups :  groups,  pageSize :  pageSize,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


