//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Image
//{
//    public class CategoryChangesImageTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryImageByType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile>() { TestFiles.TargetImage });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryImageByNodeType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile>() { TestFiles.TargetImage });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryImageContainsNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile>() { TestFiles.TargetImage });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryImageOnlyNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile>() { TestFiles.TargetImage });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryImageOnlyByShapes()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile>() { TestFiles.TargetImage });
//            options.CategoryType = "ByShapes";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryImageOnlyByZones()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceImage, new List<TestFile>() { TestFiles.TargetImage });
//            options.CategoryType = "ByZones";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
