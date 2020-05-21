// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ItemsStyle.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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

namespace GroupDocs.Comparison.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// ItemsStyle Object fields
    /// </summary>  
    public class ItemsStyle 
    {                       
        /// <summary>
        /// Font color for changed components
        /// </summary>  
        public string FontColor { get; set; }

        /// <summary>
        /// Highlight color for changed components
        /// </summary>  
        public string HighlightColor { get; set; }

        /// <summary>
        /// Start tag for changed components
        /// </summary>  
        public string BeginSeparatorString { get; set; }

        /// <summary>
        /// End tag for changed components
        /// </summary>  
        public string EndSeparatorString { get; set; }

        /// <summary>
        /// Bold style for changed components
        /// </summary>  
        public bool? Bold { get; set; }

        /// <summary>
        /// Italic style for changed components
        /// </summary>  
        public bool? Italic { get; set; }

        /// <summary>
        /// Strike through style for changed components
        /// </summary>  
        public bool? StrikeThrough { get; set; }

        /// <summary>
        /// Underline style for changed components
        /// </summary>  
        public bool? Underline { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ItemsStyle {\n");
          sb.Append("  FontColor: ").Append(this.FontColor).Append("\n");
          sb.Append("  HighlightColor: ").Append(this.HighlightColor).Append("\n");
          sb.Append("  BeginSeparatorString: ").Append(this.BeginSeparatorString).Append("\n");
          sb.Append("  EndSeparatorString: ").Append(this.EndSeparatorString).Append("\n");
          sb.Append("  Bold: ").Append(this.Bold).Append("\n");
          sb.Append("  Italic: ").Append(this.Italic).Append("\n");
          sb.Append("  StrikeThrough: ").Append(this.StrikeThrough).Append("\n");
          sb.Append("  Underline: ").Append(this.Underline).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
