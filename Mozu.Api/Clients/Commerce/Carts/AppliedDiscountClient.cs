
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

namespace Mozu.Api.Clients.Commerce.Carts
{
	/// <summary>
	/// Use the Cart Coupons subresource to apply a coupon to a defined cart or remove a coupon from a cart. When the shopper proceeds to checkout, the coupons applied to the cart apply to the order.
	/// </summary>
	public partial class AppliedDiscountClient 	{
		
		/// <summary>
		/// Applies a defined coupon to the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ApplyCoupon( cartId,  couponCode,  responseFields);
		///   var cartClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> ApplyCouponClient(string cartId, string couponCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.AppliedDiscountUrl.ApplyCouponUrl(cartId, couponCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Removes all coupons from the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveCoupons( cartId);
		///   var cartClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> RemoveCouponsClient(string cartId)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.AppliedDiscountUrl.RemoveCouponsUrl(cartId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Removes an applied coupon from the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveCoupon( cartId,  couponCode);
		///   var cartClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> RemoveCouponClient(string cartId, string couponCode)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.AppliedDiscountUrl.RemoveCouponUrl(cartId, couponCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


