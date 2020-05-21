using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Image
{
    public class ChangesImageTests : BaseApiTest
    {
        [Test]
        public void ChangesImage()
        {
            var options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile> { TestFiles.TargetImage });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(170, response.Count);
        }
    }
}
