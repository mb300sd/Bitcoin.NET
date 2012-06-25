using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET.RPCClient
{
	public class GetAddedNodeInfoResponse
	{
		public class Addresses
		{
			public string address;
			public bool connected;
		}

		public string addednode;
		public bool connected;
		public Addresses[] addresses;
	}
}
