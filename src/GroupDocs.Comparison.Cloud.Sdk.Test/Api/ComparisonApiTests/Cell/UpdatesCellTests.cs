using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Cell
{
    public class UpdatesCellTests : BaseApiTest
    {
        [Test]
        public void UpdatesCell()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceCell, new List<TestFile> { TestFiles.TargetCell });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesCellPasswords()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceCellProtected, new List<TestFile> { TestFiles.TargetCellProtected });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
