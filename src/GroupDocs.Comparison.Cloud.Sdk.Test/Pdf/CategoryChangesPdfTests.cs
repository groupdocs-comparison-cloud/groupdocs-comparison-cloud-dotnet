//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Pdf
//{
//    public class CategoryChangesPdfTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryPdfByType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourcePdf, new List<TestFile>() { TestFiles.TargetPdf });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryPdfByNodeType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourcePdf, new List<TestFile>() { TestFiles.TargetPdf });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryPdfContainsNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourcePdf, new List<TestFile>() { TestFiles.TargetPdf });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryPdfOnlyNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourcePdf, new List<TestFile>() { TestFiles.TargetPdf });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryPdfByTypePasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourcePdfProtected, new List<TestFile>() { TestFiles.TargetPdfProtected });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryPdfByNodeTypePasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourcePdfProtected, new List<TestFile>() { TestFiles.TargetPdfProtected });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryPdfContainsNumbersPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourcePdfProtected, new List<TestFile>() { TestFiles.TargetPdfProtected });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryPdfOnlyNumbersPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourcePdfProtected, new List<TestFile>() { TestFiles.TargetPdfProtected });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
