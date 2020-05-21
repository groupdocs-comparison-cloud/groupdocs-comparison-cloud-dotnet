using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Diagram
{
    public class ChangesDiagramTests : BaseApiTest
    {
        [Test]
        public void ChangesDiagram()
        {
            var options = GetComparisonOptions(TestFiles.SourceDiagram, new List<TestFile> { TestFiles.TargetDiagram });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(3, response.Count);
        }
    }
}
