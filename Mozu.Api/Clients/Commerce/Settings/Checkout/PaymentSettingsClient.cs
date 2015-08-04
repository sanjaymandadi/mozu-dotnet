
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

namespace Mozu.Api.Clients.Commerce.Settings.Checkout
{
	/// <summary>
	/// Use the Payment Settings resource to specify settings when creating payments for order checkout on the site.
	/// </summary>
	public partial class PaymentSettingsClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fullyQualifiedName"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetThirdPartyPaymentWorkflowWithValues( fullyQualifiedName,  responseFields);
		///   var externalPaymentWorkflowDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition> GetThirdPartyPaymentWorkflowWithValuesClient(string fullyQualifiedName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetThirdPartyPaymentWorkflowWithValuesUrl(fullyQualifiedName, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the third-party payment service workflows configured for the site.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetThirdPartyPaymentWorkflows();
		///   var externalPaymentWorkflowDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> GetThirdPartyPaymentWorkflowsClient()
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetThirdPartyPaymentWorkflowsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="definition"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddThirdPartyPaymentWorkflow( definition);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient AddThirdPartyPaymentWorkflowClient(Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition definition)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.AddThirdPartyPaymentWorkflowUrl();
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>(definition);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fullyQualifiedName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteThirdPartyPaymentWorkflow( fullyQualifiedName);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteThirdPartyPaymentWorkflowClient(string fullyQualifiedName)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.DeleteThirdPartyPaymentWorkflowUrl(fullyQualifiedName);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


