using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Txt
{
    public class ComparisonsTxtTests : BaseApiTest
    {
        [Test]
        public void ComparisonsText()
        {
            var options = GetComparisonOptions(TestFiles.SourceText, new List<TestFile> { TestFiles.TargetText });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
