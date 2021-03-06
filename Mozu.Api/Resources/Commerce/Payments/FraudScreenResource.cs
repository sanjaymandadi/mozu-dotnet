
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

namespace Mozu.Api.Resources.Commerce.Payments
{
	/// <summary>
	/// commerce/payments/fraudscreen related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class FraudScreenResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public FraudScreenResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public FraudScreenResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new FraudScreenResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// payments-fraudscreen Post Screen description DOCUMENT_HERE 
		/// </summary>
		/// <param name="request">Mozu.PaymentService.Contracts.Request.FraudScreenRequest ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PaymentService.Response.FraudScreen"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fraudscreen = new FraudScreen();
		///   var fraudScreen = fraudscreen.Screen( request);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.PaymentService.Response.FraudScreen Screen(Mozu.Api.Contracts.PaymentService.Request.FraudScreenRequest request)
		{
			MozuClient<Mozu.Api.Contracts.PaymentService.Response.FraudScreen> response;
			var client = Mozu.Api.Clients.Commerce.Payments.FraudScreenClient.ScreenClient( request);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// payments-fraudscreen Post Screen description DOCUMENT_HERE 
		/// </summary>
		/// <param name="request">Mozu.PaymentService.Contracts.Request.FraudScreenRequest ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PaymentService.Response.FraudScreen"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fraudscreen = new FraudScreen();
		///   var fraudScreen = await fraudscreen.ScreenAsync( request);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.PaymentService.Response.FraudScreen> ScreenAsync(Mozu.Api.Contracts.PaymentService.Request.FraudScreenRequest request)
		{
			MozuClient<Mozu.Api.Contracts.PaymentService.Response.FraudScreen> response;
			var client = Mozu.Api.Clients.Commerce.Payments.FraudScreenClient.ScreenClient( request);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


