
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

using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.CommerceRuntime.Fulfillment;
using Mozu.Api.Contracts.CommerceRuntime.Discounts;

namespace Mozu.Api.Contracts.CommerceRuntime.Carts
{
		///
		///	Properties of a shopping cart.
		///
		public class Cart
		{
			///
			///Code that identifies the channel associated with the site where the shopping cart was created.
			///
			public string ChannelCode { get; set; }

			public List<string> CouponCodes { get; set; }

			public string CurrencyCode { get; set; }

			///
			///The type of customer interaction used to create this shopping cart. Possible values are Website, Call, Store, or Unknown.
			///
			public string CustomerInteractionType { get; set; }

			///
			///The aggregate total for all items in the cart, including costs associated with shopper-defined options or extras and any applied discounts.
			///
			public decimal? DiscountedSubtotal { get; set; }

			///
			///The subtotal of the cart including any applied discount calculations.
			///
			public decimal? DiscountedTotal { get; set; }

			///
			///Estimated amount of discounts applied to all items in the cart, which is system-supplied and read-only.
			///
			public decimal? DiscountTotal { get; set; }

			///
			///Date in UTC Date/Time when the cart becomes inactive based on a system-calculated interval. For example, if an anonymous shopper has 14 days of inactivity, the cart is considered abandoned after that period of inactivity. System-supplied and read-only.
			///
			public DateTime? ExpirationDate { get; set; }

			///
			///The monetary sum of all fees incurred in the cart.
			///
			public decimal? FeeTotal { get; set; }

			///
			///If the handling fee for the cart is subject to sales tax, the total tax amount.
			///
			public decimal? HandlingTaxTotal { get; set; }

			///
			///Unique identifier of the shopping cart.
			///
			public string Id { get; set; }

			///
			///The total amount of tax for items in the cart.
			///
			public decimal? ItemTaxTotal { get; set; }

			///
			///The date in UTC Date/Time when the items in the cart were last validated against the site's product catalog. System-supplied and read-only.
			///
			public DateTime? LastValidationDate { get; set; }

			///
			///The shipping subtotal amount calculated without any applied discounts.
			///
			public decimal? ShippingSubTotal { get; set; }

			///
			///The total amount of tax incurred on the shipping charges in the cart.
			///
			public decimal? ShippingTaxTotal { get; set; }

			///
			///The total shipping amount estimated for the cart, including tax.
			///
			public decimal? ShippingTotal { get; set; }

			///
			///Unique identifier of the site.
			///
			public int? SiteId { get; set; }

			///
			///Estimated amount of the cart without sales tax, shipping costs, and other fees.
			///
			public decimal? Subtotal { get; set; }

			///
			///The total sum of sales tax estimated for a cart.
			///
			public decimal? TaxTotal { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int? TenantId { get; set; }

			///
			///Estimated total amount of the cart, including items, sales tax, shipping costs, and other fees.
			///
			public decimal? Total { get; set; }

			///
			///Unique identifier of the user associated with the shopping cart.
			///
			public string UserId { get; set; }

			///
			///Unique identifier of the customer visit in which the cart was created or last modified.
			///
			public string VisitId { get; set; }

			///
			///Unique identifier of the web session in which the cart was created or last modified.
			///
			public string WebSessionId { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Messages logged or created each time the cart was modified.
			///
			public List<ChangeMessage> ChangeMessages { get; set; }

			///
			///Properties of the information required to fulfill this cart.
			///
			public FulfillmentInfo FulfillmentInfo { get; set; }

			public List<InvalidCoupon> InvalidCoupons { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<CartItem> Items { get; set; }

			///
			///List of order-level discounts projected to apply to the cart at checkout.
			///
			public List<AppliedDiscount> OrderDiscounts { get; set; }

		}

}