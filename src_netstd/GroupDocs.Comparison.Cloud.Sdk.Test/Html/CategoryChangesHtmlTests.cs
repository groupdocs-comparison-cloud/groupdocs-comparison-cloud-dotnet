//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Html
//{
//    public class CategoryChangesHtmlTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryHtmlByType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceHtml, new List<TestFile>() { TestFiles.TargetHtml });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryHtmlByNodeType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceHtml, new List<TestFile>() { TestFiles.TargetHtml });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryHtmlContainsNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceHtml, new List<TestFile>() { TestFiles.TargetHtml });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryHtmlOnlyNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceHtml, new List<TestFile>() { TestFiles.TargetHtml });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
