
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class DiscountUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDiscounts
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDiscountsUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDiscountContent
        /// </summary>
        /// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDiscountContentUrl(int discountId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}/content?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDiscount
        /// </summary>
        /// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDiscountUrl(int discountId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GenerateRandomCoupon
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GenerateRandomCouponUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/generate-random-coupon?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateDiscount
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateDiscountUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AssociateCouponSet
        /// </summary>
        /// <param name="discountId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AssociateCouponSetUrl(int discountId)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}/couponsets/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateDiscountContent
        /// </summary>
        /// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDiscountContentUrl(int discountId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}/content?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateDiscount
        /// </summary>
        /// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDiscountUrl(int discountId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteDiscount
        /// </summary>
        /// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteDiscountUrl(int discountId)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DisassociateCouponSet
        /// </summary>
        /// <param name="discountId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DisassociateCouponSetUrl(int discountId)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}/couponsets/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			return mozuUrl;
		}

		
	}
}

