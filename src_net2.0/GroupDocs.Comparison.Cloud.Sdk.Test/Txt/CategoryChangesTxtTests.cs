//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Txt
//{
//    public class CategoryChangesTxtTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryTextByType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceText, new List<TestFile>() { TestFiles.TargetText });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryTextByNodeType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceText, new List<TestFile>() { TestFiles.TargetText });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryTextContainsNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceText, new List<TestFile>() { TestFiles.TargetText });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryTextOnlyNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceText, new List<TestFile>() { TestFiles.TargetText });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
