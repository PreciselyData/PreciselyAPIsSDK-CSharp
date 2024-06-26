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
    /// FloodRiskResponse
    /// </summary>
    [DataContract]
    public partial class FloodRiskResponse :  IEquatable<FloodRiskResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloodRiskResponse" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="state">state.</param>
        /// <param name="floodZone">floodZone.</param>
        /// <param name="community">community.</param>
        /// <param name="boundary">boundary.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        public FloodRiskResponse(string objectId = default(string), State state = default(State), FloodZone floodZone = default(FloodZone), Community community = default(Community), CrimeBoundary boundary = default(CrimeBoundary), RiskAddress matchedAddress = default(RiskAddress))
        {
            this.ObjectId = objectId;
            this.State = state;
            this.FloodZone = floodZone;
            this.Community = community;
            this.Boundary = boundary;
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
        /// Gets or Sets FloodZone
        /// </summary>
        [DataMember(Name="floodZone", EmitDefaultValue=false)]
        public FloodZone FloodZone { get; set; }

        /// <summary>
        /// Gets or Sets Community
        /// </summary>
        [DataMember(Name="community", EmitDefaultValue=false)]
        public Community Community { get; set; }

        /// <summary>
        /// Gets or Sets Boundary
        /// </summary>
        [DataMember(Name="boundary", EmitDefaultValue=false)]
        public CrimeBoundary Boundary { get; set; }

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
            sb.Append("class FloodRiskResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FloodZone: ").Append(FloodZone).Append("\n");
            sb.Append("  Community: ").Append(Community).Append("\n");
            sb.Append("  Boundary: ").Append(Boundary).Append("\n");
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
            return this.Equals(input as FloodRiskResponse);
        }

        /// <summary>
        /// Returns true if FloodRiskResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FloodRiskResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloodRiskResponse input)
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
                    this.FloodZone == input.FloodZone ||
                    (this.FloodZone != null &&
                    this.FloodZone.Equals(input.FloodZone))
                ) && 
                (
                    this.Community == input.Community ||
                    (this.Community != null &&
                    this.Community.Equals(input.Community))
                ) && 
                (
                    this.Boundary == input.Boundary ||
                    (this.Boundary != null &&
                    this.Boundary.Equals(input.Boundary))
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
                if (this.FloodZone != null)
                    hashCode = hashCode * 59 + this.FloodZone.GetHashCode();
                if (this.Community != null)
                    hashCode = hashCode * 59 + this.Community.GetHashCode();
                if (this.Boundary != null)
                    hashCode = hashCode * 59 + this.Boundary.GetHashCode();
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
