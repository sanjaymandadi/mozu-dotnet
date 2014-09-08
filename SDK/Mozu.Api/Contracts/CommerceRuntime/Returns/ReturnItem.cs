
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

using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Contracts.CommerceRuntime.Products;

namespace Mozu.Api.Contracts.CommerceRuntime.Returns
{
		///
		///	Properties of a previously fulfilled item associated with a return.
		///
		public class ReturnItem
		{
			public string Id { get; set; }

			///
			///Unique identifier of the item in the original completed order. All return items should be associated with a corresponding order item.
			///
			public string OrderItemId { get; set; }

			///
			///The total value of the product returned to the merchant for accounting purposes, calculated by multiplying the cost of the item by its quantity returned.
			///
			public decimal? ProductLossAmount { get; set; }

			///
			///The total tax amount levied on the product loss amount.
			///
			public decimal? ProductLossTaxAmount { get; set; }

			///
			///The actual quantity received for the return item.
			///
			public int QuantityReceived { get; set; }

			///
			///The quantity of returned items that can be returned to active product stock.
			///
			public int QuantityRestockable { get; set; }

			///
			///The quantity of the item shipped to the shopper in the event of a return item replacement.
			///
			public int QuantityShipped { get; set; }

			///
			///The total value of shipping the returned product to the merchant for accounting purposes, calculated by multiplying the shipping cost of the item by its quantity returned.
			///
			public decimal? ShippingLossAmount { get; set; }

			///
			///The total tax amount levied on the shipping loss amount.
			///
			public decimal? ShippingLossTaxAmount { get; set; }

			public List<ReturnBundle> BundledProducts { get; set; }

			///
			///List of merchant-supplied notes associated with the return item.
			///
			public List<OrderNote> Notes { get; set; }

			///
			///Properties of the product definition associated with the item in the return.
			///
			public Product Product { get; set; }

			///
			///The list of return reasons for the item and the quantity associated with each return reason.
			///
			public List<ReturnReason> Reasons { get; set; }

		}

}