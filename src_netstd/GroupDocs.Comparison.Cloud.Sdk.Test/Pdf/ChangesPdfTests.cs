using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Pdf
{
    public class ChangesPdfTests : BaseApiTest
    {
        [Test]
        public void ChangesPdf()
        {
            var options = GetComparisonOptions(TestFiles.SourcePdf, new List<TestFile>() { TestFiles.TargetPdf });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(3, response.Count);
        }

        [Test]
        public void ChangesPdfPasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourcePdfProtected, new List<TestFile>() { TestFiles.TargetPdfProtected });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(3, response.Count);
        }
    }
}
