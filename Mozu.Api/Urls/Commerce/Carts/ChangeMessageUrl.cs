
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

namespace Mozu.Api.Urls.Commerce.Carts
{
	public partial class ChangeMessageUrl 
	{

		/// <summary>
        /// Get Resource Url for GetMessages
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetMessagesUrl(string responseFields =  null)
		{
			var url = "/api/commerce/carts/current/messages?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

								/// <summary>
        /// Get Resource Url for RemoveAllMessages
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveAllMessagesUrl()
		{
			var url = "/api/commerce/carts/current/messages";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for RemoveMessage
        /// </summary>
        /// <param name="messageId">Identifier of the message to remove from the cart.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveMessageUrl(string messageId)
		{
			var url = "/api/commerce/carts/current/messages/{messageId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "messageId", messageId);
			return mozuUrl;
		}

		
	}
}
