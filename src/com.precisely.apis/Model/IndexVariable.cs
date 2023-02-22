/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 14.0.0
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
    /// IndexVariable
    /// </summary>
    [DataContract]
    public partial class IndexVariable :  IEquatable<IndexVariable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexVariable" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="score">score.</param>
        /// <param name="category">category.</param>
        /// <param name="percentile">percentile.</param>
        /// <param name="stateScore">stateScore.</param>
        public IndexVariable(string name = default(string), string score = default(string), string category = default(string), string percentile = default(string), string stateScore = default(string))
        {
            this.Name = name;
            this.Score = score;
            this.Category = category;
            this.Percentile = percentile;
            this.StateScore = stateScore;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public string Score { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Percentile
        /// </summary>
        [DataMember(Name="percentile", EmitDefaultValue=false)]
        public string Percentile { get; set; }

        /// <summary>
        /// Gets or Sets StateScore
        /// </summary>
        [DataMember(Name="stateScore", EmitDefaultValue=false)]
        public string StateScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexVariable {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Percentile: ").Append(Percentile).Append("\n");
            sb.Append("  StateScore: ").Append(StateScore).Append("\n");
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
            return this.Equals(input as IndexVariable);
        }

        /// <summary>
        /// Returns true if IndexVariable instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexVariable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexVariable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Percentile == input.Percentile ||
                    (this.Percentile != null &&
                    this.Percentile.Equals(input.Percentile))
                ) && 
                (
                    this.StateScore == input.StateScore ||
                    (this.StateScore != null &&
                    this.StateScore.Equals(input.StateScore))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Percentile != null)
                    hashCode = hashCode * 59 + this.Percentile.GetHashCode();
                if (this.StateScore != null)
                    hashCode = hashCode * 59 + this.StateScore.GetHashCode();
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
