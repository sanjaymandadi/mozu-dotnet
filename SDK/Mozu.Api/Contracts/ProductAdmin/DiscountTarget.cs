
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


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Specifies what to discount such as the type of discount and which products, categories, or shipping methods are eligible for the discount. Discount types can include the percentage off, specific monetary amount, or free shipping. This parameter also specifies the minimum monetary amount that the order must meet for the discount to apply.
		///
		public class DiscountTarget
		{
			///
			///If true, the target discount applies to all products sold on the storefront.
			///
			public bool? IncludeAllProducts { get; set; }

			public int? MaximumQuantityPerRedemption { get; set; }

			///
			///The type of target to which the discount applies, such as a product or shipping.
			///
			public string Type { get; set; }

			///
			///The product categories to which the discount can apply.
			///
			public List<TargetedCategory> Categories { get; set; }

			///
			///Array list of categories to exclude for this discount.
			///
			public List<TargetedCategory> ExcludedCategories { get; set; }

			///
			///Array list of products to exclude for this discount.
			///
			public List<TargetedProduct> ExcludedProducts { get; set; }

			///
			///The products to which the discount can apply.
			///
			public List<TargetedProduct> Products { get; set; }

			///
			///The list of shipping method parameters that describe a method including the code, localized content, and audit information.
			///
			public List<TargetedShippingMethod> ShippingMethods { get; set; }

			public List<TargetedShippingZone> ShippingZones { get; set; }

		}

}