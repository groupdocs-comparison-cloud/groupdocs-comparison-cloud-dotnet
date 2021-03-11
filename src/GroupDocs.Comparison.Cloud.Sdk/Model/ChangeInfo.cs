// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ChangeInfo.cs">
//  Copyright (c) 2003-2021 Aspose Pty Ltd
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
        /// Action (accept or reject). This field shows comparison what to do with this change
        /// </summary>
        /// <value>Action (accept or reject). This field shows comparison what to do with this change</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComparisonActionEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Accept for "Accept"
            /// </summary>            
            Accept,
            
            /// <summary>
            /// Enum Reject for "Reject"
            /// </summary>            
            Reject            
        }

        /// <summary>
        /// Type of change (Inserted, Deleted or StyleChanged)
        /// </summary>
        /// <value>Type of change (Inserted, Deleted or StyleChanged)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Modified for "Modified"
            /// </summary>            
            Modified,
            
            /// <summary>
            /// Enum Inserted for "Inserted"
            /// </summary>            
            Inserted,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>            
            Deleted,
            
            /// <summary>
            /// Enum Added for "Added"
            /// </summary>            
            Added,
            
            /// <summary>
            /// Enum NotModified for "NotModified"
            /// </summary>            
            NotModified,
            
            /// <summary>
            /// Enum StyleChanged for "StyleChanged"
            /// </summary>            
            StyleChanged,
            
            /// <summary>
            /// Enum Resized for "Resized"
            /// </summary>            
            Resized,
            
            /// <summary>
            /// Enum Moved for "Moved"
            /// </summary>            
            Moved,
            
            /// <summary>
            /// Enum MovedAndResized for "MovedAndResized"
            /// </summary>            
            MovedAndResized,
            
            /// <summary>
            /// Enum ShiftedAndResized for "ShiftedAndResized"
            /// </summary>            
            ShiftedAndResized            
        }

        /// <summary>
        /// Action (accept or reject). This field shows comparison what to do with this change
        /// </summary>
        public ComparisonActionEnum? ComparisonAction { get; set; }

        /// <summary>
        /// Type of change (Inserted, Deleted or StyleChanged)
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Id of change
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// Text of changed element
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Changed text of target doc
        /// </summary>  
        public string TargetText { get; set; }

        /// <summary>
        /// Array of authors who made this change (used for multi comparison)
        /// </summary>  
        public List<string> Authors { get; set; }

        /// <summary>
        /// Array of style changes
        /// </summary>  
        public List<StyleChangeInfo> StyleChangeInfo { get; set; }

        /// <summary>
        /// Page where current change is placed
        /// </summary>  
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// Coordinates of changed element
        /// </summary>  
        public Rectangle Box { get; set; }

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
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  TargetText: ").Append(this.TargetText).Append("\n");
          sb.Append("  Authors: ").Append(this.Authors).Append("\n");
          sb.Append("  StyleChangeInfo: ").Append(this.StyleChangeInfo).Append("\n");
          sb.Append("  PageInfo: ").Append(this.PageInfo).Append("\n");
          sb.Append("  Box: ").Append(this.Box).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
