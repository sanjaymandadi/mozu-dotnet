
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Settings.Checkout
{
	public partial class PaymentSettingsUrl 
	{

		/// <summary>
        /// Get Resource Url for GetThirdPartyPaymentWorkflowWithValues
        /// </summary>
        /// <param name="fullyQualifiedName">Fully qualified name of the attribute for the third-party payment workflow.</param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetThirdPartyPaymentWorkflowWithValuesUrl(string fullyQualifiedName, string responseFields =  null)
		{
			var url = "/api/commerce/settings/checkout/paymentsettings/thirdpartyworkflow/{fullyQualifiedName}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "fullyQualifiedName", fullyQualifiedName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetThirdPartyPaymentWorkflows
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetThirdPartyPaymentWorkflowsUrl()
		{
			var url = "/api/commerce/settings/checkout/paymentsettings/thirdpartyworkflows";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for AddThirdPartyPaymentWorkflow
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddThirdPartyPaymentWorkflowUrl()
		{
			var url = "/api/commerce/settings/checkout/paymentsettings/thirdpartyworkflows";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteThirdPartyPaymentWorkflow
        /// </summary>
        /// <param name="fullyQualifiedName">Fully qualified name of the attribute for the third-party payment workflow.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteThirdPartyPaymentWorkflowUrl(string fullyQualifiedName)
		{
			var url = "/api/commerce/settings/checkout/paymentsettings/thirdpartyworkflows/{fullyQualifiedName}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "fullyQualifiedName", fullyQualifiedName);
			return mozuUrl;
		}

		
	}
}

