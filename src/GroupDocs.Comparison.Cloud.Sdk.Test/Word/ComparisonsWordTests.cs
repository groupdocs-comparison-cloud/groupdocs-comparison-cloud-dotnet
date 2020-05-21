using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Word
{
    public class ComparisonsWordTests : BaseApiTest
    {
        [Test]
        public void ComparisonsWord()
        {
            var options = GetComparisonOptions(TestFiles.SourceWord, new List<TestFile> { TestFiles.TargetWord });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void ComparisonsWordPasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceWordProtected, new List<TestFile> { TestFiles.TargetWordProtected });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void ComparisonsWordMulti()
        {
            var options = GetComparisonOptions(TestFiles.SourceWord,
                new List<TestFile>
                {
                    TestFiles.TargetWord,
                    TestFiles.TargetWord1,
                    TestFiles.TargetWord2
                });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void ComparisonsWordMultiPassword()
        {
            var options = GetComparisonOptions(TestFiles.SourceWordProtected,
                new List<TestFile>
                {
                    TestFiles.TargetWordProtected,
                    TestFiles.TargetWord1Protected,
                    TestFiles.TargetWord2Protected
                });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
