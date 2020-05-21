using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Email
{
    public class ChangesEmailTests : BaseApiTest
    {
        [Test]
        public void ChangesEmail()
        {
            var options = GetComparisonOptions(TestFiles.SourceEmail, new List<TestFile> { TestFiles.TargetEmail });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(4, response.Count);
        }
    }
}
