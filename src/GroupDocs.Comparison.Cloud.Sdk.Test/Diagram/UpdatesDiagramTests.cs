using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Diagram
{
    public class UpdatesDiagramTests : BaseApiTest
    {
        [Test]
        public void UpdatesDiagram()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceDiagram, new List<TestFile> { TestFiles.TargetDiagram });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
