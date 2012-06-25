using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitcoinNET.RPCClient
{
	public partial class BatchRPC : BitcoinRPC
	{
		private uint lastID = 1;
		private uint NewID { get { return ++lastID; } }

		private List<RPCRequest> requests;
		private Dictionary<uint, RPCResponse<JObject>> responses;

		public BatchRPC(Uri _Uri, NetworkCredential _Credentials) : base(_Uri, _Credentials)
		{
			requests = new List<RPCRequest>();
		}

		public void DoRequest()
		{
			string jsonRequest = JsonConvert.SerializeObject(requests);

			string result = HttpCall(jsonRequest);

			IEnumerable<RPCResponse<JObject>> responseList = JsonConvert.DeserializeObject<IEnumerable<RPCResponse<JObject>>>(result);

			responses = responseList.ToDictionary<RPCResponse<JObject>, uint>(x => x.id);

			requests.Clear();
		}

		public T GetResult<T>(uint ID)
		{
			RPCResponse<JObject> r = responses[ID];
			if (r.error != null)
			{
				throw new BitcoinRPCException(r.error);
			}
			return JsonConvert.DeserializeObject<T>(r.result.ToString());
		}
	}
}
