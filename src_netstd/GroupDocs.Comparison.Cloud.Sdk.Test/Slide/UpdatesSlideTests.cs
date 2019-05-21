using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Slide
{
    public class UpdatesSlideTests : BaseApiTest
    {
        [Test]
        public void UpdatesSlide()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceSlide, new List<TestFile>() { TestFiles.TargetSlide });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void UpdatesSlidePasswords()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceSlideProtected,new List<TestFile>() { TestFiles.TargetSlideProtected });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void UpdatesSlideMulti()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceSlide,
                new List<TestFile>()
                {
                    TestFiles.TargetSlide,
                    TestFiles.TargetSlide1,
                    TestFiles.TargetSlide2
                });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void UpdatesSlideMultiPassword()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceSlideProtected,
                new List<TestFile>()
                {
                    TestFiles.TargetSlideProtected,
                    TestFiles.TargetSlide1Protected,
                    TestFiles.TargetSlide2Protected
                });

            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
