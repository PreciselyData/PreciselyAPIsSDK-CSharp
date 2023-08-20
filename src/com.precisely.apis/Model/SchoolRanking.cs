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
    /// SchoolRanking
    /// </summary>
    [DataContract]
    public partial class SchoolRanking :  IEquatable<SchoolRanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolRanking" /> class.
        /// </summary>
        /// <param name="current">current.</param>
        /// <param name="rankYear">rankYear.</param>
        /// <param name="stateRank">stateRank.</param>
        /// <param name="numberOfSchools">numberOfSchools.</param>
        /// <param name="avgMathScore">avgMathScore.</param>
        /// <param name="avgReadingScore">avgReadingScore.</param>
        /// <param name="statePercentileScore">statePercentileScore.</param>
        public SchoolRanking(string current = default(string), string rankYear = default(string), string stateRank = default(string), string numberOfSchools = default(string), string avgMathScore = default(string), string avgReadingScore = default(string), string statePercentileScore = default(string))
        {
            this.Current = current;
            this.RankYear = rankYear;
            this.StateRank = stateRank;
            this.NumberOfSchools = numberOfSchools;
            this.AvgMathScore = avgMathScore;
            this.AvgReadingScore = avgReadingScore;
            this.StatePercentileScore = statePercentileScore;
        }

        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public string Current { get; set; }

        /// <summary>
        /// Gets or Sets RankYear
        /// </summary>
        [DataMember(Name="rankYear", EmitDefaultValue=false)]
        public string RankYear { get; set; }

        /// <summary>
        /// Gets or Sets StateRank
        /// </summary>
        [DataMember(Name="stateRank", EmitDefaultValue=false)]
        public string StateRank { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfSchools
        /// </summary>
        [DataMember(Name="numberOfSchools", EmitDefaultValue=false)]
        public string NumberOfSchools { get; set; }

        /// <summary>
        /// Gets or Sets AvgMathScore
        /// </summary>
        [DataMember(Name="avgMathScore", EmitDefaultValue=false)]
        public string AvgMathScore { get; set; }

        /// <summary>
        /// Gets or Sets AvgReadingScore
        /// </summary>
        [DataMember(Name="avgReadingScore", EmitDefaultValue=false)]
        public string AvgReadingScore { get; set; }

        /// <summary>
        /// Gets or Sets StatePercentileScore
        /// </summary>
        [DataMember(Name="statePercentileScore", EmitDefaultValue=false)]
        public string StatePercentileScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolRanking {\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  RankYear: ").Append(RankYear).Append("\n");
            sb.Append("  StateRank: ").Append(StateRank).Append("\n");
            sb.Append("  NumberOfSchools: ").Append(NumberOfSchools).Append("\n");
            sb.Append("  AvgMathScore: ").Append(AvgMathScore).Append("\n");
            sb.Append("  AvgReadingScore: ").Append(AvgReadingScore).Append("\n");
            sb.Append("  StatePercentileScore: ").Append(StatePercentileScore).Append("\n");
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
            return this.Equals(input as SchoolRanking);
        }

        /// <summary>
        /// Returns true if SchoolRanking instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolRanking input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Current == input.Current ||
                    (this.Current != null &&
                    this.Current.Equals(input.Current))
                ) && 
                (
                    this.RankYear == input.RankYear ||
                    (this.RankYear != null &&
                    this.RankYear.Equals(input.RankYear))
                ) && 
                (
                    this.StateRank == input.StateRank ||
                    (this.StateRank != null &&
                    this.StateRank.Equals(input.StateRank))
                ) && 
                (
                    this.NumberOfSchools == input.NumberOfSchools ||
                    (this.NumberOfSchools != null &&
                    this.NumberOfSchools.Equals(input.NumberOfSchools))
                ) && 
                (
                    this.AvgMathScore == input.AvgMathScore ||
                    (this.AvgMathScore != null &&
                    this.AvgMathScore.Equals(input.AvgMathScore))
                ) && 
                (
                    this.AvgReadingScore == input.AvgReadingScore ||
                    (this.AvgReadingScore != null &&
                    this.AvgReadingScore.Equals(input.AvgReadingScore))
                ) && 
                (
                    this.StatePercentileScore == input.StatePercentileScore ||
                    (this.StatePercentileScore != null &&
                    this.StatePercentileScore.Equals(input.StatePercentileScore))
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
                if (this.Current != null)
                    hashCode = hashCode * 59 + this.Current.GetHashCode();
                if (this.RankYear != null)
                    hashCode = hashCode * 59 + this.RankYear.GetHashCode();
                if (this.StateRank != null)
                    hashCode = hashCode * 59 + this.StateRank.GetHashCode();
                if (this.NumberOfSchools != null)
                    hashCode = hashCode * 59 + this.NumberOfSchools.GetHashCode();
                if (this.AvgMathScore != null)
                    hashCode = hashCode * 59 + this.AvgMathScore.GetHashCode();
                if (this.AvgReadingScore != null)
                    hashCode = hashCode * 59 + this.AvgReadingScore.GetHashCode();
                if (this.StatePercentileScore != null)
                    hashCode = hashCode * 59 + this.StatePercentileScore.GetHashCode();
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
