
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

namespace Mozu.Api.Resources.Commerce.Admin
{
	/// <summary>
	/// Use the Location Types resource to manage the types of locations your tenant maintains, such as warehouses, physical storefronts, and kiosks.
	/// </summary>
	public partial class LocationTypeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public LocationTypeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public LocationTypeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new LocationTypeResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieve a list of all location types defined for the tenant.
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Location.LocationType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   var locationType = locationtype.GetLocationTypes();
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.Location.LocationType> GetLocationTypes()
		{
			MozuClient<List<Mozu.Api.Contracts.Location.LocationType>> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.GetLocationTypesClient();
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.Location.LocationType>> GetLocationTypesAsync()
		{
			MozuClient<List<Mozu.Api.Contracts.Location.LocationType>> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.GetLocationTypesClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the location type specified in the request.
		/// </summary>
		/// <param name="locationTypeCode">The user-defined code that identifies the location type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   var locationType = locationtype.GetLocationType( locationTypeCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationType GetLocationType(string locationTypeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.GetLocationTypeClient( locationTypeCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.LocationType> GetLocationTypeAsync(string locationTypeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.GetLocationTypeClient( locationTypeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new location type based on the information specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="locationType">Properties of the location type to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   var locationType = locationtype.AddLocationType( locationType,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationType AddLocationType(Mozu.Api.Contracts.Location.LocationType locationType, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.AddLocationTypeClient( locationType,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.LocationType> AddLocationTypeAsync(Mozu.Api.Contracts.Location.LocationType locationType, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.AddLocationTypeClient( locationType,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the name of a defined location type.
		/// </summary>
		/// <param name="locationTypeCode">The user-defined code that identifies the location type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="locationType">Properties of the location type to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   var locationType = locationtype.UpdateLocationType( locationType,  locationTypeCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationType UpdateLocationType(Mozu.Api.Contracts.Location.LocationType locationType, string locationTypeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.UpdateLocationTypeClient( locationType,  locationTypeCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.LocationType> UpdateLocationTypeAsync(Mozu.Api.Contracts.Location.LocationType locationType, string locationTypeCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.UpdateLocationTypeClient( locationType,  locationTypeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the location type specified in the request.
		/// </summary>
		/// <param name="locationTypeCode">User-defined code used to identify the location type.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   locationtype.DeleteLocationType( locationTypeCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteLocationType(string locationTypeCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.DeleteLocationTypeClient( locationTypeCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteLocationTypeAsync(string locationTypeCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.DeleteLocationTypeClient( locationTypeCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


