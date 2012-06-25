using System;

namespace BitcoinNET.RPCClient
{
	public class ListReceivedByAccountResponse
	{
		public string account;
		public decimal amount;
		public long confirmations;
	}
}
