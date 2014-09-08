
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Order Notes subresource to manage merchant-level notes associated with an active order.
	/// </summary>
	public partial class OrderNoteResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderNoteResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderNoteResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderNoteResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of all notes for an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = ordernote.GetOrderNotes( orderId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> GetOrderNotes(string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNotesClient( orderId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> GetOrderNotesAsync(string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNotesClient( orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a specific order note.
		/// </summary>
		/// <param name="noteId">Unique identifier of the order note to retrieve.</param>
		/// <param name="orderId">Unique identifier of the order associated with the note.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = ordernote.GetOrderNote( orderId,  noteId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote GetOrderNote(string orderId, string noteId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNoteClient( orderId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> GetOrderNoteAsync(string orderId, string noteId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNoteClient( orderId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new merchant note for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to add a note.</param>
		/// <param name="responseFields"></param>
		/// <param name="orderNote">The alphanumeric text contained in the note. The maximum length is 256 characters.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = ordernote.CreateOrderNote( orderNote,  orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote CreateOrderNote(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.CreateOrderNoteClient( orderNote,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> CreateOrderNoteAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.CreateOrderNoteClient( orderNote,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates a specific note for an order.
		/// </summary>
		/// <param name="noteId">Unique identifier of the order note.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <param name="orderNote">The content of the order note. The maximum length is 256 characters.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = ordernote.UpdateOrderNote( orderNote,  orderId,  noteId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote UpdateOrderNote(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, string orderId, string noteId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.UpdateOrderNoteClient( orderNote,  orderId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> UpdateOrderNoteAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, string orderId, string noteId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.UpdateOrderNoteClient( orderNote,  orderId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the specified order note.
		/// </summary>
		/// <param name="noteId">Unique identifier of the order note to delete.</param>
		/// <param name="orderId">Unique identifier of the order associated with the note.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   ordernote.DeleteOrderNote( orderId,  noteId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteOrderNote(string orderId, string noteId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.DeleteOrderNoteClient( orderId,  noteId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteOrderNoteAsync(string orderId, string noteId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.DeleteOrderNoteClient( orderId,  noteId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

