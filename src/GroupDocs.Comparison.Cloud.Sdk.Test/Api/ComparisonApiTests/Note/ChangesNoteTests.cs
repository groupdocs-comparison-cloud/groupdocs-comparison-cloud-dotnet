﻿using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Note
{
    [Ignore("Not supported in linux")]
    public class ChangesNoteTests : BaseApiTest
    {
        [Test]
        public void ChangesNote()
        {
            var options = GetComparisonOptions(TestFiles.SourceNote, new List<TestFile>() { TestFiles.TargetNote });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(12, response.Count);
        }

        [Test]
        public void ChangesNotePasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceNoteProtected, new List<TestFile>() { TestFiles.TargetNoteProtected });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(12, response.Count);
        }
    }
}
