using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Txt
{
    public class UpdatesTxtTests : BaseApiTest
    {
        [Test]
        public void UpdatesText()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceText, new List<TestFile> { TestFiles.TargetText });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
