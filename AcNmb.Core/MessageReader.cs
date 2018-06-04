using AcNmb.Core.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace AcNmb.Core
{
    public class MessageReader
    {
        //private HttpClient httpClient;

        //public MessageReader()
        //{
        //    httpClient = new HttpClient();
        //}

        public async Task<string> GetResponseAsync(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(new Uri(url));
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
