﻿// COPYRIGHT 2011 Konstantin Ineshin, Irkutsk, Russia.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bitnet.Client
{
    public class BitnetClient : IBitnetClient
    {
        public BitnetClient()
        {
        }

        public BitnetClient(string a_sUri)
        {
            Url = new Uri(a_sUri);
        }

        public Uri Url;

        public ICredentials Credentials;

        public JObject InvokeMethod(string a_sMethod, params object[] a_params)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(Url);
            webRequest.Credentials = Credentials;

            webRequest.ContentType = "application/json-rpc";
            webRequest.Method = "POST";

            JObject joe = new JObject();
            joe["jsonrpc"] = "1.0";
            joe["id"] = "1";
            joe["method"] = a_sMethod;

            if (a_params != null)
            {
                if (a_params.Length > 0)
                {
                    JArray props = new JArray();
                    foreach (var p in a_params)
                    {
                        props.Add(p);
                    }
                    joe.Add(new JProperty("params", props));
                }
            }

            string s = JsonConvert.SerializeObject(joe);
            // serialize json for the request
            byte[] byteArray = Encoding.UTF8.GetBytes(s);
            webRequest.ContentLength = byteArray.Length;

            using (Stream dataStream = webRequest.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            webRequest.Timeout = 10000000;

            using (WebResponse webResponse = webRequest.GetResponse())
            {
                using (Stream str = webResponse.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(str))
                    {
                        return JsonConvert.DeserializeObject<JObject>(sr.ReadToEnd());
                    }
                }
            }
        }



        //ADD ADDITIONAL STOHNCOIN METHODS HERE!!!
        //ALL YOU HAVE TO DO IS COPY / PASTE ONE OF THE EXISTING METHODS 
        //and change the name of the method being invoked.
        //depending on what gets returned you may need to cast it into a string, JArray, or JObject


        public JArray ListWallets()
        {
            return InvokeMethod("listwallets")["result"] as JArray;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>"name" of the wallet IF loaded correctly, "warning" if the wallet was not loaded cleanly</returns>
        public string LoadWallet(string filename)
        {
            return InvokeMethod("loadwallet", filename)["result"].ToString();
        }

        public string UnLoadWallet(string filename)
        {
            return InvokeMethod("unloadwallet", filename)["result"].ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wallet_name"></param>
        /// <returns>"name" of the wallet IF loaded correctly, "warning" if the wallet was not loaded cleanly</returns>
        public string CreateWallet(string wallet_name)
        {
            return InvokeMethod("createwallet", wallet_name)["result"].ToString();
        }


        public void BackupWallet(string a_destination)
        {
            InvokeMethod("backupwallet", a_destination);
        }

        public string GetAccount(string a_address)
        {
            return InvokeMethod("getaccount", a_address)["result"].ToString();
        }

        public string GetAccountAddress(string a_account)
        {
            return InvokeMethod("getaccountaddress", a_account)["result"].ToString();
        }

        public IEnumerable<string> GetAddressesByAccount(string a_account)
        {
            return from o in InvokeMethod("getaddressesbyaccount", a_account)["result"]
                   select o.ToString();
        }

        public float GetBalance(string a_account = null, int a_minconf = 1)
        {
            if (a_account == null)
            {
                return (float)InvokeMethod("getbalance")["result"];
            }
            return (float)InvokeMethod("getbalance", a_account, a_minconf)["result"];
        }

        public string GetBlockByCount(int a_height)
        {
            return InvokeMethod("getblockbycount", a_height)["result"].ToString();
        }

        public int GetBlockCount()
        {
            return (int)InvokeMethod("getblockcount")["result"];
        }

        public int GetBlockNumber()
        {
            return (int)InvokeMethod("getblocknumber")["result"];
        }

        public int GetConnectionCount()
        {
            return (int)InvokeMethod("getconnectioncount")["result"];
        }

        public float GetDifficulty()
        {
            return (float)InvokeMethod("getdifficulty")["result"];
        }

        public bool GetGenerate()
        {
            return (bool)InvokeMethod("getgenerate")["result"];
        }

        public float GetHashesPerSec()
        {
            return (float)InvokeMethod("gethashespersec")["result"];
        }

        public JObject GetInfo()
        {
            return InvokeMethod("getinfo")["result"] as JObject;
        }

        public string GetNewAddress(string a_account)
        {
            return InvokeMethod("getnewaddress", a_account)["result"].ToString();
        }

        public float GetReceivedByAccount(string a_account, int a_minconf = 1)
        {
            return (float)InvokeMethod("getreceivedbyaccount", a_account, a_minconf)["result"];
        }

        public float GetReceivedByAddress(string a_address, int a_minconf = 1)
        {
            return (float)InvokeMethod("getreceivedbyaddress", a_address, a_minconf)["result"];
        }

        public JObject GetTransaction(string a_txid)
        {
            return InvokeMethod("gettransaction", a_txid)["result"] as JObject;
        }

        public JObject GetWork()
        {
            return InvokeMethod("getwork")["result"] as JObject;
        }

        public bool GetWork(string a_data)
        {
            return (bool)InvokeMethod("getwork", a_data)["result"];
        }

        public string Help(string a_command = "")
        {
            return InvokeMethod("help", a_command)["result"].ToString();
        }

        public JObject ListAccounts(int a_minconf = 1)
        {
            return InvokeMethod("listaccounts", a_minconf)["result"] as JObject;
        }

        public JArray ListReceivedByAccount(int a_minconf = 1, bool a_includeEmpty = false)
        {
            return InvokeMethod("listreceivedbyaccount", a_minconf, a_includeEmpty)["result"] as JArray;
        }

        public JArray ListReceivedByAddress(int a_minconf = 1, bool a_includeEmpty = false)
        {
            return InvokeMethod("listreceivedbyaddress", a_minconf, a_includeEmpty)["result"] as JArray;
        }

        /// <summary>
        /// returns these  "walletname" , "walletversion" ,  "format" ,  "balance" ,  "unconfirmed_balance" ,  "immature_balance" ,  "txcount" ,  "keypoololdest" ,  "keypoolsize" ,  "keypoolsize_hd_internal" ,  "unlocked_until" ,  ,paytxfee" ,  "hdseedid" ,  "private_keys_enabled" ,  "avoid_reuse"
        /// </summary>
        /// <returns>jarray  </returns>
        public JObject GetWalletInfo()
        {
            return InvokeMethod("getwalletinfo")["result"] as JObject;
        }



        public JArray ListTransactions(string a_account, int a_count = 10)
        {
            return InvokeMethod("listtransactions", a_account, a_count)["result"] as JArray;
        }

        public bool Move(
          string a_fromAccount,
          string a_toAccount,
          float a_amount,
          int a_minconf = 1,
          string a_comment = ""
        )
        {
            return (bool)InvokeMethod(
              "move",
              a_fromAccount,
              a_toAccount,
              a_amount,
              a_minconf,
              a_comment
            )["result"];
        }

        public string SendFrom(
          string a_fromAccount,
          string a_toAddress,
          float a_amount,
          int a_minconf = 1,
          string a_comment = "",
          string a_commentTo = ""
        )
        {
            return InvokeMethod(
              "sendfrom",
              a_fromAccount,
              a_toAddress,
              a_amount,
              a_minconf,
              a_comment,
              a_commentTo
            )["result"].ToString();
        }

        /// <summary>
        /// sets the TX Fee, This is needed because stohn community doesn't have enough miners/validators.
        /// in time this will not be a problem, but for now you need to set the fee manually.
        /// </summary>
        /// <param name="fee">if you aren't sure just use 0.00001</param>
        /// <returns></returns>
        public string SetTXFee(string fee)
        {
            //0.00001
            return InvokeMethod("settxfee", fee)["result"].ToString();
        }

        public string SendToAddress(string a_address, float a_amount, string a_comment, string a_commentTo)
        {
            return InvokeMethod("sendtoaddress", a_address, a_amount, a_comment, a_commentTo, true)["result"].ToString();
        }

        public void SetAccount(string a_address, string a_account)
        {
            InvokeMethod("setaccount", a_address, a_account);
        }

        public void SetGenerate(bool a_generate, int a_genproclimit = 1)
        {
            InvokeMethod("setgenerate", a_generate, a_genproclimit);
        }

        public void Stop()
        {
            InvokeMethod("stop");
        }

        public JObject ValidateAddress(string a_address)
        {
            return InvokeMethod("validateaddress", a_address)["result"] as JObject;
        }
    }
}
