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
    /// FireRiskResponse
    /// </summary>
    [DataContract]
    public partial class FireRiskResponse :  IEquatable<FireRiskResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireRiskResponse" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="state">state.</param>
        /// <param name="fireShed">fireShed.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        public FireRiskResponse(string objectId = default(string), State state = default(State), FireShed fireShed = default(FireShed), RiskAddress matchedAddress = default(RiskAddress))
        {
            this.ObjectId = objectId;
            this.State = state;
            this.FireShed = fireShed;
            this.MatchedAddress = matchedAddress;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public State State { get; set; }

        /// <summary>
        /// Gets or Sets FireShed
        /// </summary>
        [DataMember(Name="fireShed", EmitDefaultValue=false)]
        public FireShed FireShed { get; set; }

        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public RiskAddress MatchedAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireRiskResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FireShed: ").Append(FireShed).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
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
            return this.Equals(input as FireRiskResponse);
        }

        /// <summary>
        /// Returns true if FireRiskResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FireRiskResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireRiskResponse input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.FireShed == input.FireShed ||
                    (this.FireShed != null &&
                    this.FireShed.Equals(input.FireShed))
                ) && 
                (
                    this.MatchedAddress == input.MatchedAddress ||
                    (this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(input.MatchedAddress))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.FireShed != null)
                    hashCode = hashCode * 59 + this.FireShed.GetHashCode();
                if (this.MatchedAddress != null)
                    hashCode = hashCode * 59 + this.MatchedAddress.GetHashCode();
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
