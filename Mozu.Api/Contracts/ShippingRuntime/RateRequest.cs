
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ShippingRuntime
{
		///
		///	Properties required to request a shipping rate calculation.
		///
		public class RateRequest
		{
			///
			///List of shipping carriers for which to retrieve shipping rate information.
			///
			public List<string> CarrierIds { get; set; }

			///
			///Collection of carrier-specific key-value attribute pairs associated with a shipping carrier. These are required to retrieve a shipping rate request and are returned for the generated shipping label.
			///
			public List<CustomAttribute> CustomAttributes { get; set; }

			public JObject Data { get; set; }

			///
			///The physical address orders are sent to as a shipping destination. This address may contain multiple lines, city, state/province, country, and zip/postal code. The destination is used to calculate shipping costs.
			///
			public Address DestinationAddress { get; set; }

			///
			///The estimated date and time the shipment will be shipped to the shopper. This calculation is based on product stock, availability, date of order entry, and location.
			///
			public DateTime? EstimatedShipmentDate { get; set; }

			///
			///If true, the destination address associated with the shipping rate request is a commercial address.
			///
			public bool? IsDestinationAddressCommercial { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string IsoCurrencyCode { get; set; }

			///
			///Collection list of items. All returned data is provided in an items array. For a failed request, the returned response may be success with an empty item collection. Items are used throughout APIs for carts, wish lists, documents, payments, returns, properties, and more.
			///
			public List<RateRequestItem> Items { get; set; }

			///
			///The total monetary amount of the order. This amount is used to calculate the shipping rate estimate.
			///
			public decimal? OrderTotal { get; set; }

			///
			///The physical address from which the order or shipment will ship.
			///
			public Address OriginAddress { get; set; }

			///
			///The shipping methods associated with this request.
			///
			public List<string> ShippingServiceTypes { get; set; }

		}

}