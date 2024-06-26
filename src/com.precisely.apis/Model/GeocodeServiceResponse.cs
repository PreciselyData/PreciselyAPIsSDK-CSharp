/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.1.0
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
    /// GeocodeServiceResponse
    /// </summary>
    [DataContract]
    public partial class GeocodeServiceResponse :  IEquatable<GeocodeServiceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeServiceResponse" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="totalPossibleCandidates">totalPossibleCandidates.</param>
        /// <param name="totalMatches">totalMatches.</param>
        /// <param name="candidates">candidates.</param>
        public GeocodeServiceResponse(string objectId = default(string), int totalPossibleCandidates = default(int), int totalMatches = default(int), List<Candidate> candidates = default(List<Candidate>))
        {
            this.ObjectId = objectId;
            this.TotalPossibleCandidates = totalPossibleCandidates;
            this.TotalMatches = totalMatches;
            this.Candidates = candidates;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets TotalPossibleCandidates
        /// </summary>
        [DataMember(Name="totalPossibleCandidates", EmitDefaultValue=false)]
        public int TotalPossibleCandidates { get; set; }

        /// <summary>
        /// Gets or Sets TotalMatches
        /// </summary>
        [DataMember(Name="totalMatches", EmitDefaultValue=false)]
        public int TotalMatches { get; set; }

        /// <summary>
        /// Gets or Sets Candidates
        /// </summary>
        [DataMember(Name="candidates", EmitDefaultValue=false)]
        public List<Candidate> Candidates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodeServiceResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  TotalPossibleCandidates: ").Append(TotalPossibleCandidates).Append("\n");
            sb.Append("  TotalMatches: ").Append(TotalMatches).Append("\n");
            sb.Append("  Candidates: ").Append(Candidates).Append("\n");
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
            return this.Equals(input as GeocodeServiceResponse);
        }

        /// <summary>
        /// Returns true if GeocodeServiceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GeocodeServiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodeServiceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.TotalPossibleCandidates == input.TotalPossibleCandidates ||
                    (this.TotalPossibleCandidates != null &&
                    this.TotalPossibleCandidates.Equals(input.TotalPossibleCandidates))
                ) && 
                (
                    this.TotalMatches == input.TotalMatches ||
                    (this.TotalMatches != null &&
                    this.TotalMatches.Equals(input.TotalMatches))
                ) && 
                (
                    this.Candidates == input.Candidates ||
                    this.Candidates != null &&
                    input.Candidates != null &&
                    this.Candidates.SequenceEqual(input.Candidates)
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.TotalPossibleCandidates != null)
                    hashCode = hashCode * 59 + this.TotalPossibleCandidates.GetHashCode();
                if (this.TotalMatches != null)
                    hashCode = hashCode * 59 + this.TotalMatches.GetHashCode();
                if (this.Candidates != null)
                    hashCode = hashCode * 59 + this.Candidates.GetHashCode();
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
