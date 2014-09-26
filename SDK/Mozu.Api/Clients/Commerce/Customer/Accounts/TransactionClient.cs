
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

namespace Mozu.Api.Clients.Commerce.Customer.Accounts
{
	/// <summary>
	/// Use the Customer Account Transactions resource to manage the transactions associated with a customer account.
	/// </summary>
	public partial class TransactionClient 	{
		
		/// <summary>
		/// Retrieves a list of transactions associated with the customer account specified in the request.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account for which to retrieve transactions.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Customer.Transaction"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTransactions( accountId);
		///   var transactionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Customer.Transaction>> GetTransactionsClient(int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.TransactionUrl.GetTransactionsUrl(accountId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Customer.Transaction>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new transaction for the customer account specified in the request.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="transaction">Properties of the transaction to create for the customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Transaction"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddTransaction( transaction,  accountId,  responseFields);
		///   var transactionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Transaction> AddTransactionClient(Mozu.Api.Contracts.Customer.Transaction transaction, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.TransactionUrl.AddTransactionUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Transaction>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.Transaction>(transaction);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a transaction from the customer account specified in the request.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account from which to delete the transaction.</param>
		/// <param name="transactionId">Unique identifier of the transaction to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveTransaction( accountId,  transactionId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient RemoveTransactionClient(int accountId, string transactionId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.TransactionUrl.RemoveTransactionUrl(accountId, transactionId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


