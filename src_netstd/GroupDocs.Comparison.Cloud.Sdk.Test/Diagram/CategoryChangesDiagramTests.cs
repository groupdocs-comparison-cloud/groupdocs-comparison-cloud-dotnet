//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Diagram
//{
//    public class CategoryChangesDiagramTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryDiagramByType()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceDiagram, new List<TestFile>() { TestFiles.TargetDiagram });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryDiagramByNodeType()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceDiagram, new List<TestFile>() { TestFiles.TargetDiagram });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryDiagramContainsNumbers()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceDiagram, new List<TestFile>() { TestFiles.TargetDiagram });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryDiagramOnlyNumbers()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceDiagram, new List<TestFile>() { TestFiles.TargetDiagram });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
