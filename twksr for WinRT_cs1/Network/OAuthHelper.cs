using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;

namespace twksr.Network
{
    /// <summary>
    /// OAuthの署名作成
    /// </summary>
    class OAuthHelper
    {
        public string EncryptToSHA1(string key,string data)
        {
            var hmac = MacAlgorithmProvider.OpenAlgorithm("HMAC_SHA1");
            var keyBuffer = CryptographicBuffer.ConvertStringToBinary(key, BinaryStringEncoding.Utf8);
            var xkey = hmac.CreateKey(keyBuffer);
            var hashData = CryptographicEngine.Sign(xkey, CryptographicBuffer.ConvertStringToBinary(data, BinaryStringEncoding.Utf8));
            return CryptographicBuffer.EncodeToBase64String(hashData);
        }
        
        public string StringDictCombine(Dictionary<String, String> target, string keybitween ,string itembitween)
        {
            var retStr = "";
            if ((target != null ) && (target.Count > 0))
            {
                foreach (var x in target)
                {
                    if (retStr == "")
                        retStr = x.Key + keybitween + x.Value;
                    else
                        retStr += itembitween + x.Key + keybitween + x.Value;
                }
            }
            return retStr;
        }

        private Dictionary<TKey,TValue> DictionarySort<TKey,TValue>(Dictionary<TKey, TValue> arg)
        {
            var retDict = new Dictionary<TKey,TValue>();
            var argsList = new List<TKey>(arg.Keys);
            argsList.Sort();
            for (var i = 0; i < argsList.Count; i++)
            {
                retDict.Add(argsList[i], arg[argsList[i]]);
            }
            return retDict;
        }
        
    }
}
