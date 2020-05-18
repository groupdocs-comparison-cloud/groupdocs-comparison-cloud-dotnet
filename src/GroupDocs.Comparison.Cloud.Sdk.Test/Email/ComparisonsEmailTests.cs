using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Email
{
    public class ComparisonsEmailTests : BaseApiTest
    {
        [Test]
        public void ComparisonsEmail()
        {
            var options = GetComparisonOptions(TestFiles.SourceEmail, new List<TestFile>() { TestFiles.TargetEmail });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
