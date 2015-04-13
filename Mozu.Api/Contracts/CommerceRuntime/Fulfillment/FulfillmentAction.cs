
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


namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of an action to perform when fulfilling an item in an order, whether through in-store pickup or direct shipping.
		///
		public class FulfillmentAction
		{
			///
			///The name of the fulfillment action to perform for the purchased product. Options include "Ship" or "PickUp" (in-store pick-up).
			///
			public string ActionName { get; set; }

			///
			///The digital package ID identifies the package to update on the order.
			///
			public List<string> DigitalPackageIds { get; set; }

			///
			///Array list of unique IDs of packages in a shipment planned for or finished a shipping fulfillment action. 
			///
			public List<string> PackageIds { get; set; }

			///
			///Array list of in-store pickups for which to perform the fulfillment action.
			///
			public List<string> PickupIds { get; set; }

		}

}