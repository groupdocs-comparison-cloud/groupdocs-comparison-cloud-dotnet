//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Cell
//{
//    public class CategoryChangesCellTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryCellByType()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceCell, new List<TestFile>() { TestFiles.TargetCell });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryCellByNodeType()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceCell, new List<TestFile>() { TestFiles.TargetCell });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryCellContainsNumbers()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceCell, new List<TestFile>() { TestFiles.TargetCell });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryCellOnlyNumbers()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceCell, new List<TestFile>() { TestFiles.TargetCell });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategoryCellByTypePasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceCellProtected, new List<TestFile>() { TestFiles.TargetCellProtected });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategoryCellByNodeTypePasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceCellProtected, new List<TestFile>() { TestFiles.TargetCellProtected });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategoryCellContainsNumbersPasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceCellProtected, new List<TestFile>() { TestFiles.TargetCellProtected });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategoryCellOnlyNumbersPasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceCellProtected, new List<TestFile>() { TestFiles.TargetCellProtected });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
