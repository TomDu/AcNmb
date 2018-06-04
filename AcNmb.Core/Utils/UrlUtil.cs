using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcNmb.Core.Utils
{
    public class UrlUtil
    {
        public const string AppId = "nimingban";
        public const string Host = "http://adnmb1.com";
        public const string ServiceRoot = Host + "/Api";
        public const string PostList = ServiceRoot + "/showf?appid=" + AppId;
        public const string Post = ServiceRoot + "/thread?appid=" + AppId;

        public const string ImagePathPrefix = "http://img1.adnmb1.com/image/";

        public static string GetPostListUrl(string forum, int page)
        {
            return PostList + "&id=" + forum + "&page=" + (page + 1);
        }

        public static string GetPostUrl(string id, int page)
        {
            return Post + "&id=" + id + "&page" + (page + 1);
        }
    }
}
