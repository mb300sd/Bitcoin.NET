using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET.RPCClient
{
	public class ListReceivedByAccountResponse
	{
		public string account;
		public decimal amount;
		public long confirmations;
	}
}
