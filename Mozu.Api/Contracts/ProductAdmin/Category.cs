
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	A descriptive container that groups products. A category is merchant defined with associated products and discounts as configured. GThe storefront displays products in a hierarchy of categories. As such, categories can include a nesting of sub-categories to organize products and product options per set guidelines such as color, brand, material, and size.
		///
		public class Category
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			public int? CatalogId { get; set; }

			///
			///External unique identifier of the category.
			///
			public string CategoryCode { get; set; }

			///
			///The Type of Category Static, Dyanmic, DynamicPreComputed
			///
			public string CategoryType { get; set; }

			///
			///The number of children (subcategories, for example) that stem from a parent (top-level category).
			///
			public int? ChildCount { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public CategoryLocalizedContent Content { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.Category dynamicExpression ApiTypeMember DOCUMENT_HERE 
			///
			public DynamicExpression DynamicExpression { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public int? Id { get; set; }

			///
			///Indicates if the object is displayed on the storefront. If true, the admin product category is displayed in the store. If true, the category is not displayed.
			///
			public bool? IsDisplayed { get; set; }

			///
			///Identifier of the parent or top-level category.
			///
			public int? ParentCategoryId { get; set; }

			///
			///The total number of products. This total may indicate the total products associate with a product type or number of products in a list.
			///
			public int? ProductCount { get; set; }

			///
			///The numeric order of objects, used by a vocabulary value defined for an extensible attribute, images, and categories.
			///
			public int? Sequence { get; set; }

		}

}