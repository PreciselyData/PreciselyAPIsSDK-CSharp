/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.precisely.apis.Client.OpenAPIDateConverter;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// MetadataResponse
    /// </summary>
    [DataContract]
    public partial class MetadataResponse :  IEquatable<MetadataResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResponse" /> class.
        /// </summary>
        /// <param name="sic">sic.</param>
        /// <param name="category">category.</param>
        public MetadataResponse(List<SicMetadata> sic = default(List<SicMetadata>), List<CategoryMetadata> category = default(List<CategoryMetadata>))
        {
            this.Sic = sic;
            this.Category = category;
        }

        /// <summary>
        /// Gets or Sets Sic
        /// </summary>
        [DataMember(Name="sic", EmitDefaultValue=false)]
        public List<SicMetadata> Sic { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public List<CategoryMetadata> Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataResponse {\n");
            sb.Append("  Sic: ").Append(Sic).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetadataResponse);
        }

        /// <summary>
        /// Returns true if MetadataResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sic == input.Sic ||
                    this.Sic != null &&
                    input.Sic != null &&
                    this.Sic.SequenceEqual(input.Sic)
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category != null &&
                    input.Category != null &&
                    this.Category.SequenceEqual(input.Category)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Sic != null)
                    hashCode = hashCode * 59 + this.Sic.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
