//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Email
//{
//    public class CategoryChangesEmailTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryEmailByType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceEmail, new List<TestFile>() { TestFiles.TargetEmail });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryEmailByNodeType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceEmail, new List<TestFile>() { TestFiles.TargetEmail });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryEmailContainsNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceEmail, new List<TestFile>() { TestFiles.TargetEmail });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryEmailOnlyNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceEmail, new List<TestFile>() { TestFiles.TargetEmail });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
