using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Cell
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
            Assert.AreEqual(6, response.Count);
        }
    }
}
