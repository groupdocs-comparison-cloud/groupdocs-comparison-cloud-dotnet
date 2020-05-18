// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ChangeInfo.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
    /// ChangeInfo Object fields
    /// </summary>  
    public class ChangeInfo 
    {                       
        /// <summary>
        /// Id of change
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// Action (accept or reject). This field shows comparison what to do with this change
        /// </summary>  
        public string ComparisonAction { get; set; }

        /// <summary>
        /// Type of change (Inserted, Deleted or StyleChanged)
        /// </summary>  
        public string ComparisonTypeChanged { get; set; }

        /// <summary>
        /// Text of changed element
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Array of authors who made this change (used for multi comparison)
        /// </summary>  
        public List<string> Authors { get; set; }

        /// <summary>
        /// Array of style changes
        /// </summary>  
        public List<StyleChangeInfo> StyleChangeInfo { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ChangeInfo {\n");
          sb.Append("  Id: ").Append(this.Id).Append("\n");
          sb.Append("  ComparisonAction: ").Append(this.ComparisonAction).Append("\n");
          sb.Append("  ComparisonTypeChanged: ").Append(this.ComparisonTypeChanged).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Authors: ").Append(this.Authors).Append("\n");
          sb.Append("  StyleChangeInfo: ").Append(this.StyleChangeInfo).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
