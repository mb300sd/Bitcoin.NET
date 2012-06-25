using System;
using System.Collections.Generic;

namespace BitcoinNET.RPCClient
{
	public class ListSinceBlockResponse
	{
		public class Transaction
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
		}

		public IEnumerable<Transaction> transactions;
		public string lastblock;
	}
}
