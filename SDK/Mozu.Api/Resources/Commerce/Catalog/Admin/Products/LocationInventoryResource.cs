
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
	/// Use the Product Location Inventory resource to manage the levels of active product inventory to maintain across defined locations at the product level.
	/// </summary>
	public partial class LocationInventoryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public LocationInventoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public LocationInventoryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new LocationInventoryResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public LocationInventoryResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves all locations for which a product has inventory defined and displays the inventory definition properties of each location.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventoryCollection = locationinventory.GetLocationInventories( productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection GetLocationInventories(string productCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.GetLocationInventoriesClient( productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> GetLocationInventoriesAsync(string productCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.GetLocationInventoriesClient( productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the inventory of the product in the location specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that identifies the location.</param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.GetLocationInventory( productCode,  locationCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.LocationInventory GetLocationInventory(string productCode, string locationCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.GetLocationInventoryClient( productCode,  locationCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.LocationInventory> GetLocationInventoryAsync(string productCode, string locationCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.GetLocationInventoryClient( productCode,  locationCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new location inventory definition for the product code specified in the request.
		/// </summary>
		/// <param name="performUpserts"></param>
		/// <param name="productCode">ProductCodeBase</param>
		/// <param name="locationInventoryList">Array list of the location inventory definitions associated with the product code specified in the request. For each location, you must define the locationCode value and the stockOnHand value. All other properties in the array are system-supplied and read only.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.AddLocationInventory(_dataViewMode,  locationInventoryList,  productCode,  performUpserts);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> AddLocationInventory(List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string productCode, bool? performUpserts =  null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.AddLocationInventoryClient(_dataViewMode,  locationInventoryList,  productCode,  performUpserts);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> AddLocationInventoryAsync(List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string productCode, bool? performUpserts =  null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.AddLocationInventoryClient(_dataViewMode,  locationInventoryList,  productCode,  performUpserts);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the current level of stock at each location associated with the product code specified in the request.
		/// </summary>
		/// <param name="productCode">The product code of the product for which to update active stock on hand inventory at a specified location.</param>
		/// <param name="locationInventoryAdjustments"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.UpdateLocationInventory(_dataViewMode,  locationInventoryAdjustments,  productCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> UpdateLocationInventory(List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment> locationInventoryAdjustments, string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.UpdateLocationInventoryClient(_dataViewMode,  locationInventoryAdjustments,  productCode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> UpdateLocationInventoryAsync(List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment> locationInventoryAdjustments, string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.UpdateLocationInventoryClient(_dataViewMode,  locationInventoryAdjustments,  productCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the location inventory definition for the product code specified in the request.
		/// </summary>
		/// <param name="locationCode">The code that identifies the location for which to delete product inventory.</param>
		/// <param name="productCode">The product code for which to delete a location's inventory.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   locationinventory.DeleteLocationInventory(_dataViewMode,  productCode,  locationCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteLocationInventory(string productCode, string locationCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.DeleteLocationInventoryClient(_dataViewMode,  productCode,  locationCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteLocationInventoryAsync(string productCode, string locationCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.LocationInventoryClient.DeleteLocationInventoryClient(_dataViewMode,  productCode,  locationCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

