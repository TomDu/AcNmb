using AcNmb.Core.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcNmb.Core.Entities
{
    public class Reply
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("now")]
        public string Now { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("sage")]
        public string Sage { get; set; }

        [JsonProperty("admin")]
        public string Admin { get; set; }

        public string ImagePath
        {
            get
            {
                return UrlUtil.ImagePathPrefix + Img + Ext;
            }
        }
    }
}
