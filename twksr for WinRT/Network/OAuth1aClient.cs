using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace twksr.Network
{
    class OAuth1aClient : OAuthClient
    {

        string OAuthClient.Version
        {
            get { return "1.0a"; }
        }

        OAuthCredential OAuthClient.BaseCredential  { get; set; }

        int OAuthClient.TimeOut { get; set; }

        Task<System.Net.Http.HttpResponseMessage> OAuthClient.GetAsync(string uri, Dictionary<string, string> param)
        {
            throw new NotImplementedException();
        }

        Task<System.Net.Http.HttpResponseMessage> OAuthClient.GetAsync(Uri uri, Dictionary<string, string> param)
        {
            throw new NotImplementedException();
        }

        public async Task<System.Net.Http.HttpResponseMessage> OAuthClient.GetStreamAsync(Uri uri, Dictionary<string, string> param, HttpClient cli)
        {
            cli.Timeout = TimeSpan.FromMilliseconds(-1.0);
            cli.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("OAuth", CreateAuthorization(new Uri(uri), "GET", param));
            return await cli.GetStreamAsync(new Uri(uri + "?" + param.StringDictCombine("=", "&")));
        }

        Task<System.Net.Http.HttpResponseMessage> OAuthClient.GetAsync(string uri, Dictionary<string, string> param, System.Net.Http.HttpCompletionOption readMode)
        {
            throw new NotImplementedException();
        }

        Task<System.Net.Http.HttpResponseMessage> OAuthClient.PostAsync(string uri, Dictionary<string, string> param)
        {
            throw new NotImplementedException();
        }

        Task<System.Net.Http.HttpResponseMessage> OAuthClient.PostAsync(Uri uri, Dictionary<string, string> param)
        {
            throw new NotImplementedException();
        }

        Task<System.Net.Http.HttpResponseMessage> OAuthClient.DeleteAsync(Uri uri, Dictionary<string, string> param)
        {
            throw new NotImplementedException();
        }

        Task<System.Net.Http.HttpResponseMessage> OAuthClient.DeleteAsync(string uri, Dictionary<string, string> param)
        {
            throw new NotImplementedException();
        }

        string OAuthClient.UserAgent { get; set; }

    }
}
