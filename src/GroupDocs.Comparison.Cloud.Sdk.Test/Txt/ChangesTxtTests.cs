using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Txt
{
    public class ChangesTxtTests : BaseApiTest
    {
        [Test]
        public void ChangesText()
        {
            var options = GetComparisonOptions(TestFiles.SourceText, new List<TestFile> { TestFiles.TargetText });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(6, response.Count);
        }
    }
}
