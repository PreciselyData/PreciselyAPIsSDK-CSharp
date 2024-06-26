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
    /// EarthquakeRiskResponse
    /// </summary>
    [DataContract]
    public partial class EarthquakeRiskResponse :  IEquatable<EarthquakeRiskResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarthquakeRiskResponse" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="riskLevel">riskLevel.</param>
        /// <param name="eventsCount">eventsCount.</param>
        /// <param name="grid">grid.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        public EarthquakeRiskResponse(string objectId = default(string), string riskLevel = default(string), EventsCount eventsCount = default(EventsCount), Grid grid = default(Grid), RiskAddress matchedAddress = default(RiskAddress))
        {
            this.ObjectId = objectId;
            this.RiskLevel = riskLevel;
            this.EventsCount = eventsCount;
            this.Grid = grid;
            this.MatchedAddress = matchedAddress;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets RiskLevel
        /// </summary>
        [DataMember(Name="riskLevel", EmitDefaultValue=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// Gets or Sets EventsCount
        /// </summary>
        [DataMember(Name="eventsCount", EmitDefaultValue=false)]
        public EventsCount EventsCount { get; set; }

        /// <summary>
        /// Gets or Sets Grid
        /// </summary>
        [DataMember(Name="grid", EmitDefaultValue=false)]
        public Grid Grid { get; set; }

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
            sb.Append("class EarthquakeRiskResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  RiskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("  EventsCount: ").Append(EventsCount).Append("\n");
            sb.Append("  Grid: ").Append(Grid).Append("\n");
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
            return this.Equals(input as EarthquakeRiskResponse);
        }

        /// <summary>
        /// Returns true if EarthquakeRiskResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EarthquakeRiskResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarthquakeRiskResponse input)
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
                    this.RiskLevel == input.RiskLevel ||
                    (this.RiskLevel != null &&
                    this.RiskLevel.Equals(input.RiskLevel))
                ) && 
                (
                    this.EventsCount == input.EventsCount ||
                    (this.EventsCount != null &&
                    this.EventsCount.Equals(input.EventsCount))
                ) && 
                (
                    this.Grid == input.Grid ||
                    (this.Grid != null &&
                    this.Grid.Equals(input.Grid))
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
                if (this.RiskLevel != null)
                    hashCode = hashCode * 59 + this.RiskLevel.GetHashCode();
                if (this.EventsCount != null)
                    hashCode = hashCode * 59 + this.EventsCount.GetHashCode();
                if (this.Grid != null)
                    hashCode = hashCode * 59 + this.Grid.GetHashCode();
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
