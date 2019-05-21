// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Settings.cs">
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
    /// Defines comparison process additional settings 
    /// </summary>
    [DataContract]
    public partial class Settings
    {
        /// <summary>
        /// Indicates whether to add summary page to resultant document or not
        /// </summary>
        /// <value>Indicates whether to add summary page to resultant document or not</value>
        [DataMember(Name="GenerateSummaryPage", EmitDefaultValue=false)]
        public bool? GenerateSummaryPage { get; set; }

        /// <summary>
        /// Indicates whether to show deleted components in resultant document or not
        /// </summary>
        /// <value>Indicates whether to show deleted components in resultant document or not</value>
        [DataMember(Name="ShowDeletedContent", EmitDefaultValue=false)]
        public bool? ShowDeletedContent { get; set; }

        /// <summary>
        /// Indicates whether to detect style changes or not
        /// </summary>
        /// <value>Indicates whether to detect style changes or not</value>
        [DataMember(Name="StyleChangeDetection", EmitDefaultValue=false)]
        public bool? StyleChangeDetection { get; set; }

        /// <summary>
        /// Style for inserted components
        /// </summary>
        /// <value>Style for inserted components</value>
        [DataMember(Name="InsertedItemsStyle", EmitDefaultValue=false)]
        public ItemsStyle InsertedItemsStyle { get; set; }

        /// <summary>
        /// Style for deleted components
        /// </summary>
        /// <value>Style for deleted components</value>
        [DataMember(Name="DeletedItemsStyle", EmitDefaultValue=false)]
        public ItemsStyle DeletedItemsStyle { get; set; }

        /// <summary>
        /// Style for components with changed style
        /// </summary>
        /// <value>Style for components with changed style</value>
        [DataMember(Name="StyleChangedItemsStyle", EmitDefaultValue=false)]
        public ItemsStyle StyleChangedItemsStyle { get; set; }

        /// <summary>
        /// An array of delimiters to split text into words
        /// </summary>
        /// <value>An array of delimiters to split text into words</value>
        [DataMember(Name="WordsSeparatorChars", EmitDefaultValue=false)]
        public List<string> WordsSeparatorChars { get; set; }

        /// <summary>
        /// Gets of sets the comparison detalisation level 
        /// </summary>
        /// <value>Gets of sets the comparison detalisation level </value>
        [DataMember(Name="DetailLevel", EmitDefaultValue=false)]
        public string DetailLevel { get; set; }

        /// <summary>
        /// Indicates whether to use frames for shapes in Word Processing and for rectangles in Image documents
        /// </summary>
        /// <value>Indicates whether to use frames for shapes in Word Processing and for rectangles in Image documents</value>
        [DataMember(Name="UseFramesForDelInsElements", EmitDefaultValue=false)]
        public bool? UseFramesForDelInsElements { get; set; }

        /// <summary>
        /// Indicates whether to calculate coordinates for changed components
        /// </summary>
        /// <value>Indicates whether to calculate coordinates for changed components</value>
        [DataMember(Name="CalculateComponentCoordinates", EmitDefaultValue=false)]
        public bool? CalculateComponentCoordinates { get; set; }

        /// <summary>
        /// Indicates whether to accept inserted/deleted styles for all children of inserted/deleted components
        /// </summary>
        /// <value>Indicates whether to accept inserted/deleted styles for all children of inserted/deleted components</value>
        [DataMember(Name="MarkDeletedInsertedContentDeep", EmitDefaultValue=false)]
        public bool? MarkDeletedInsertedContentDeep { get; set; }

        /// <summary>
        /// Gets or sets type of metadata to clone
        /// </summary>
        /// <value>Gets or sets type of metadata to clone</value>
        [DataMember(Name="CloneMetadata", EmitDefaultValue=false)]
        public string CloneMetadata { get; set; }

        /// <summary>
        /// Gets or sets user metadata
        /// </summary>
        /// <value>Gets or sets user metadata</value>
        [DataMember(Name="MetaData", EmitDefaultValue=false)]
        public Metadata MetaData { get; set; }

        /// <summary>
        /// Gets or sets type of password saving
        /// </summary>
        /// <value>Gets or sets type of password saving</value>
        [DataMember(Name="PasswordSaveOption", EmitDefaultValue=false)]
        public string PasswordSaveOption { get; set; }

        /// <summary>
        /// Gets or sets user password to resultant document
        /// </summary>
        /// <value>Gets or sets user password to resultant document</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets master for Diagram document
        /// </summary>
        /// <value>Gets or sets master for Diagram document</value>
        [DataMember(Name="DiagramMasterSetting", EmitDefaultValue=false)]
        public DiagramMasterSetting DiagramMasterSetting { get; set; }

        /// <summary>
        /// Gets or sets original document size when picture is compared with other different formats
        /// </summary>
        /// <value>Gets or sets original document size when picture is compared with other different formats</value>
        [DataMember(Name="OriginalSize", EmitDefaultValue=false)]
        public OriginalSize OriginalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Settings {\n");
            sb.Append("  GenerateSummaryPage: ").Append(GenerateSummaryPage).Append("\n");
            sb.Append("  ShowDeletedContent: ").Append(ShowDeletedContent).Append("\n");
            sb.Append("  StyleChangeDetection: ").Append(StyleChangeDetection).Append("\n");
            sb.Append("  InsertedItemsStyle: ").Append(InsertedItemsStyle).Append("\n");
            sb.Append("  DeletedItemsStyle: ").Append(DeletedItemsStyle).Append("\n");
            sb.Append("  StyleChangedItemsStyle: ").Append(StyleChangedItemsStyle).Append("\n");
            sb.Append("  WordsSeparatorChars: ").Append(WordsSeparatorChars).Append("\n");
            sb.Append("  DetailLevel: ").Append(DetailLevel).Append("\n");
            sb.Append("  UseFramesForDelInsElements: ").Append(UseFramesForDelInsElements).Append("\n");
            sb.Append("  CalculateComponentCoordinates: ").Append(CalculateComponentCoordinates).Append("\n");
            sb.Append("  MarkDeletedInsertedContentDeep: ").Append(MarkDeletedInsertedContentDeep).Append("\n");
            sb.Append("  CloneMetadata: ").Append(CloneMetadata).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  PasswordSaveOption: ").Append(PasswordSaveOption).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DiagramMasterSetting: ").Append(DiagramMasterSetting).Append("\n");
            sb.Append("  OriginalSize: ").Append(OriginalSize).Append("\n");
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
