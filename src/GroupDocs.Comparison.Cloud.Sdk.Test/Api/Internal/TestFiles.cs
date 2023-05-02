// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal
{
    public static class TestFiles
    {
        #region Source
        
        #region Not protected files
        public static readonly TestFile SourceCell = new TestFile("source.xlsx", "source_files\\cell\\");
        public static readonly TestFile SourceDiagram = new TestFile("source.vsdx", "source_files\\diagram\\");
        public static readonly TestFile SourceEmail = new TestFile("source.eml", "source_files\\email\\");
        public static readonly TestFile SourceHtml = new TestFile("source.html", "source_files\\html\\");
        public static readonly TestFile SourceImage = new TestFile("source.png", "source_files\\image\\");
        public static readonly TestFile SourceNote = new TestFile("source.one", "source_files\\note\\");
        public static readonly TestFile SourcePdf = new TestFile("source.pdf", "source_files\\pdf\\");
        public static readonly TestFile SourceSlide = new TestFile("source.pptx", "source_files\\slide\\");
        public static readonly TestFile SourceText = new TestFile("source.txt", "source_files\\text\\");
        public static readonly TestFile SourceWord = new TestFile("source.docx", "source_files\\word\\");
        public static readonly TestFile SourceWithRevs = new TestFile("source_with_revs.docx", "source_files\\word\\");
        #endregion

        #region Protected files
        public static readonly TestFile SourceCellProtected = new TestFile("source_protected.xlsx", "source_files\\cell\\", "1231");
        public static readonly TestFile SourceNoteProtected = new TestFile("source_protected.one", "source_files\\note\\", "123");
        public static readonly TestFile SourcePdfProtected = new TestFile("source_protected.pdf", "source_files\\pdf\\", "12345678");
        public static readonly TestFile SourceSlideProtected = new TestFile("source_protected.pptx", "source_files\\slide\\", "1231");
        public static readonly TestFile SourceWordProtected = new TestFile("source_protected.docx", "source_files\\word\\", "1231");
        #endregion

        #endregion

        #region Target

        #region Not protected files
        public static readonly TestFile TargetCell = new TestFile("target.xlsx", "target_files\\cell\\");
        public static readonly TestFile TargetDiagram = new TestFile("target.vsdx", "target_files\\diagram\\");
        public static readonly TestFile TargetEmail = new TestFile("target.eml", "target_files\\email\\");
        public static readonly TestFile TargetHtml = new TestFile("target.html", "target_files\\html\\");
        public static readonly TestFile TargetImage = new TestFile("target.png", "target_files\\image\\");
        public static readonly TestFile TargetNote = new TestFile("target.one", "target_files\\note\\");
        public static readonly TestFile TargetPdf = new TestFile("target.pdf", "target_files\\pdf\\");
        public static readonly TestFile TargetSlide = new TestFile("target.pptx", "target_files\\slide\\");
        public static readonly TestFile TargetText = new TestFile("target.txt", "target_files\\text\\");
        public static readonly TestFile TargetWord = new TestFile("target.docx", "target_files\\word\\");
        #endregion

        #region Protected files
        public static readonly TestFile TargetCellProtected = new TestFile("target_protected.xlsx", "target_files\\cell\\", "1471");
        public static readonly TestFile TargetNoteProtected = new TestFile("target_protected.one", "target_files\\note\\", "123");
        public static readonly TestFile TargetPdfProtected = new TestFile("target_protected.pdf", "target_files\\pdf\\", "0987654");
        public static readonly TestFile TargetSlideProtected = new TestFile("target_protected.pptx", "target_files\\slide\\", "1471");
        public static readonly TestFile TargetWordProtected = new TestFile("target_protected.docx", "target_files\\word\\", "5784");
        #endregion

        #region Additional files
        public static readonly TestFile TargetSlide1 = new TestFile("target_1.pptx", "target_files\\slide\\");
        public static readonly TestFile TargetSlide2 = new TestFile("target_2.pptx", "target_files\\slide\\");
        public static readonly TestFile TargetSlide1Protected = new TestFile("target_1_protected.pptx", "target_files\\slide\\", "1471");
        public static readonly TestFile TargetSlide2Protected = new TestFile("target_2_protected.pptx", "target_files\\slide\\", "1471");
        public static readonly TestFile TargetWord1 = new TestFile("target_1.docx", "target_files\\word\\");
        public static readonly TestFile TargetWord2 = new TestFile("target_2.docx", "target_files\\word\\");
        public static readonly TestFile TargetWord1Protected = new TestFile("target_1_protected.docx", "target_files\\word\\", "5784");
        public static readonly TestFile TargetWord2Protected = new TestFile("target_2_protected.docx", "target_files\\word\\", "5784");
        #endregion

        #endregion

        public static readonly TestFile NotExist = new TestFile("NotExist.docx", "some-folder\\");

        public static IEnumerable<TestFile> TestFilesList
        {
            get
            {
                yield return SourceCell;
                yield return SourceDiagram;
                yield return SourceEmail;
                yield return SourceHtml;
                yield return SourceImage;
                yield return SourceNote;
                yield return SourcePdf;
                yield return SourceSlide;
                yield return SourceText;
                yield return SourceWord;
                yield return SourceWithRevs;
                yield return SourceCellProtected;
                yield return SourceNoteProtected;
                yield return SourcePdfProtected;
                yield return SourceSlideProtected;
                yield return SourceWordProtected;
                yield return TargetCell;
                yield return TargetDiagram;
                yield return TargetEmail;
                yield return TargetHtml;
                yield return TargetImage;
                yield return TargetNote;
                yield return TargetPdf;
                yield return TargetSlide;
                yield return TargetText;
                yield return TargetWord;
                yield return TargetCellProtected;
                yield return TargetNoteProtected;
                yield return TargetPdfProtected;
                yield return TargetSlideProtected;
                yield return TargetWordProtected;
                yield return TargetSlide1;
                yield return TargetSlide2;
                yield return TargetSlide1Protected;
                yield return TargetSlide2Protected;
                yield return TargetWord1;
                yield return TargetWord2;
                yield return TargetWord1Protected;
                yield return TargetWord2Protected;
            }
        }
    }
}
