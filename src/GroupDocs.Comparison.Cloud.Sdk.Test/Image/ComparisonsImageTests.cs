using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Image
{
    public class ComparisonsImageTests : BaseApiTest
    {
        [Test, Ignore("Type casting bug, fixed in Comparison 19.4")]
        public void ComparisonsImage()
        {
            var options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile>() { TestFiles.TargetImage });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
