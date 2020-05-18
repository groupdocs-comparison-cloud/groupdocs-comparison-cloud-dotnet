using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Txt
{
    public class UpdatesTxtTests : BaseApiTest
    {
        [Test]
        public void UpdatesText()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceText, new List<TestFile>() { TestFiles.TargetText });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
