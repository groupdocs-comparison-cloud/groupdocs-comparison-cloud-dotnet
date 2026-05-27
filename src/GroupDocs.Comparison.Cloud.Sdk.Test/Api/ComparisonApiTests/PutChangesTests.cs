using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ComparisonApiTests
{
    public class PutChangesTests : BaseApiTest
    {
        [Test]
        public void PutChangesWord()
        {
            var request = new PutChangesRequest(GetTestFileInfo(TestFiles.SourceWord), GetTestFileInfo(TestFiles.TargetWord));
            var response = CompareApi.PutChanges(request);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PutChangesPdf()
        {
            var request = new PutChangesRequest(GetTestFileInfo(TestFiles.SourcePdf), GetTestFileInfo(TestFiles.TargetPdf));
            var response = CompareApi.PutChanges(request);
            Assert.Greater(response.Count, 0);
        }


        [Test]
        public void PutChangesCell()
        {
            var request = new PutChangesRequest(GetTestFileInfo(TestFiles.SourceCell), GetTestFileInfo(TestFiles.TargetCell));
            var response = CompareApi.PutChanges(request);
            Assert.Greater(response.Count, 0);
        }


        [Test]
        public void PutChangesHtml()
        {
            var request = new PutChangesRequest(GetTestFileInfo(TestFiles.SourceHtml), GetTestFileInfo(TestFiles.TargetHtml));
            var response = CompareApi.PutChanges(request);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void PutChangesImage()
        {
            var request = new PutChangesRequest(GetTestFileInfo(TestFiles.SourceImage), GetTestFileInfo(TestFiles.TargetImage));
            var response = CompareApi.PutChanges(request);
            Assert.Greater(response.Count, 0);
        }


        [Test]
        public void PutChangesTxt()
        {
            var request = new PutChangesRequest(GetTestFileInfo(TestFiles.SourceText), GetTestFileInfo(TestFiles.TargetText));
            var response = CompareApi.PutChanges(request);
            Assert.Greater(response.Count, 0);
        }
    }
}
