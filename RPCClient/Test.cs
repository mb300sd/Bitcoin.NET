using System;
using System.Net;
using System.Collections.Generic;

namespace BitcoinNET.RPCClient
{
	class Test
	{
		static void Main(string[] args)
		{
<<<<<<< HEAD
			BatchRPC r = new BatchRPC(new Uri("http://10.1.1.224:8332"), new NetworkCredential("rpcuser1", "rpcpass1"));

			uint _tx = r.ListTransactions();
			uint _bal = r.GetBalance();
			uint _blk = r.GetBlockCount();

			r.DoRequest();

			var tx = r.GetResult<IEnumerable<ListTransactionsResponse>>(_tx);
=======
			BitcoinRPC b = new BitcoinRPC(new Uri("http://127.0.0.1:8332"), new NetworkCredential("rpcuser", "rpcpass"));

			var r = b.CreateMultiSig(1, new String[] { "1N71zTS2S17FJTctT6Xwna5YuioQ6iy4aT", "1N71zTS2S17FJTctT6Xwna5YuioQ6iy4aT" });
>>>>>>> 7c77783... implimenting 0.8 commands

			Console.WriteLine(tx);


			Console.ReadLine();
		}
	}
}
