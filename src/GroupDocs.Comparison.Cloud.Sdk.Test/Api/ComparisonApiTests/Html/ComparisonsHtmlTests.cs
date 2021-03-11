using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Html
{
    public class ComparisonsHtmlTests : BaseApiTest
    {
        [Test]
        public void ComparisonsHtml()
        {
            var options = GetComparisonOptions(TestFiles.SourceHtml, new List<TestFile> { TestFiles.TargetHtml });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
