
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
		///	Properties of the product option to create such as attribute detail, fully qualified name, and list of product option values.
		///
		public class ProductOption
		{
			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///List of value data for objects.
			///
			public List<ProductOptionValue> Values { get; set; }

		}

}