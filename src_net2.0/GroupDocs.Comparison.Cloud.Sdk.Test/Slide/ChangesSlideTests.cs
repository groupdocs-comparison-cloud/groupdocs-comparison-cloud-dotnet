using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Slide
{
    public class ChangesSlideTests : BaseApiTest
    {
        [Test, Ignore("Fixed in Comparison 19.4")]
        public void ChangesSlide()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlide, new List<TestFile>() { TestFiles.TargetSlide });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(40, response.Count);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void ChangesSlidePasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlideProtected, new List<TestFile>() { TestFiles.TargetSlideProtected });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(14, response.Count);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void ChangesSlideMulti()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlide,
                new List<TestFile>()
                {
                    TestFiles.TargetSlide,
                    TestFiles.TargetSlide1,
                    TestFiles.TargetSlide2
                });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(77, response.Count);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void ChangesSlideMultiPassword()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlideProtected,
                new List<TestFile>()
                {
                    TestFiles.TargetSlideProtected,
                    TestFiles.TargetSlide1Protected,
                    TestFiles.TargetSlide2Protected
                });
            var response = CompareApi.PostChanges(new PostChangesRequest(options));
            Assert.AreEqual(32, response.Count);
        }
    }
}
