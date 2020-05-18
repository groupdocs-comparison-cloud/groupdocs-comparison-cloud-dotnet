using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Note
{
    public class ComparisonsNoteTests : BaseApiTest
    {
        [Test]
        public void ComparisonsNote()
        {
            var options = GetComparisonOptions(TestFiles.SourceNote, new List<TestFile>() { TestFiles.TargetNote });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }

        [Test]
        public void ComparisonsNotePasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceNoteProtected, new List<TestFile>() { TestFiles.TargetNoteProtected });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
