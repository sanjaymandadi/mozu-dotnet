
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		public class DigitalPackageItem
		{
			///
			///This specifies the fulfillment type of digital package item.
			///
			public string FulfillmentItemType { get; set; }

			///
			///Specifies the gift card code for the digital package item.
			///
			public string GiftCardCode { get; set; }

			public int LineId { get; set; }

			///
			///The unique, user-defined  product code of a product, used throughout Mozu to reference and associate to a product.
			///
			public string ProductCode { get; set; }

			///
			///The specified quantity of objects and items. This property is used for numerous object types including products, options, components within a product bundle, cart and order items, returned items, shipping line items, items in a digital product. and items associated with types and reservations.
			///
			public int Quantity { get; set; }

		}

}