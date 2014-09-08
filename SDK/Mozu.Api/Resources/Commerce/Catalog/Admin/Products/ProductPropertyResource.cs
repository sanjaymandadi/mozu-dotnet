
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the Properties resource to configure a property attribute for an individual product associated with a product type that uses the property attribute, as well as set property values for the product.
	/// </summary>
	public partial class ProductPropertyResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public ProductPropertyResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public ProductPropertyResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductPropertyResource(_apiContext.CloneWith(contextModification));
		}

		public ProductPropertyResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves a list of the property attributes configured for the product specified in the request.
		/// </summary>
		/// <param name="productCode"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productProperty = productproperty.GetProperties(_dataViewMode,  productCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductProperty> GetProperties(string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductProperty>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertiesClient(_dataViewMode,  productCode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductProperty>> GetPropertiesAsync(string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductProperty>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertiesClient(_dataViewMode,  productCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productPropertyValueLocalizedContent = productproperty.GetPropertyValueLocalizedContents(_dataViewMode,  productCode,  attributeFQN,  value);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> GetPropertyValueLocalizedContents(string productCode, string attributeFQN, string value)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertyValueLocalizedContentsClient(_dataViewMode,  productCode,  attributeFQN,  value);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>> GetPropertyValueLocalizedContentsAsync(string productCode, string attributeFQN, string value)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertyValueLocalizedContentsClient(_dataViewMode,  productCode,  attributeFQN,  value);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

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
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productPropertyValueLocalizedContent = productproperty.GetPropertyValueLocalizedContent(_dataViewMode,  productCode,  attributeFQN,  value,  localeCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent GetPropertyValueLocalizedContent(string productCode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertyValueLocalizedContentClient(_dataViewMode,  productCode,  attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> GetPropertyValueLocalizedContentAsync(string productCode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertyValueLocalizedContentClient(_dataViewMode,  productCode,  attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a property attribute configuration for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productProperty = productproperty.GetProperty(_dataViewMode,  productCode,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductProperty GetProperty(string productCode, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertyClient(_dataViewMode,  productCode,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductProperty> GetPropertyAsync(string productCode, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertyClient(_dataViewMode,  productCode,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

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
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productPropertyValueLocalizedContent = productproperty.AddPropertyValueLocalizedContent(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent AddPropertyValueLocalizedContent(Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent localizedContent, string productCode, string attributeFQN, string value, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.AddPropertyValueLocalizedContentClient(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> AddPropertyValueLocalizedContentAsync(Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent localizedContent, string productCode, string attributeFQN, string value, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.AddPropertyValueLocalizedContentClient(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Configures a property attribute for the product specified in the request.
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="productProperty">Properties of the property attribute to configure for a product.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productProperty = productproperty.AddProperty(_dataViewMode,  productProperty,  productCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductProperty AddProperty(Mozu.Api.Contracts.ProductAdmin.ProductProperty productProperty, string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.AddPropertyClient(_dataViewMode,  productProperty,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductProperty> AddPropertyAsync(Mozu.Api.Contracts.ProductAdmin.ProductProperty productProperty, string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.AddPropertyClient(_dataViewMode,  productProperty,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productPropertyValueLocalizedContent = productproperty.UpdatePropertyValueLocalizedContents(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> UpdatePropertyValueLocalizedContents(List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> localizedContent, string productCode, string attributeFQN, string value)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.UpdatePropertyValueLocalizedContentsClient(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>> UpdatePropertyValueLocalizedContentsAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> localizedContent, string productCode, string attributeFQN, string value)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.UpdatePropertyValueLocalizedContentsClient(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

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
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productPropertyValueLocalizedContent = productproperty.UpdatePropertyValueLocalizedContent(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value,  localeCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent UpdatePropertyValueLocalizedContent(Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent localizedContent, string productCode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.UpdatePropertyValueLocalizedContentClient(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> UpdatePropertyValueLocalizedContentAsync(Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent localizedContent, string productCode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductPropertyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.UpdatePropertyValueLocalizedContentClient(_dataViewMode,  localizedContent,  productCode,  attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update one or more details of a property attribute configuration for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="productProperty">Details of the property attribute to update for the product configuration.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productProperty = productproperty.UpdateProperty(_dataViewMode,  productProperty,  productCode,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductProperty UpdateProperty(Mozu.Api.Contracts.ProductAdmin.ProductProperty productProperty, string productCode, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.UpdatePropertyClient(_dataViewMode,  productProperty,  productCode,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductProperty> UpdatePropertyAsync(Mozu.Api.Contracts.ProductAdmin.ProductProperty productProperty, string productCode, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.UpdatePropertyClient(_dataViewMode,  productProperty,  productCode,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the configuration of a property attribute for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   productproperty.DeleteProperty(_dataViewMode,  productCode,  attributeFQN);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteProperty(string productCode, string attributeFQN)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.DeletePropertyClient(_dataViewMode,  productCode,  attributeFQN);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeletePropertyAsync(string productCode, string attributeFQN)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.DeletePropertyClient(_dataViewMode,  productCode,  attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="productCode"></param>
		/// <param name="value"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   productproperty.DeletePropertyValueLocalizedContent(_dataViewMode,  productCode,  attributeFQN,  value,  localeCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeletePropertyValueLocalizedContent(string productCode, string attributeFQN, string value, string localeCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.DeletePropertyValueLocalizedContentClient(_dataViewMode,  productCode,  attributeFQN,  value,  localeCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeletePropertyValueLocalizedContentAsync(string productCode, string attributeFQN, string value, string localeCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.DeletePropertyValueLocalizedContentClient(_dataViewMode,  productCode,  attributeFQN,  value,  localeCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


