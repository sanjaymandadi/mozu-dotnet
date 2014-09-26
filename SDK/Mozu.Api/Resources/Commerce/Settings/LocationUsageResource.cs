
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

namespace Mozu.Api.Resources.Commerce.Settings
{
	/// <summary>
	/// Use the Location Usages resource to define the locations and location types that interact with the specified site. The system creates three default location usage types for each site after provisioning a new tenant - one for direct ship (DS), one for in-store pickup (SP), and one for store finder (storeFinder). Each site can only use a single location for the direct ship location usage type, and the location must support the direct ship fulfillment type (DS). For the in-store pickup location usage type, each site can use one or more location types. The location service identifies all locations of the specified type that support the in-store pickup fulfillment type (SP). For the store finder location usage type, each site can use one or more location types. The location service identifies all locations of the type. Locations configured for the store finder type do not typically maintain inventory. You cannot create additional location usage types at this time.
	/// </summary>
	public partial class LocationUsageResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public LocationUsageResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public LocationUsageResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new LocationUsageResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the configured site location usages for the location usage code specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationUsageCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationusage = new LocationUsage();
		///   var locationUsageCollection = locationusage.GetLocationUsages( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationUsageCollection GetLocationUsages(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationUsageCollection> response;
			var client = Mozu.Api.Clients.Commerce.Settings.LocationUsageClient.GetLocationUsagesClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.LocationUsageCollection> GetLocationUsagesAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationUsageCollection> response;
			var client = Mozu.Api.Clients.Commerce.Settings.LocationUsageClient.GetLocationUsagesClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the location usages for the site specified in the request header.
		/// </summary>
		/// <param name="code">Code that identifies the location usage type, which is "DS" for direct ship, "SP" for in-store pickup, or "storeFinder" for store finder.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationUsage"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationusage = new LocationUsage();
		///   var locationUsage = locationusage.GetLocationUsage( code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationUsage GetLocationUsage(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationUsage> response;
			var client = Mozu.Api.Clients.Commerce.Settings.LocationUsageClient.GetLocationUsageClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.LocationUsage> GetLocationUsageAsync(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationUsage> response;
			var client = Mozu.Api.Clients.Commerce.Settings.LocationUsageClient.GetLocationUsageClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the location usage for the site based on the location usage code specified in the request.
		/// </summary>
		/// <param name="code">Code that identifies the location usage type, which is "DS" for direct ship, "SP" for in-store pickup, or "storeFinder" for store finder.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="usage">Properties of the location usage type to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationUsage"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationusage = new LocationUsage();
		///   var locationUsage = locationusage.UpdateLocationUsage( usage,  code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationUsage UpdateLocationUsage(Mozu.Api.Contracts.Location.LocationUsage usage, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationUsage> response;
			var client = Mozu.Api.Clients.Commerce.Settings.LocationUsageClient.UpdateLocationUsageClient( usage,  code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.LocationUsage> UpdateLocationUsageAsync(Mozu.Api.Contracts.Location.LocationUsage usage, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationUsage> response;
			var client = Mozu.Api.Clients.Commerce.Settings.LocationUsageClient.UpdateLocationUsageClient( usage,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


