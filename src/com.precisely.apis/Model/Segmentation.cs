/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.0.0
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
    /// Segmentation
    /// </summary>
    [DataContract]
    public partial class Segmentation :  IEquatable<Segmentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Segmentation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentation" /> class.
        /// </summary>
        /// <param name="boundaries">boundaries (required).</param>
        /// <param name="themes">themes (required).</param>
        public Segmentation(Boundaries boundaries = default(Boundaries), SegmentationThemes themes = default(SegmentationThemes))
        {
            // to ensure "boundaries" is required (not null)
            if (boundaries == null)
            {
                throw new InvalidDataException("boundaries is a required property for Segmentation and cannot be null");
            }
            else
            {
                this.Boundaries = boundaries;
            }

            // to ensure "themes" is required (not null)
            if (themes == null)
            {
                throw new InvalidDataException("themes is a required property for Segmentation and cannot be null");
            }
            else
            {
                this.Themes = themes;
            }

        }

        /// <summary>
        /// Gets or Sets Boundaries
        /// </summary>
        [DataMember(Name="boundaries", EmitDefaultValue=true)]
        public Boundaries Boundaries { get; set; }

        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name="themes", EmitDefaultValue=true)]
        public SegmentationThemes Themes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Segmentation {\n");
            sb.Append("  Boundaries: ").Append(Boundaries).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
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
            return this.Equals(input as Segmentation);
        }

        /// <summary>
        /// Returns true if Segmentation instances are equal
        /// </summary>
        /// <param name="input">Instance of Segmentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Segmentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Boundaries == input.Boundaries ||
                    (this.Boundaries != null &&
                    this.Boundaries.Equals(input.Boundaries))
                ) && 
                (
                    this.Themes == input.Themes ||
                    (this.Themes != null &&
                    this.Themes.Equals(input.Themes))
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
                if (this.Boundaries != null)
                    hashCode = hashCode * 59 + this.Boundaries.GetHashCode();
                if (this.Themes != null)
                    hashCode = hashCode * 59 + this.Themes.GetHashCode();
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
