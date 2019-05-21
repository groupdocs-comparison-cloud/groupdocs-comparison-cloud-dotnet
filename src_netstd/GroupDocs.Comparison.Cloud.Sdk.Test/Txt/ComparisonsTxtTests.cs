using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Txt
{
    public class ComparisonsTxtTests : BaseApiTest
    {
        [Test]
        public void ComparisonsText()
        {
            var options = GetComparisonOptions(TestFiles.SourceText, new List<TestFile>() { TestFiles.TargetText });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
