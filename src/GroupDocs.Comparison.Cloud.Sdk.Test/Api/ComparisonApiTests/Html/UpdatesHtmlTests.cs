using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Html
{
    public class UpdatesHtmlTests : BaseApiTest
    {
        [Test]
        public void UpdatesHtml()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceHtml, new List<TestFile> { TestFiles.TargetHtml });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
