using System;

namespace BitcoinNET.RPCClient
{
	public class ListTransactionsResponse
	{
		public string account;
		public string address;
		public string category;
		public decimal amount;
		public decimal fee;
		public long confirmations;
		public string blockhash;
		public int blockindex;
		public long blocktime;
		public string txid;
		public long time;
		public long timereceived;
		public string otheraccount;
		public string comment;
	}
}
