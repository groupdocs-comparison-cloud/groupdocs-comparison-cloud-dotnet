using System.Linq;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.ReviewApiTests
{
    public class RevisionsTests : BaseApiTest
    {
        [Test]
        public void GetRevisions()
        {
            var response = ReviewApi.GetRevisions(new GetRevisionsRequest(TestFiles.SourceWithRevs.ToFileInfo()));
            Assert.AreEqual(2, response.Count);
        }

        [Test]
        public void ApplyRevisions()
        {
            var options = new ApplyRevisionsOptions
            {
                SourceFile = TestFiles.SourceWithRevs.ToFileInfo(),
                Revisions = new[]
                {
                    new RevisionInfo { Id = 0, Action = RevisionInfo.ActionEnum.Accept },
                    new RevisionInfo { Id = 1, Action = RevisionInfo.ActionEnum.Reject }
                }.ToList(),
                OutputPath = "/resultFilePath/" + TestFiles.SourceWithRevs.FileName,
            };
            var response = ReviewApi.ApplyRevisions(new ApplyRevisionsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void AcceptAllRevisions()
        {
            var options = new ApplyRevisionsOptions
            {
                SourceFile = TestFiles.SourceWithRevs.ToFileInfo(),
                AcceptAll = true,
                OutputPath = "/resultFilePath/" + TestFiles.SourceWithRevs.FileName,
            };
            var response = ReviewApi.ApplyRevisions(new ApplyRevisionsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

        [Test]
        public void RejectAllRevisions()
        {
            var options = new ApplyRevisionsOptions
            {
                SourceFile = TestFiles.SourceWithRevs.ToFileInfo(),
                RejectAll = true,
                OutputPath = "/resultFilePath/" + TestFiles.SourceWithRevs.FileName,
            };
            var response = ReviewApi.ApplyRevisions(new ApplyRevisionsRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }

    }
}
