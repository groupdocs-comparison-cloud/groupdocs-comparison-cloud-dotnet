using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Slide
{
    public class UpdatesSlideTests : BaseApiTest
    {
        [Test]
        public void UpdatesSlide()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceSlide, new List<TestFile> { TestFiles.TargetSlide });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesSlidePasswords()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceSlideProtected,new List<TestFile> { TestFiles.TargetSlideProtected });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesSlideMulti()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceSlide,
                new List<TestFile>
                {
                    TestFiles.TargetSlide,
                    TestFiles.TargetSlide1,
                    TestFiles.TargetSlide2
                });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void UpdatesSlideMultiPassword()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceSlideProtected,
                new List<TestFile>
                {
                    TestFiles.TargetSlideProtected,
                    TestFiles.TargetSlide1Protected,
                    TestFiles.TargetSlide2Protected
                });

            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
