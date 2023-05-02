using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Slide
{
    public class ChangesSlideTests : BaseApiTest
    {
        [Test]
        public void ChangesSlide()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlide, new List<TestFile> { TestFiles.TargetSlide });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(5, response.Count);
        }

        [Test]
        public void ChangesSlidePasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlideProtected, new List<TestFile> { TestFiles.TargetSlideProtected });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(5, response.Count);
        }

        [Test]
        public void ChangesSlideMulti()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlide,
                new List<TestFile>
                {
                    TestFiles.TargetSlide,
                    TestFiles.TargetSlide1,
                    TestFiles.TargetSlide2
                });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(4, response.Count);
        }

        [Test]
        public void ChangesSlideMultiPassword()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlideProtected,
                new List<TestFile>
                {
                    TestFiles.TargetSlideProtected,
                    TestFiles.TargetSlide1Protected,
                    TestFiles.TargetSlide2Protected
                });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(11, response.Count);
        }
    }
}
