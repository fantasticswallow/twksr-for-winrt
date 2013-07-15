using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace twksr.Network
{
    interface OAuthClient
    {
        string Version {get;}
        OAuthCredential BaseCredential {get; set;}
        int TimeOut {get; set;}
        Task<HttpResponseMessage> GetAsync(string uri, Dictionary<String, String> param);
        Task<HttpResponseMessage> GetAsync(Uri uri, Dictionary<String, String> param);
        Task<HttpResponseMessage> GetStreamAsync(Uri uri, Dictionary<String, String> param, HttpClient cli);
        Task<HttpResponseMessage> GetAsync(string uri, Dictionary<String, String> param,HttpCompletionOption readMode);
        Task<HttpResponseMessage> PostAsync(string uri, Dictionary<String, String> param);
        Task<HttpResponseMessage> PostAsync(Uri uri, Dictionary<String, String> param);
        Task<HttpResponseMessage> DeleteAsync(Uri uri, Dictionary<String, String> param);
        Task<HttpResponseMessage> DeleteAsync(string uri, Dictionary<String, String> param);
        string UserAgent{get; set;}
    }
}
