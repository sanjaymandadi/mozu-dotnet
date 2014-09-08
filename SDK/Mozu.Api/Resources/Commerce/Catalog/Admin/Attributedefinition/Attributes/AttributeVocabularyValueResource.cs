
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	/// <summary>
	/// Vocabulary values are predefined for an attribute.
	/// </summary>
	public partial class AttributeVocabularyValueResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AttributeVocabularyValueResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AttributeVocabularyValueResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AttributeVocabularyValueResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of attribute vocabulary values. To target a query, use one or several valid optional response groups.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = attributevocabularyvalue.GetAttributeVocabularyValues( attributeFQN);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> GetAttributeVocabularyValues(string attributeFQN)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValuesClient( attributeFQN);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> GetAttributeVocabularyValuesAsync(string attributeFQN)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValuesClient( attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = attributevocabularyvalue.GetAttributeVocabularyValueLocalizedContents( attributeFQN,  value);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> GetAttributeVocabularyValueLocalizedContents(string attributeFQN, string value)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueLocalizedContentsClient( attributeFQN,  value);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> GetAttributeVocabularyValueLocalizedContentsAsync(string attributeFQN, string value)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueLocalizedContentsClient( attributeFQN,  value);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = attributevocabularyvalue.GetAttributeVocabularyValueLocalizedContent( attributeFQN,  value,  localeCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent GetAttributeVocabularyValueLocalizedContent(string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueLocalizedContentClient( attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> GetAttributeVocabularyValueLocalizedContentAsync(string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueLocalizedContentClient( attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves an attribute vocabulary value by providing the attribute FQN and value.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields"></param>
		/// <param name="value">The actual unique value of the attribute vocabulary to retrieve. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = attributevocabularyvalue.GetAttributeVocabularyValue( attributeFQN,  value,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue GetAttributeVocabularyValue(string attributeFQN, string value, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueClient( attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> GetAttributeVocabularyValueAsync(string attributeFQN, string value, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.GetAttributeVocabularyValueClient( attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = attributevocabularyvalue.AddAttributeVocabularyValueLocalizedContent( localizedContent,  attributeFQN,  value,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent AddAttributeVocabularyValueLocalizedContent(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent localizedContent, string attributeFQN, string value, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.AddAttributeVocabularyValueLocalizedContentClient( localizedContent,  attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> AddAttributeVocabularyValueLocalizedContentAsync(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent localizedContent, string attributeFQN, string value, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.AddAttributeVocabularyValueLocalizedContentClient( localizedContent,  attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds a new attribute vocabulary value.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeVocabularyValue">The predefined vocabulary value to add to the attribute content.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = attributevocabularyvalue.AddAttributeVocabularyValue( attributeVocabularyValue,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue AddAttributeVocabularyValue(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.AddAttributeVocabularyValueClient( attributeVocabularyValue,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> AddAttributeVocabularyValueAsync(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.AddAttributeVocabularyValueClient( attributeVocabularyValue,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update existing vocabulary values for an attribute.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="vocabularyValues">The actual vocabulary values for the attribute being updated.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = attributevocabularyvalue.UpdateAttributeVocabularyValues( vocabularyValues,  attributeFQN);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> UpdateAttributeVocabularyValues(List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> vocabularyValues, string attributeFQN)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValuesClient( vocabularyValues,  attributeFQN);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> UpdateAttributeVocabularyValuesAsync(List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> vocabularyValues, string attributeFQN)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValuesClient( vocabularyValues,  attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = attributevocabularyvalue.UpdateAttributeVocabularyValueLocalizedContents( localizedContent,  attributeFQN,  value);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> UpdateAttributeVocabularyValueLocalizedContents(List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> localizedContent, string attributeFQN, string value)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueLocalizedContentsClient( localizedContent,  attributeFQN,  value);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> UpdateAttributeVocabularyValueLocalizedContentsAsync(List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> localizedContent, string attributeFQN, string value)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueLocalizedContentsClient( localizedContent,  attributeFQN,  value);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValueLocalizedContent = attributevocabularyvalue.UpdateAttributeVocabularyValueLocalizedContent( localizedContent,  attributeFQN,  value,  localeCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent UpdateAttributeVocabularyValueLocalizedContent(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent localizedContent, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueLocalizedContentClient( localizedContent,  attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> UpdateAttributeVocabularyValueLocalizedContentAsync(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent localizedContent, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueLocalizedContentClient( localizedContent,  attributeFQN,  value,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates existing attribute vocabulary values.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields"></param>
		/// <param name="value">The actual unique value of the attribute vocabulary value to update. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeVocabularyValue">The predefined vocabulary value to add to the attribute content to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   var attributeVocabularyValue = attributevocabularyvalue.UpdateAttributeVocabularyValue( attributeVocabularyValue,  attributeFQN,  value,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue UpdateAttributeVocabularyValue(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string value, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueClient( attributeVocabularyValue,  attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> UpdateAttributeVocabularyValueAsync(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string value, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.UpdateAttributeVocabularyValueClient( attributeVocabularyValue,  attributeFQN,  value,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes an attribute's vocabulary value.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="value">The actual unique value of the attribute vocabulary to delete. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   attributevocabularyvalue.DeleteAttributeVocabularyValue( attributeFQN,  value);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteAttributeVocabularyValue(string attributeFQN, string value)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.DeleteAttributeVocabularyValueClient( attributeFQN,  value);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteAttributeVocabularyValueAsync(string attributeFQN, string value)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.DeleteAttributeVocabularyValueClient( attributeFQN,  value);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var attributevocabularyvalue = new AttributeVocabularyValue();
		///   attributevocabularyvalue.DeleteAttributeVocabularyValueLocalizedContent( attributeFQN,  value,  localeCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteAttributeVocabularyValueLocalizedContent(string attributeFQN, string value, string localeCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.DeleteAttributeVocabularyValueLocalizedContentClient( attributeFQN,  value,  localeCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteAttributeVocabularyValueLocalizedContentAsync(string attributeFQN, string value, string localeCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueClient.DeleteAttributeVocabularyValueLocalizedContentClient( attributeFQN,  value,  localeCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

