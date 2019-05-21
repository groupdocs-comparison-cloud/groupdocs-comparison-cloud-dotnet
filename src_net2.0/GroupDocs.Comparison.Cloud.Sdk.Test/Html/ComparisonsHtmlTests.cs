using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Html
{
    public class ComparisonsHtmlTests : BaseApiTest
    {
        [Test, Ignore("Type casting bug, fixed in Comparison 19.4")]
        public void ComparisonsHtml()
        {
            var options = GetComparisonOptions(TestFiles.SourceHtml, new List<TestFile>() { TestFiles.TargetHtml });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
