
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the Properties resource to configure a property attribute for an individual product associated with a product type that uses the property attribute, as well as set property values for the product.
	/// </summary>
	public partial class ProductPropertyClient 	{
		
		/// <summary>
		/// Retrieves a list of the property attributes configured for the product specified in the request.
		/// </summary>
		/// <param name="productCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProperties(dataViewMode,  productCode);
		///   var productPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductProperty>> GetPropertiesClient(DataViewMode dataViewMode, string productCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.GetPropertiesUrl(productCode);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPropertyValueLocalizedContents(dataViewMode,  productCode,  attributeFQN,  value);
		///   var productPropertyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>> GetPropertyValueLocalizedContentsClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string value)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.GetPropertyValueLocalizedContentsUrl(productCode, attributeFQN, value);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPropertyValueLocalizedContent(dataViewMode,  productCode,  attributeFQN,  value,  localeCode,  responseFields);
		///   var productPropertyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> GetPropertyValueLocalizedContentClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.GetPropertyValueLocalizedContentUrl(productCode, attributeFQN, value, localeCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a property attribute configuration for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProperty(dataViewMode,  productCode,  attributeFQN,  responseFields);
		///   var productPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> GetPropertyClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.GetPropertyUrl(productCode, attributeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="localizedContent"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddPropertyValueLocalizedContent(dataViewMode,  localizedContent,  productCode,  attributeFQN,  value,  responseFields);
		///   var productPropertyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> AddPropertyValueLocalizedContentClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent localizedContent, string productCode, string attributeFQN, string value, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.AddPropertyValueLocalizedContentUrl(productCode, attributeFQN, value, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>(localizedContent)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Configures a property attribute for the product specified in the request.
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="productProperty">Properties of the property attribute to configure for a product.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddProperty(dataViewMode,  productProperty,  productCode,  responseFields);
		///   var productPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> AddPropertyClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductProperty productProperty, string productCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.AddPropertyUrl(productCode, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductProperty>(productProperty)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <param name="localizedContent"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePropertyValueLocalizedContents(dataViewMode,  localizedContent,  productCode,  attributeFQN,  value);
		///   var productPropertyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>> UpdatePropertyValueLocalizedContentsClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> localizedContent, string productCode, string attributeFQN, string value)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.UpdatePropertyValueLocalizedContentsUrl(productCode, attributeFQN, value);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>>(localizedContent)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="localizedContent"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePropertyValueLocalizedContent(dataViewMode,  localizedContent,  productCode,  attributeFQN,  value,  localeCode,  responseFields);
		///   var productPropertyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> UpdatePropertyValueLocalizedContentClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent localizedContent, string productCode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.UpdatePropertyValueLocalizedContentUrl(productCode, attributeFQN, value, localeCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>(localizedContent)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Update one or more details of a property attribute configuration for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="productProperty">Details of the property attribute to update for the product configuration.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProperty(dataViewMode,  productProperty,  productCode,  attributeFQN,  responseFields);
		///   var productPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> UpdatePropertyClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductProperty productProperty, string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.UpdatePropertyUrl(productCode, attributeFQN, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductProperty>(productProperty)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes the configuration of a property attribute for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProperty(dataViewMode,  productCode,  attributeFQN);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePropertyClient(DataViewMode dataViewMode, string productCode, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.DeletePropertyUrl(productCode, attributeFQN);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePropertyValueLocalizedContent(dataViewMode,  productCode,  attributeFQN,  value,  localeCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePropertyValueLocalizedContentClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string value, string localeCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductPropertyUrl.DeletePropertyValueLocalizedContentUrl(productCode, attributeFQN, value, localeCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}

