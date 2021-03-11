using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Cell
{
    public class ChangesCellTests : BaseApiTest
    {
        [Test]
        public void ChangesCell()
        {
            var options = GetComparisonOptions(TestFiles.SourceCell, new List<TestFile> { TestFiles.TargetCell });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(36, response.Count);
        }

        [Test]
        public void ChangesCellPasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceCellProtected, new List<TestFile> { TestFiles.TargetCellProtected });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(5, response.Count);
        }
    }
}
