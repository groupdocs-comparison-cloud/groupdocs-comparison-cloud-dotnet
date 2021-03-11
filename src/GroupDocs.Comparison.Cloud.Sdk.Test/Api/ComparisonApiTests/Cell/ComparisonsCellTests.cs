using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Cell
{
    public class ComparisonsCellTests : BaseApiTest
    {
        [Test]
        public void ComparisonsCell()
        {
            var options = GetComparisonOptions(TestFiles.SourceCell, new List<TestFile> { TestFiles.TargetCell });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void ComparisonsCellPasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceCellProtected, new List<TestFile> { TestFiles.TargetCellProtected });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
