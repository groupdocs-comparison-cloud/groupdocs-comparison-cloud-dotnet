using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Diagram
{
    public class ComparisonsDiagramTests : BaseApiTest
    {
        [Test]
        public void ComparisonsDiagram()
        {
            var options = GetComparisonOptions(TestFiles.SourceDiagram, new List<TestFile>() { TestFiles.TargetDiagram });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
