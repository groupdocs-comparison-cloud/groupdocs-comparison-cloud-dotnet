using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Email
{
    public class ComparisonsEmailTests : BaseApiTest
    {
        [Test]
        public void ComparisonsEmail()
        {
            var options = GetComparisonOptions(TestFiles.SourceEmail, new List<TestFile> { TestFiles.TargetEmail });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
