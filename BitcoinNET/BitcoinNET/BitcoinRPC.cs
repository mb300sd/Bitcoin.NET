using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace BitcoinNET
{
	public class BitcoinRPC
	{
		private Uri uri;

		private NetworkCredential credentials;

		public BitcoinRPC(Uri _Uri, NetworkCredential _Credentials)
		{
			uri = _Uri;
			credentials = _Credentials;
		}

		public T RpcCall<T>(RPCRequest rpcRequest)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

			request.Method = "POST";
			request.ContentType = "application/json-rpc";

			// always send auth to avoid 401 response
			string auth = credentials.UserName + ":" + credentials.Password;
			auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(auth), Base64FormattingOptions.None);
			request.Headers.Add("Authorization", "Basic " + auth);

			//webRequest.Credentials = Credentials;

			string jsonRequest = JsonConvert.SerializeObject(rpcRequest);

			request.ContentLength = jsonRequest.Length;
			using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
			{
				sw.Write(jsonRequest);
			}

			try
			{
				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				using (StreamReader sr = new StreamReader(response.GetResponseStream()))
				{
					RPCResponse<T> rpcResponse = JsonConvert.DeserializeObject<RPCResponse<T>>(sr.ReadToEnd());
					return rpcResponse.result;
				}
			}
			catch (WebException wex)
			{
				using (HttpWebResponse response = (HttpWebResponse)wex.Response)
				using (StreamReader sr = new StreamReader(response.GetResponseStream()))
				{
					if (response.StatusCode != HttpStatusCode.InternalServerError)
					{
						throw;
					}
					RPCResponse<Object> rpcResponse = JsonConvert.DeserializeObject<RPCResponse<Object>>(sr.ReadToEnd());
					throw new BitcoinRPCException(rpcResponse.error, wex);
				}
			}
		}

		public string AddMultiSigAddress(int NRequired, IEnumerable<string> keys, string Account = "")
		{
			return RpcCall<string>
				(new RPCRequest("addmultisigaddress", new Object[] { NRequired, keys, Account }));
		}

		public void BackupWallet(string Destination)
		{
			RpcCall<object>
				(new RPCRequest("backupwallet", new Object[] { Destination }));
		}

		public string DumpPrivKey(string BitcoinAddress)
		{
			return RpcCall<string>
				(new RPCRequest("dumpprivkey", new Object[] { BitcoinAddress }));
		}

		public void EncryptWallet(string Passphrase)
		{
			RpcCall<Object>
				(new RPCRequest("encryptwallet", new Object[] { Passphrase }));
		}

		public string GetAccount(string BitcoinAddress)
		{
			return RpcCall<string>
				(new RPCRequest("getaccount", new Object[] { BitcoinAddress }));
		}

		public string GetAccountAddress(string Account)
		{
			return RpcCall<string>
				(new RPCRequest("getaccountaddress", new Object[] { Account }));
		}

		public IEnumerable<string> GetAddressesByAccount(string Account)
		{
			return RpcCall<IEnumerable<string>>
				(new RPCRequest("getaddressesbyaccount", new Object[] { Account }));
		}

		public decimal GetBalance(string Account = "*", int MinConf = 1)
		{
			return RpcCall<decimal>
				(new RPCRequest("getbalance", new Object[] { Account, MinConf }));
		}

		public GetBlockResponse GetBlock(string Hash)
		{
			return RpcCall<GetBlockResponse>
				(new RPCRequest("getblock", new Object[] { Hash }));
		}

		public int GetBlockCount()
		{
			return RpcCall<int>
				(new RPCRequest("getblockcount"));
		}

		public string GetBlockHash(long Index)
		{
			return RpcCall<string>
				(new RPCRequest("getblockhash", new Object[] { Index }));
		}

		public int GetConnectionCount()
		{
			return RpcCall<int>
				(new RPCRequest("getconnectioncount"));
		}

		public decimal GetDifficulty()
		{
			return RpcCall<decimal>
				(new RPCRequest("getdifficulty"));
		}

		public bool GetGenerate()
		{
			return RpcCall<bool>
				(new RPCRequest("getgenerate"));
		}

		public decimal GetHashesPerSec()
		{
			return RpcCall<decimal>
				(new RPCRequest("gethashespersec"));
		}

		public GetInfoResponse GetInfo()
		{
			return RpcCall<GetInfoResponse>
				(new RPCRequest("getinfo"));
		}

		public GetMemoryPoolResponse GetMemoryPool()
		{
			return RpcCall<GetMemoryPoolResponse>
				(new RPCRequest("getmemorypool"));
		}

		public bool GetMemoryPool(string Data)
		{
			return RpcCall<bool>
				(new RPCRequest("getmemorypool", new Object[] { Data }));
		}

		public GetMiningInfoResponse GetMiningInfo()
		{
			return RpcCall<GetMiningInfoResponse>
				(new RPCRequest("getinfo"));
		}

		public string GetNewAddress(string Account = "")
		{
			return RpcCall<string>
				(new RPCRequest("getnewaddress", new Object[] { Account }));
		}

		public decimal GetReceivedByAccount(string Account, int MinConf = 1)
		{
			return RpcCall<decimal>
				(new RPCRequest("getreceivedbyaccount", new Object[] { Account, MinConf }));
		}

		public decimal GetReceivedByAddress(string BitcoinAddress, int MinConf = 1)
		{
			return RpcCall<decimal>
				(new RPCRequest("getreceivedbyaddress", new Object[] { BitcoinAddress, MinConf }));
		}

		public GetTransactionResponse GetTransaction(string TxID)
		{
			return RpcCall<GetTransactionResponse>
				(new RPCRequest("gettransaction", new Object[] { TxID }));
		}

		public GetWorkResponse GetWork()
		{
			return RpcCall<GetWorkResponse>
				(new RPCRequest("getwork"));
		}

		public bool GetWork(string Data)
		{
			return RpcCall<bool>
				(new RPCRequest("getwork", new Object[] { Data }));
		}

		public string Help(string Command = "")
		{
			return RpcCall<string>
				(new RPCRequest("help", new Object[] { Command }));
		}

		public void ImportPrivKey(string BitcoinPrivKey, string Label = "")
		{
			RpcCall<Object>
				(new RPCRequest("importprivkey", new Object[] { BitcoinPrivKey, Label }));
		}

		public void KeyPoolRefill()
		{
			RpcCall<object>
				(new RPCRequest("keypoolrefill"));
		}

		public IDictionary<string, decimal> ListAccounts(int MinConf = 1)
		{
			return RpcCall<IDictionary<string, decimal>>
				(new RPCRequest("listaccounts", new Object[] { MinConf }));
		}

		public Object ListAddressGroupings(bool showEmptyGroups = true, bool showEmptyAddresses = true)
		{
			return RpcCall<IEnumerable<IEnumerable<ListAddressGroupingsResponse>>>
				(new RPCRequest("listaddressgroupings", new Object[] { showEmptyGroups, showEmptyAddresses} ));
		}

		public IEnumerable<ListReceivedByAccountResponse> ListReceivedByAccount(int MinConf = 1, bool IncludeEmpty = false)
		{
			return RpcCall<IEnumerable<ListReceivedByAccountResponse>>
				(new RPCRequest("listreceivedbyaccount", new Object[] { MinConf, IncludeEmpty }));
		}


		public IEnumerable<ListReceivedByAddressResponse> ListReceivedByAddress(int MinConf = 1, bool IncludeEmpty = false)
		{
			return RpcCall<IEnumerable<ListReceivedByAddressResponse>>
				(new RPCRequest("listreceivedbyaddress", new Object[] { MinConf, IncludeEmpty }));
		}

		public ListSinceBlockResponse ListSinceBlock(string BlockHash = null, int TargetConfirmations = 1)
		{
			if (BlockHash == null)
			{
				return RpcCall<ListSinceBlockResponse>
					(new RPCRequest("listsinceblock"));
			}
			return RpcCall<ListSinceBlockResponse>
				(new RPCRequest("listsinceblock", new Object[] { BlockHash, TargetConfirmations }));
		}

		public IEnumerable<ListTransactionsResponse> ListTransactions(string Account = "*", int Count = 10, int From = 0)
		{
			return RpcCall<IEnumerable<ListTransactionsResponse>>
				(new RPCRequest("listtransactions", new Object[] { Account, Count, From }));	
		}

		public bool Move(string FromAccount, string ToAccount, decimal Amount, int MinConf = 1, string Comment = "")
		{
			return RpcCall<bool>
				(new RPCRequest("move", new Object[] { FromAccount, ToAccount, Amount, MinConf, Comment }));
		}

		public string SendFrom(string FromAccount, string ToBitcoinAddress, decimal Amount, int MinConf = 1, string Comment = "", string CommentTo = "")
		{
			return RpcCall<string>
				(new RPCRequest("sendfrom", new Object[] { FromAccount, ToBitcoinAddress, Amount, MinConf, Comment, CommentTo }));
		}

		public string SendMany(string FromAccount, IDictionary<string, decimal> ToBitcoinAddresses, int MinConf = 1, string Comment = "")
		{
			return RpcCall<string>
				(new RPCRequest("sendmany", new Object[] { FromAccount, ToBitcoinAddresses, MinConf, Comment }));
		}

		public string SendMany(string FromAccount, IEnumerable<string> FromAddresses, IDictionary<string, decimal> ToBitcoinAddresses, int MinConf = 1, string Comment = "")
		{
			IEnumerable<string> AccountAddresses = (new string[] { FromAccount }).Concat(FromAddresses);
			return RpcCall<string>
				(new RPCRequest("sendmany", new Object[] { AccountAddresses, ToBitcoinAddresses, MinConf, Comment }));
		}

		public string SendToAddress(string BitcoinAddress, decimal Amount, string Comment = "", string CommentTo = "")
		{
			return RpcCall<string>
				(new RPCRequest("sendtoaddress", new Object[] { BitcoinAddress, Amount, Comment, CommentTo }));
		}

		public void SetAccount(string BitcoinAddress, string Account)
		{
			RpcCall<Object>
				(new RPCRequest("setaccount", new Object[] { BitcoinAddress, Account }));
		}

		public void SetGenerate(bool Generate, int GenProcLimit = 1)
		{
			RpcCall<Object>
				(new RPCRequest("setgenerate", new Object[] { Generate, GenProcLimit }));
		}

		public bool SetTxFee(decimal Amount)
		{
			return RpcCall<bool>
				(new RPCRequest("settxfee", new Object[] { Amount }));
		}

		public string SignMessage(string BitcoinAddress, string Message)
		{
			return RpcCall<string>
				(new RPCRequest("signmessage", new Object[] { BitcoinAddress, Message }));
		}

		public void Stop()
		{
			RpcCall<Object>
				(new RPCRequest("stop"));
		}

		public ValidateAddressResponse ValidateAddress(string Address)
		{
			return RpcCall<ValidateAddressResponse>
				(new RPCRequest("validateaddress", new Object[] { Address }));
		}

		public void WalletLock()
		{
			RpcCall<Object>
				(new RPCRequest("walletlock"));
		}

		public void WalletPassphrase(string Passphrase, int Timeout)
		{
			RpcCall<Object>
				(new RPCRequest("walletpassphrase", new Object[] { Passphrase, Timeout }));
		}

		public void WalletPassphraseChange(string OldPassphrase, string NewPassphrase)
		{
			RpcCall<Object>
				(new RPCRequest("walletpassphrasechange", new Object[] { OldPassphrase, NewPassphrase }));
		}

		public bool VerifyMessage(string BitcoinAddress, string Signature, string Message)
		{
			return RpcCall<bool>
				(new RPCRequest("verifymessage", new Object[] { BitcoinAddress, Signature, Message }));
		}
	}
}
