using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Word
{
    public class ChangesWordTests : BaseApiTest
    {
        [Test]
        public void ChangesWord()
        {
            var options = GetComparisonOptions(TestFiles.SourceWord, new List<TestFile> { TestFiles.TargetWord });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(40, response.Count);
        }

        [Test]
        public void ChangesWordPasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceWordProtected, new List<TestFile> { TestFiles.TargetWordProtected });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(14, response.Count);
        }

        [Test]
        public void ChangesWordMulti()
        {
            var options = GetComparisonOptions(TestFiles.SourceWord,
                new List<TestFile>
                {
                    TestFiles.TargetWord,
                    TestFiles.TargetWord1,
                    TestFiles.TargetWord2
                });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(77, response.Count);
        }

        [Test]
        public void ChangesWordMultiPassword()
        {
            var options = GetComparisonOptions(TestFiles.SourceWordProtected,
                new List<TestFile>
                {
                    TestFiles.TargetWordProtected,
                    TestFiles.TargetWord1Protected,
                    TestFiles.TargetWord2Protected
                });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(32, response.Count);
        }
    }
}
