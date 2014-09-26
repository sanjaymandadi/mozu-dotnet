
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
		///	Describes the scope of the product publishing update, which can include individual product codes or all pending changes.
		///
		public class PublishingScope
		{
			///
			///If true, publish or discard all pending product changes in the master catalog.
			///
			public bool? AllPending { get; set; }

			///
			///List of product codes for each pending product change you want to publish or delete.
			///
			public List<string> ProductCodes { get; set; }

		}

}