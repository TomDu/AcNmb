using AcNmb.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Web.Http;
using System.Text;
using System.Threading.Tasks;
using AcNmb.Core.Entities;
using Newtonsoft.Json;

namespace AcNmb.Core
{
    public class EntityReader
    {
        private MessageReader messageReader;

        public EntityReader()
        {
            messageReader = new MessageReader();
        }

        public async Task<List<PostAndReplies>> GetPostList(string forum, int page)
        {
            string payload = await messageReader.GetResponseAsync(UrlUtil.GetPostListUrl(forum, page));

            return JsonConvert.DeserializeObject<PostAndReplies[]>(payload).ToList<PostAndReplies>();
        }

        public async Task<PostAndReplies> GetPost(string id, int page)
        {
            string payload = await messageReader.GetResponseAsync(UrlUtil.GetPostUrl(id, page));

            return JsonConvert.DeserializeObject<PostAndReplies>(payload);
        }
    }
}
