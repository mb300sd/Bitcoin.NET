using System;
using System.Collections.Generic;
using System.Linq;

namespace BitcoinNET.RPCClient
{
	public partial class BitcoinRPC
	{
		public string AddMultiSigAddress(int NRequired, IEnumerable<string> Keys, string Account = "")
		{
			return RpcCall<string>
				(new RPCRequest("addmultisigaddress", new Object[] { NRequired, Keys, Account }));
		}

		public void AddNode(string Node, string Mode)
		{
			RpcCall<object>
				(new RPCRequest("addnode", new Object[] {Node, Mode}));
		}

		public void BackupWallet(string Destination)
		{
			RpcCall<object>
				(new RPCRequest("backupwallet", new Object[] { Destination }));
		}

		public CreateMultiSigResponse CreateMultiSig(int NRequired, IEnumerable<string>Keys)
		{
			return RpcCall<CreateMultiSigResponse>
				(new RPCRequest("createmultisig", new Object[] { NRequired, Keys }));
		}

		public string CreateRawTransaction(IEnumerable<Object> Inputs, IDictionary<string, decimal> Outputs)
		{
			throw new NotImplementedException();
		}
		
		public DecodeRawTransactionResponse DecodeRawTransaction(string Transaction)
		{
			return RpcCall<DecodeRawTransactionResponse>
				(new RPCRequest("decoderawtransaction", new Object[] { Transaction }));
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

		public IEnumerable<GetAddedNodeInfoResponse> GetAddedNodeInfo(bool Dns, string Node)
		{
			if (Dns)
			{
				return RpcCall<IEnumerable<GetAddedNodeInfoResponse>>
					(new RPCRequest("getaddednodeinfo", new Object[] { Dns, Node }));
			}
			return new GetAddedNodeInfoResponse[] { 
				RpcCall<GetAddedNodeInfoResponse>
					(new RPCRequest("getaddednodeinfo", new Object[] { Dns, Node }))
			};
		}

		public IEnumerable<string> GetAddressesByAccount(string Account)
		{
			return RpcCall<IEnumerable<string>>
				(new RPCRequest("getaddressesbyaccount", new Object[] { Account }));
		}

		public decimal GetBalance(string Account = null, int MinConf = 1)
		{
			if (Account == null)
			{
				return RpcCall<decimal>
					(new RPCRequest("getbalance"));
			}
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

		public void GetBlockTemplate()
		{
			throw new NotImplementedException();
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

		public GetPeerInfoResponse GetPeerInfo()
		{
			return RpcCall<GetPeerInfoResponse>
				(new RPCRequest("getpeerinfo"));
		}

		public IEnumerable<string> GetRawMemPool()
		{
			return RpcCall<IEnumerable<string>>
				(new RPCRequest("getrawmempool"));
		}

		public GetRawTransactionResponse GetRawTransaction(string TxId, int Verbose = 0)
		{
			return RpcCall<GetRawTransactionResponse>
				(new RPCRequest("getrawtransaction", new Object[] { TxId, Verbose }));
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

		public GetTxOutResponse GetTxOut(string TxID, int N, bool IncludeMemPool = true)
		{
			return RpcCall<GetTxOutResponse>
				(new RPCRequest("gettxout", new Object[] { TxID, N, IncludeMemPool }));
		}

		public GetTxOutSetInfoResponse GetTxOutSetInfo()
		{
			return RpcCall<GetTxOutSetInfoResponse>
				(new RPCRequest("gettxoutsetinfo"));
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

		public void ImportPrivKey(string BitcoinPrivKey, string Label = "", bool Rescan = true)
		{
			RpcCall<Object>
				(new RPCRequest("importprivkey", new Object[] { BitcoinPrivKey, Label, Rescan }));
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

		public IEnumerable<IEnumerable<ListAddressGroupingsResponse>> ListAddressGroupings(bool showEmptyGroups = true, bool showEmptyAddresses = true)
		{
			return RpcCall<IEnumerable<IEnumerable<ListAddressGroupingsResponse>>>
				(new RPCRequest("listaddressgroupings", new Object[] { showEmptyGroups, showEmptyAddresses }));
		}

		public void ListLockUnspent()
		{
			throw new NotImplementedException();
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

		public void ListUnspent()
		{
			throw new NotImplementedException();
		}

		public void LockUnspent()
		{
			throw new NotImplementedException();
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

		public string SendRawTransaction(string Tx)
		{
			return RpcCall<String>
				(new RPCRequest("sendrawtransaction", new Object[] { Tx }));
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

		public void SignRawTransaction()
		{
			throw new NotImplementedException();
		}

		public void Stop()
		{
			RpcCall<Object>
				(new RPCRequest("stop"));
		}

		public void SubmitBlock()
		{
			throw new NotImplementedException();
		}

		public ValidateAddressResponse ValidateAddress(string Address)
		{
			return RpcCall<ValidateAddressResponse>
				(new RPCRequest("validateaddress", new Object[] { Address }));
		}

		public bool VerifyMessage(string BitcoinAddress, string Signature, string Message)
		{
			return RpcCall<bool>
				(new RPCRequest("verifymessage", new Object[] { BitcoinAddress, Signature, Message }));
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
	}
}
