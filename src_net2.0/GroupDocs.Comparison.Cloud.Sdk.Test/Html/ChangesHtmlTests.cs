using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Html
{
    public class ChangesHtmlTests : BaseApiTest
    {
        [Test]
        public void ChangesHtml()
        {
            var options = GetComparisonOptions(TestFiles.SourceHtml, new List<TestFile>() { TestFiles.TargetHtml });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(3, response.Count);
        }
    }
}
