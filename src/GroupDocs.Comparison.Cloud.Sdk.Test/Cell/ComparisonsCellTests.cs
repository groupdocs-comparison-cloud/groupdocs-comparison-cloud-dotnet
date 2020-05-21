using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Cell
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
