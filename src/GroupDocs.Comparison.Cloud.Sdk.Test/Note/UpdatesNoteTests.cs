using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Note
{
    public class UpdatesNoteTests : BaseApiTest
    {
        [Test]
        public void UpdatesNote()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceNote, new List<TestFile> { TestFiles.TargetNote });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesNotePasswords()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceNoteProtected, new List<TestFile> { TestFiles.TargetNoteProtected });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
