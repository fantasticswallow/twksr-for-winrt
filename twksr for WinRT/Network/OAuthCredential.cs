using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twksr.Network
{
    public class OAuthCredential
    {
        public string ConsumerKey{get; set;}
        public string ConsumerSecret{get; set;}
        public string RedirectUrl{get; set;}

        public OAuthCredential()
        {
        }

        public OAuthCredential(string key, string secret)
        {
            this.ConsumerKey = key;
            this.ConsumerSecret = secret;
        }

        public OAuthCredential(string key ,string secret,string redUrl)
        {
            this.ConsumerKey = key;
            this.ConsumerSecret = secret;
            this.RedirectUrl = redUrl;
        }
    }
}
