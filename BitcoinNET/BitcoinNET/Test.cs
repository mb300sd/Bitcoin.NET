using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using Newtonsoft.Json;

namespace BitcoinNET
{
	class Test
	{
		static void Main(string[] args)
		{
			BitcoinRPC b = new BitcoinRPC(new Uri("http://10.0.0.262:8332"), new NetworkCredential("rpcuser1", "rpcpass1"));

			var r = b.ListReceivedByAddress();

			Console.WriteLine(r);


			Console.ReadLine();
		}
	}
}
