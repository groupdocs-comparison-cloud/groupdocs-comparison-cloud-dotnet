using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Note
{
    public class ChangesNoteTests : BaseApiTest
    {
        [Test]
        public void ChangesNote()
        {
            var options = GetComparisonOptions(TestFiles.SourceNote, new List<TestFile>() { TestFiles.TargetNote });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(8, response.Count);
        }

        [Test]
        public void ChangesNotePasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceNoteProtected, new List<TestFile>() { TestFiles.TargetNoteProtected });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(8, response.Count);
        }
    }
}
