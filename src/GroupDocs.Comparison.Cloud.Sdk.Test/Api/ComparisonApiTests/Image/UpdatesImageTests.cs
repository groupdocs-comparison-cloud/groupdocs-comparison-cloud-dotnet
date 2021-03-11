using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Image
{
    public class UpdatesImageTests : BaseApiTest
    {
        [Test]
        public void UpdatesImage()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceImage, new List<TestFile> { TestFiles.TargetImage });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
