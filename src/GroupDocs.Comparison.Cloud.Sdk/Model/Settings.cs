// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Settings.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    /// Defines comparison process additional settings 
    /// </summary>  
    public class Settings 
    {                       
        /// <summary>
        /// Gets of sets the comparison details level 
        /// </summary>
        /// <value>Gets of sets the comparison details level </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DetailsLevelEnum
        { 
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>            
            Low,
            
            /// <summary>
            /// Enum Middle for "Middle"
            /// </summary>            
            Middle,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>            
            High            
        }

        /// <summary>
        /// Gets or sets type of metadata to clone
        /// </summary>
        /// <value>Gets or sets type of metadata to clone</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CloneMetadataEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum Source for "Source"
            /// </summary>            
            Source,
            
            /// <summary>
            /// Enum Target for "Target"
            /// </summary>            
            Target,
            
            /// <summary>
            /// Enum FileAuthor for "FileAuthor"
            /// </summary>            
            FileAuthor            
        }

        /// <summary>
        /// Gets or sets type of password saving
        /// </summary>
        /// <value>Gets or sets type of password saving</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PasswordSaveOptionEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Source for "Source"
            /// </summary>            
            Source,
            
            /// <summary>
            /// Enum Target for "Target"
            /// </summary>            
            Target,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>            
            User            
        }

        /// <summary>
        /// Gets or sets the result document paper size
        /// </summary>
        /// <value>Gets or sets the result document paper size</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaperSizeEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum A0 for "A0"
            /// </summary>            
            A0,
            
            /// <summary>
            /// Enum A1 for "A1"
            /// </summary>            
            A1,
            
            /// <summary>
            /// Enum A2 for "A2"
            /// </summary>            
            A2,
            
            /// <summary>
            /// Enum A3 for "A3"
            /// </summary>            
            A3,
            
            /// <summary>
            /// Enum A4 for "A4"
            /// </summary>            
            A4,
            
            /// <summary>
            /// Enum A5 for "A5"
            /// </summary>            
            A5,
            
            /// <summary>
            /// Enum A6 for "A6"
            /// </summary>            
            A6,
            
            /// <summary>
            /// Enum A7 for "A7"
            /// </summary>            
            A7,
            
            /// <summary>
            /// Enum A8 for "A8"
            /// </summary>            
            A8            
        }

        /// <summary>
        /// Gets of sets the comparison details level 
        /// </summary>
        public DetailsLevelEnum? DetailsLevel { get; set; }

        /// <summary>
        /// Gets or sets type of metadata to clone
        /// </summary>
        public CloneMetadataEnum? CloneMetadata { get; set; }

        /// <summary>
        /// Gets or sets type of password saving
        /// </summary>
        public PasswordSaveOptionEnum? PasswordSaveOption { get; set; }

        /// <summary>
        /// Gets or sets the result document paper size
        /// </summary>
        public PaperSizeEnum? PaperSize { get; set; }

        /// <summary>
        /// Indicates whether to add summary page to resultant document or not
        /// </summary>  
        public bool? GenerateSummaryPage { get; set; }

        /// <summary>
        /// Indicates whether to show deleted components in resultant document or not
        /// </summary>  
        public bool? ShowDeletedContent { get; set; }

        /// <summary>
        /// Indicates whether to show inserted components in resultant document or not
        /// </summary>  
        public bool? ShowInsertedContent { get; set; }

        /// <summary>
        /// Indicates whether to detect style changes or not
        /// </summary>  
        public bool? StyleChangeDetection { get; set; }

        /// <summary>
        /// Style for inserted components
        /// </summary>  
        public ItemsStyle InsertedItemsStyle { get; set; }

        /// <summary>
        /// Style for deleted components
        /// </summary>  
        public ItemsStyle DeletedItemsStyle { get; set; }

        /// <summary>
        /// Style for components with changed style
        /// </summary>  
        public ItemsStyle ChangedItemsStyle { get; set; }

        /// <summary>
        /// An array of delimiters to split text into words
        /// </summary>  
        public List<string> WordsSeparatorChars { get; set; }

        /// <summary>
        /// Indicates whether to use frames for shapes in Word Processing and for rectangles in Image documents
        /// </summary>  
        public bool? UseFramesForDelInsElements { get; set; }

        /// <summary>
        /// Indicates whether to calculate coordinates for changed components
        /// </summary>  
        public bool? CalculateComponentCoordinates { get; set; }

        /// <summary>
        /// Indicates whether to use frames for shapes in Word Processing and for rectangles in Image documents
        /// </summary>  
        public bool? MarkChangedContent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to mark the children of the deleted or inserted element as deleted or inserted
        /// </summary>  
        public bool? MarkNestedContent { get; set; }

        /// <summary>
        /// Gets or sets user metadata
        /// </summary>  
        public Metadata MetaData { get; set; }

        /// <summary>
        /// Gets or sets user password to resultant document
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets master for Diagram document
        /// </summary>  
        public DiagramMasterSetting DiagramMasterSetting { get; set; }

        /// <summary>
        /// Gets or sets original document size when picture is compared with other different formats
        /// </summary>  
        public Size OriginalSize { get; set; }

        /// <summary>
        /// Control to turn on comparison of header/footer contents
        /// </summary>  
        public bool? HeaderFootersComparison { get; set; }

        /// <summary>
        /// Gets or sets a sensitivity of comparison. Default is 75
        /// </summary>  
        public int? SensitivityOfComparison { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Settings {\n");
          sb.Append("  GenerateSummaryPage: ").Append(this.GenerateSummaryPage).Append("\n");
          sb.Append("  ShowDeletedContent: ").Append(this.ShowDeletedContent).Append("\n");
          sb.Append("  ShowInsertedContent: ").Append(this.ShowInsertedContent).Append("\n");
          sb.Append("  StyleChangeDetection: ").Append(this.StyleChangeDetection).Append("\n");
          sb.Append("  InsertedItemsStyle: ").Append(this.InsertedItemsStyle).Append("\n");
          sb.Append("  DeletedItemsStyle: ").Append(this.DeletedItemsStyle).Append("\n");
          sb.Append("  ChangedItemsStyle: ").Append(this.ChangedItemsStyle).Append("\n");
          sb.Append("  WordsSeparatorChars: ").Append(this.WordsSeparatorChars).Append("\n");
          sb.Append("  DetailsLevel: ").Append(this.DetailsLevel).Append("\n");
          sb.Append("  UseFramesForDelInsElements: ").Append(this.UseFramesForDelInsElements).Append("\n");
          sb.Append("  CalculateComponentCoordinates: ").Append(this.CalculateComponentCoordinates).Append("\n");
          sb.Append("  MarkChangedContent: ").Append(this.MarkChangedContent).Append("\n");
          sb.Append("  MarkNestedContent: ").Append(this.MarkNestedContent).Append("\n");
          sb.Append("  CloneMetadata: ").Append(this.CloneMetadata).Append("\n");
          sb.Append("  MetaData: ").Append(this.MetaData).Append("\n");
          sb.Append("  PasswordSaveOption: ").Append(this.PasswordSaveOption).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  DiagramMasterSetting: ").Append(this.DiagramMasterSetting).Append("\n");
          sb.Append("  OriginalSize: ").Append(this.OriginalSize).Append("\n");
          sb.Append("  HeaderFootersComparison: ").Append(this.HeaderFootersComparison).Append("\n");
          sb.Append("  PaperSize: ").Append(this.PaperSize).Append("\n");
          sb.Append("  SensitivityOfComparison: ").Append(this.SensitivityOfComparison).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
