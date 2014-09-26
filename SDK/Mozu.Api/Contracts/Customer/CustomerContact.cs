
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
		///	Contact information, including the contact's name, address, phone numbers, email addresses, and company (if supplied). Also indicates whether this is a billing, shipping, or billing and shipping contact.
		///
		public class CustomerContact
		{
			///
			///Unique identifier of the customer account.
			///
			public int AccountId { get; set; }

			///
			///The legal or doing business as (DBA) or tradestyle name of the business or organization. The maximum character length is 200.
			///
			public string CompanyOrOrganization { get; set; }

			///
			///The email address of the specified user or the email address associated with the specified entity.
			///
			public string Email { get; set; }

			///
			///The fax number associated with the customer account.
			///
			public string FaxNumber { get; set; }

			///
			///The first name of the contact. The maximum character length is 200.
			///
			public string FirstName { get; set; }

			///
			///Identifier of the customer contact.
			///
			public int Id { get; set; }

			public string Label { get; set; }

			///
			///The last name or surname of the contact. The maximum character length is 200.
			///
			public string LastNameOrSurname { get; set; }

			///
			///The middle name or the first initial of the middle name of the contact. The maximum character length is 100.
			///
			public string MiddleNameOrInitial { get; set; }

			///
			///List of the types associated with a customer contact, such as Billing or Fulfillment.
			///
			public List<ContactType> Types { get; set; }

			///
			///Address associated with the customer account contact.
			///
			public Address Address { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///List of phone numbers associated with the customer account contact.
			///
			public Phone PhoneNumbers { get; set; }

		}

}