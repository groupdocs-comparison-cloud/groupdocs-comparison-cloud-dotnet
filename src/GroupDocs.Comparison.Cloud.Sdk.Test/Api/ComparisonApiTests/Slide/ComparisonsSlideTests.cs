using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests.Slide
{
    public class ComparisonsSlideTests : BaseApiTest
    {
        [Test]
        public void ComparisonsSlide()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlide,new List<TestFile> { TestFiles.TargetSlide });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void ComparisonsSlidePasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlideProtected, new List<TestFile> { TestFiles.TargetSlideProtected });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void ComparisonsSlideMulti()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlide,
                new List<TestFile>
                {
                    TestFiles.TargetSlide,
                    TestFiles.TargetSlide1,
                    TestFiles.TargetSlide2
                });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void ComparisonsSlideMultiPassword()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlideProtected,
                new List<TestFile>
                {
                    TestFiles.TargetSlideProtected,
                    TestFiles.TargetSlide1Protected,
                    TestFiles.TargetSlide2Protected
                });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
