using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Word
{
    public class UpdatesWordTests : BaseApiTest
    {
        [Test]
        public void UpdatesWord()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceWord, new List<TestFile>() { TestFiles.TargetWord });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesWordPasswords()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceWordProtected, new List<TestFile>() { TestFiles.TargetWordProtected });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesWordMulti()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceWord,
                new List<TestFile>()
                {
                    TestFiles.TargetWord,
                    TestFiles.TargetWord1,
                    TestFiles.TargetWord2
                });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesWordMultiPassword()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceWordProtected,
                new List<TestFile>()
                {
                    TestFiles.TargetWordProtected,
                    TestFiles.TargetWord1Protected,
                    TestFiles.TargetWord2Protected
                });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
