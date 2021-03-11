using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Image
{
    public class ComparisonsImageTests : BaseApiTest
    {
        [Test]
        public void ComparisonsImage()
        {
            var options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile> { TestFiles.TargetImage });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
