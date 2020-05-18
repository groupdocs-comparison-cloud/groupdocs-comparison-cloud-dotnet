using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Email
{
    public class UpdatesEmailTests : BaseApiTest
    {
        [Test]
        public void UpdatesEmail()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceEmail, new List<TestFile>() { TestFiles.TargetEmail });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
