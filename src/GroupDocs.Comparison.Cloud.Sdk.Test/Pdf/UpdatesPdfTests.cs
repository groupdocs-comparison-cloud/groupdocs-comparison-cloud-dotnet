using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Pdf
{
    public class UpdatesPdfTests : BaseApiTest
    {
        [Test]
        public void UpdatesPdf()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourcePdf, new List<TestFile> { TestFiles.TargetPdf });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesPdfPasswords()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourcePdfProtected, new List<TestFile> { TestFiles.TargetPdfProtected });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
