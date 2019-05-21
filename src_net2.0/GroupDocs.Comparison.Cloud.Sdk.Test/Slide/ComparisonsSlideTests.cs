using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Slide
{
    public class ComparisonsSlideTests : BaseApiTest
    {
        [Test]
        public void ComparisonsSlide()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlide,new List<TestFile>() { TestFiles.TargetSlide });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void ComparisonsSlidePasswords()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlideProtected, new List<TestFile>() { TestFiles.TargetSlideProtected });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void ComparisonsSlideMulti()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlide,
                new List<TestFile>()
                {
                    TestFiles.TargetSlide,
                    TestFiles.TargetSlide1,
                    TestFiles.TargetSlide2
                });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }

        [Test, Ignore("Fixed in Comparison 19.4")]
        public void ComparisonsSlideMultiPassword()
        {
            var options = GetComparisonOptions(TestFiles.SourceSlideProtected,
                new List<TestFile>()
                {
                    TestFiles.TargetSlideProtected,
                    TestFiles.TargetSlide1Protected,
                    TestFiles.TargetSlide2Protected
                });
            var response = CompareApi.Comparisons(new ComparisonsRequest(options));
            Assert.AreEqual(response.Href, options.OutputPath);
        }
    }
}
