using AcNmb.Core.Entities;
using AcNmb.Core.Utils;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcNmb.Core.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EntityReader reader = new EntityReader();
            Task<List<PostAndReplies>> task = reader.GetPostList("4", 1);
            IList<PostAndReplies> postAbstract = task.Result;

            Assert.IsNotNull(postAbstract);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MessageReader reader = new MessageReader();
            string url = UrlUtil.GetPostListUrl("4", 1);
            Task<string> task = reader.GetResponseAsync(url);
            string postAbstract = task.Result;

            Assert.IsNotNull(postAbstract);
        }
    }
}
