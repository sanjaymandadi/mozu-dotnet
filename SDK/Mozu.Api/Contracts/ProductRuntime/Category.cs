
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


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of the product category that appears on the storefront.
		///
		public class Category
		{
			///
			///Unique identifier for the storefront container used to organize products.
			///
			public int CategoryId { get; set; }

			///
			///If true, the category is displayed on the website storefront.
			///
			public bool IsDisplayed { get; set; }

			///
			///The numeric value that denotes the place this entity occupies in the order of the entity list.
			///
			public int? Sequence { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public CategoryContent Content { get; set; }

			///
			///List of the subcategories in the hierarchy for the specified categories.
			///
			public List<Category> ChildrenCategories { get; set; }

			///
			///If applicable, the parent category in the hierarchy for the specified category.
			///
			public Category ParentCategory { get; set; }

		}

}