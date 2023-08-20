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
    /// Demographics
    /// </summary>
    [DataContract]
    public partial class Demographics :  IEquatable<Demographics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Demographics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Demographics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Demographics" /> class.
        /// </summary>
        /// <param name="boundaries">boundaries (required).</param>
        /// <param name="themes">themes (required).</param>
        /// <param name="boundaryThemes">boundaryThemes.</param>
        public Demographics(Boundaries boundaries = default(Boundaries), DemographicsThemesV2 themes = default(DemographicsThemesV2), List<DemographicsThemesV2> boundaryThemes = default(List<DemographicsThemesV2>))
        {
            // to ensure "boundaries" is required (not null)
            if (boundaries == null)
            {
                throw new InvalidDataException("boundaries is a required property for Demographics and cannot be null");
            }
            else
            {
                this.Boundaries = boundaries;
            }

            // to ensure "themes" is required (not null)
            if (themes == null)
            {
                throw new InvalidDataException("themes is a required property for Demographics and cannot be null");
            }
            else
            {
                this.Themes = themes;
            }

            this.BoundaryThemes = boundaryThemes;
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
        public DemographicsThemesV2 Themes { get; set; }

        /// <summary>
        /// Gets or Sets BoundaryThemes
        /// </summary>
        [DataMember(Name="boundaryThemes", EmitDefaultValue=false)]
        public List<DemographicsThemesV2> BoundaryThemes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Demographics {\n");
            sb.Append("  Boundaries: ").Append(Boundaries).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  BoundaryThemes: ").Append(BoundaryThemes).Append("\n");
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
            return this.Equals(input as Demographics);
        }

        /// <summary>
        /// Returns true if Demographics instances are equal
        /// </summary>
        /// <param name="input">Instance of Demographics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Demographics input)
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
                ) && 
                (
                    this.BoundaryThemes == input.BoundaryThemes ||
                    this.BoundaryThemes != null &&
                    input.BoundaryThemes != null &&
                    this.BoundaryThemes.SequenceEqual(input.BoundaryThemes)
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
                if (this.BoundaryThemes != null)
                    hashCode = hashCode * 59 + this.BoundaryThemes.GetHashCode();
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
