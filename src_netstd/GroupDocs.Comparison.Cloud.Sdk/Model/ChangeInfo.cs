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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = GroupDocs.Comparison.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Comparison.Cloud.Sdk.Model
{
    /// <summary>
    /// ChangeInfo Object fields
    /// </summary>
    [DataContract]
    public partial class ChangeInfo
    {
        /// <summary>
        /// Id of change
        /// </summary>
        /// <value>Id of change</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Action (accept or reject). This field shows comparison what to do with this change
        /// </summary>
        /// <value>Action (accept or reject). This field shows comparison what to do with this change</value>
        [DataMember(Name="ComparisonAction", EmitDefaultValue=false)]
        public string ComparisonAction { get; set; }

        /// <summary>
        /// Type of change (Inserted, Deleted or StyleChanged)
        /// </summary>
        /// <value>Type of change (Inserted, Deleted or StyleChanged)</value>
        [DataMember(Name="ComparisonTypeChanged", EmitDefaultValue=false)]
        public string ComparisonTypeChanged { get; set; }

        /// <summary>
        /// Text of changed element
        /// </summary>
        /// <value>Text of changed element</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Array of authors who made this change (used for multi comparison)
        /// </summary>
        /// <value>Array of authors who made this change (used for multi comparison)</value>
        [DataMember(Name="Authors", EmitDefaultValue=false)]
        public List<string> Authors { get; set; }

        /// <summary>
        /// Array of style changes
        /// </summary>
        /// <value>Array of style changes</value>
        [DataMember(Name="StyleChangeInfo", EmitDefaultValue=false)]
        public List<StyleChangeInfo> StyleChangeInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ComparisonAction: ").Append(ComparisonAction).Append("\n");
            sb.Append("  ComparisonTypeChanged: ").Append(ComparisonTypeChanged).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  StyleChangeInfo: ").Append(StyleChangeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
