
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Customer
{
		///
		///	Properties of the customer account.
		///
		public class CustomerAccount
		{
			///
			///Indicates if the customer account is opted to receive marketing materials. If true, the customer account is opted in for receiving the content. 
			///
			public bool AcceptsMarketing { get; set; }

			///
			///Collection of attributes that may be paged list or a list, depending on the usage per object and API type. 
			///
			public List<CustomerAttribute> Attributes { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Properties of the commerce summary associated with a customer account, which includes details about the shopper's most recent order, wish lists, and total order value over time.
			///
			public CommerceSummary CommerceSummary { get; set; }

			///
			///The legal or doing business as (DBA) or tradestyle name of the business or organization. The maximum character length is 200.
			///
			public string CompanyOrOrganization { get; set; }

			///
			///Contact information, including the contact's name, address, phone numbers, email addresses, and company (if supplied). Also indicates whether this is a billing, shipping, or billing and shipping contact.
			///
			public List<CustomerContact> Contacts { get; set; }

			///
			///The email address for the customer account and contact. This email may be used for login to the storefront and for subscription mailing lists.
			///
			public string EmailAddress { get; set; }

			///
			///Unique identifier used by an external program to identify a Mozu order, customer account, or wish list.
			///
			public string ExternalId { get; set; }

			///
			///The full first name of a customer or contact name.
			///
			public string FirstName { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public int Id { get; set; }

			///
			///Indicates if the object or feature is active. This indicator is used for subscriptions (at the site or tenant level), customer accounts, products and variations.
			///
			public bool IsActive { get; set; }

			///
			///If true, this customer account represents an anonymous shopper.
			///
			public bool IsAnonymous { get; set; }

			///
			///Indicates if a customer account and associated data is locked. If true, the user account is locked due to multiple failed authentication attempts. The user cannot login until the account is unlocked.
			///
			public bool IsLocked { get; set; }

			///
			///The full last name of a customer or contact name.
			///
			public string LastName { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///Paged list collection of note content for objects including customers, orders, and returns. 
			///
			public List<CustomerNote> Notes { get; set; }

			///
			///List of customer segments associated with the customer account. Customer accounts can be members of any number of segments.
			///
			public List<CustomerSegment> Segments { get; set; }

			///
			///If true, this customer account has tax exempt status.
			///
			public bool TaxExempt { get; set; }

			///
			///The tax identification number associated with the customer account.
			///
			public string TaxId { get; set; }

			///
			///Unique identifier of the customer account (shopper or system user). System-supplied and read-only. If the shopper user is anonymous, the user ID represents a system-generated user ID string.
			///
			public string UserId { get; set; }

			///
			///The user name associated with the user profile. The customer uses the user name to access the account.
			///
			public string UserName { get; set; }

		}

}