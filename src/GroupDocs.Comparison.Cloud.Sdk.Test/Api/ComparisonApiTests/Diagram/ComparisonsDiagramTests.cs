using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Diagram
{
    public class ComparisonsDiagramTests : BaseApiTest
    {
        [Test]
        public void ComparisonsDiagram()
        {
            var options = GetComparisonOptions(TestFiles.SourceDiagram, new List<TestFile>() { TestFiles.TargetDiagram });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
