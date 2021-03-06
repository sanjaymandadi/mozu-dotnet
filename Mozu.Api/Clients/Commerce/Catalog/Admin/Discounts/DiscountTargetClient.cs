
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts
{
	/// <summary>
	/// Retrieves and modifies the products, categories, and shipping methods eligible for discounts in the form of a fixed dollar amount, percentage off a product price, or free shipping.
	/// </summary>
	public partial class DiscountTargetClient 	{
		
		/// <summary>
		/// Retrieves the discount target, that is which products, categories, or shipping methods are eligible for the discount.
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountTarget"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDiscountTarget(dataViewMode,  discountId,  responseFields);
		///   var discountTargetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> GetDiscountTargetClient(DataViewMode dataViewMode, int discountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Discounts.DiscountTargetUrl.GetDiscountTargetUrl(discountId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Modifies properties of the discount target, for example, the dollar amount, or precentage off the price.
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="discountTarget">Properties of the target to which the discount applies, such as the type of discount and which products, categories, or shipping methods are eligible for the discount and the properties of this discount target.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountTarget"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDiscountTarget( discountTarget,  discountId,  responseFields);
		///   var discountTargetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> UpdateDiscountTargetClient(Mozu.Api.Contracts.ProductAdmin.DiscountTarget discountTarget, int discountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Discounts.DiscountTargetUrl.UpdateDiscountTargetUrl(discountId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.DiscountTarget>(discountTarget);
			return mozuClient;

		}


	}

}


