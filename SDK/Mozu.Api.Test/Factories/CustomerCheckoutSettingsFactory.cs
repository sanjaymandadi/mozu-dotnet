//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Settings for the checkout login. Choose whether or not shoppers must first login before a purchase can be processed. Choose the option for guests to purchase without logging in, prompt guests to login, or require them to login before a purchase can be completed.
	/// </summary>
	public partial class CustomerCheckoutSettingsFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves all checkout settings defined for the site: Payment settings, such as the payment gateway ID and credentials, supported credit cards, and more; Customer Checkout settings, such as whether login is required, and any custom attributes; and Order Processing settings, such as when payment is authorized and captured, and any custom attributes.
		/// <example> 
		///  <code> 
		/// var result = CustomerCheckoutSettingsFactory.GetCustomerCheckoutSettings(handler : handler,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CustomerCheckoutSettings/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings GetCustomerCheckoutSettings(ServiceClientMessageHandler handler, 
 		 string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Settings.Checkout.CustomerCheckoutSettingsClient.GetCustomerCheckoutSettingsClient(
				 responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Modifies existing site checkout settings. Modify Payment, Customer Checkout, and Order Processing settings in one PUT.
		/// <example> 
		///  <code> 
		/// var result = CustomerCheckoutSettingsFactory.UpdateCustomerCheckoutSettings(handler : handler,  customerCheckoutSettings :  customerCheckoutSettings,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CustomerCheckoutSettings/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings UpdateCustomerCheckoutSettings(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings customerCheckoutSettings, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Settings.Checkout.CustomerCheckoutSettingsClient.UpdateCustomerCheckoutSettingsClient(
				 customerCheckoutSettings :  customerCheckoutSettings,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


