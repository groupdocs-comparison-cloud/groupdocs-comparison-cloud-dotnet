using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Pdf
{
    public class ComparisonsPdfTests : BaseApiTest
    {
        [Test]
        public void ComparisonsPdf()
        {
            var options = GetComparisonOptions(TestFiles.SourcePdf, new List<TestFile> { TestFiles.TargetPdf });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void ComparisonsPdfPasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourcePdfProtected, new List<TestFile> { TestFiles.TargetPdfProtected });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
