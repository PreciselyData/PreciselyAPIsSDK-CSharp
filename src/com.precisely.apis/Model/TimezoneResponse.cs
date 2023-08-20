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
    /// TimezoneResponse
    /// </summary>
    [DataContract]
    public partial class TimezoneResponse :  IEquatable<TimezoneResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneResponse" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="timezoneName">timezoneName.</param>
        /// <param name="zoneType">zoneType.</param>
        /// <param name="utcOffset">utcOffset.</param>
        /// <param name="dstOffset">dstOffset.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        /// <param name="country">country.</param>
        /// <param name="tzValidFrom">tzValidFrom.</param>
        /// <param name="tzValidUntill">tzValidUntill.</param>
        /// <param name="dstRule">dstRule.</param>
        /// <param name="dstValidFrom">dstValidFrom.</param>
        /// <param name="dstValidUntill">dstValidUntill.</param>
        /// <param name="dstStartDateFormat">dstStartDateFormat.</param>
        /// <param name="dstEndDateFormat">dstEndDateFormat.</param>
        /// <param name="dstStartDate">dstStartDate.</param>
        /// <param name="dstStartTime">dstStartTime.</param>
        /// <param name="dstEndTime">dstEndTime.</param>
        /// <param name="dstEndDate">dstEndDate.</param>
        public TimezoneResponse(string objectId = default(string), string timezoneName = default(string), string zoneType = default(string), long utcOffset = default(long), long dstOffset = default(long), long timestamp = default(long), Address matchedAddress = default(Address), string country = default(string), string tzValidFrom = default(string), string tzValidUntill = default(string), string dstRule = default(string), string dstValidFrom = default(string), string dstValidUntill = default(string), string dstStartDateFormat = default(string), string dstEndDateFormat = default(string), string dstStartDate = default(string), string dstStartTime = default(string), string dstEndTime = default(string), string dstEndDate = default(string))
        {
            this.ObjectId = objectId;
            this.TimezoneName = timezoneName;
            this.ZoneType = zoneType;
            this.UtcOffset = utcOffset;
            this.DstOffset = dstOffset;
            this.Timestamp = timestamp;
            this.MatchedAddress = matchedAddress;
            this.Country = country;
            this.TzValidFrom = tzValidFrom;
            this.TzValidUntill = tzValidUntill;
            this.DstRule = dstRule;
            this.DstValidFrom = dstValidFrom;
            this.DstValidUntill = dstValidUntill;
            this.DstStartDateFormat = dstStartDateFormat;
            this.DstEndDateFormat = dstEndDateFormat;
            this.DstStartDate = dstStartDate;
            this.DstStartTime = dstStartTime;
            this.DstEndTime = dstEndTime;
            this.DstEndDate = dstEndDate;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets TimezoneName
        /// </summary>
        [DataMember(Name="timezoneName", EmitDefaultValue=false)]
        public string TimezoneName { get; set; }

        /// <summary>
        /// Gets or Sets ZoneType
        /// </summary>
        [DataMember(Name="zoneType", EmitDefaultValue=false)]
        public string ZoneType { get; set; }

        /// <summary>
        /// Gets or Sets UtcOffset
        /// </summary>
        [DataMember(Name="utcOffset", EmitDefaultValue=false)]
        public long UtcOffset { get; set; }

        /// <summary>
        /// Gets or Sets DstOffset
        /// </summary>
        [DataMember(Name="dstOffset", EmitDefaultValue=false)]
        public long DstOffset { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public Address MatchedAddress { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets TzValidFrom
        /// </summary>
        [DataMember(Name="tzValidFrom", EmitDefaultValue=false)]
        public string TzValidFrom { get; set; }

        /// <summary>
        /// Gets or Sets TzValidUntill
        /// </summary>
        [DataMember(Name="tzValidUntill", EmitDefaultValue=false)]
        public string TzValidUntill { get; set; }

        /// <summary>
        /// Gets or Sets DstRule
        /// </summary>
        [DataMember(Name="dstRule", EmitDefaultValue=false)]
        public string DstRule { get; set; }

        /// <summary>
        /// Gets or Sets DstValidFrom
        /// </summary>
        [DataMember(Name="dstValidFrom", EmitDefaultValue=false)]
        public string DstValidFrom { get; set; }

        /// <summary>
        /// Gets or Sets DstValidUntill
        /// </summary>
        [DataMember(Name="dstValidUntill", EmitDefaultValue=false)]
        public string DstValidUntill { get; set; }

        /// <summary>
        /// Gets or Sets DstStartDateFormat
        /// </summary>
        [DataMember(Name="dstStartDateFormat", EmitDefaultValue=false)]
        public string DstStartDateFormat { get; set; }

        /// <summary>
        /// Gets or Sets DstEndDateFormat
        /// </summary>
        [DataMember(Name="dstEndDateFormat", EmitDefaultValue=false)]
        public string DstEndDateFormat { get; set; }

        /// <summary>
        /// Gets or Sets DstStartDate
        /// </summary>
        [DataMember(Name="dstStartDate", EmitDefaultValue=false)]
        public string DstStartDate { get; set; }

        /// <summary>
        /// Gets or Sets DstStartTime
        /// </summary>
        [DataMember(Name="dstStartTime", EmitDefaultValue=false)]
        public string DstStartTime { get; set; }

        /// <summary>
        /// Gets or Sets DstEndTime
        /// </summary>
        [DataMember(Name="dstEndTime", EmitDefaultValue=false)]
        public string DstEndTime { get; set; }

        /// <summary>
        /// Gets or Sets DstEndDate
        /// </summary>
        [DataMember(Name="dstEndDate", EmitDefaultValue=false)]
        public string DstEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimezoneResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  TimezoneName: ").Append(TimezoneName).Append("\n");
            sb.Append("  ZoneType: ").Append(ZoneType).Append("\n");
            sb.Append("  UtcOffset: ").Append(UtcOffset).Append("\n");
            sb.Append("  DstOffset: ").Append(DstOffset).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  TzValidFrom: ").Append(TzValidFrom).Append("\n");
            sb.Append("  TzValidUntill: ").Append(TzValidUntill).Append("\n");
            sb.Append("  DstRule: ").Append(DstRule).Append("\n");
            sb.Append("  DstValidFrom: ").Append(DstValidFrom).Append("\n");
            sb.Append("  DstValidUntill: ").Append(DstValidUntill).Append("\n");
            sb.Append("  DstStartDateFormat: ").Append(DstStartDateFormat).Append("\n");
            sb.Append("  DstEndDateFormat: ").Append(DstEndDateFormat).Append("\n");
            sb.Append("  DstStartDate: ").Append(DstStartDate).Append("\n");
            sb.Append("  DstStartTime: ").Append(DstStartTime).Append("\n");
            sb.Append("  DstEndTime: ").Append(DstEndTime).Append("\n");
            sb.Append("  DstEndDate: ").Append(DstEndDate).Append("\n");
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
            return this.Equals(input as TimezoneResponse);
        }

        /// <summary>
        /// Returns true if TimezoneResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TimezoneResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimezoneResponse input)
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
                    this.TimezoneName == input.TimezoneName ||
                    (this.TimezoneName != null &&
                    this.TimezoneName.Equals(input.TimezoneName))
                ) && 
                (
                    this.ZoneType == input.ZoneType ||
                    (this.ZoneType != null &&
                    this.ZoneType.Equals(input.ZoneType))
                ) && 
                (
                    this.UtcOffset == input.UtcOffset ||
                    (this.UtcOffset != null &&
                    this.UtcOffset.Equals(input.UtcOffset))
                ) && 
                (
                    this.DstOffset == input.DstOffset ||
                    (this.DstOffset != null &&
                    this.DstOffset.Equals(input.DstOffset))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.MatchedAddress == input.MatchedAddress ||
                    (this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(input.MatchedAddress))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.TzValidFrom == input.TzValidFrom ||
                    (this.TzValidFrom != null &&
                    this.TzValidFrom.Equals(input.TzValidFrom))
                ) && 
                (
                    this.TzValidUntill == input.TzValidUntill ||
                    (this.TzValidUntill != null &&
                    this.TzValidUntill.Equals(input.TzValidUntill))
                ) && 
                (
                    this.DstRule == input.DstRule ||
                    (this.DstRule != null &&
                    this.DstRule.Equals(input.DstRule))
                ) && 
                (
                    this.DstValidFrom == input.DstValidFrom ||
                    (this.DstValidFrom != null &&
                    this.DstValidFrom.Equals(input.DstValidFrom))
                ) && 
                (
                    this.DstValidUntill == input.DstValidUntill ||
                    (this.DstValidUntill != null &&
                    this.DstValidUntill.Equals(input.DstValidUntill))
                ) && 
                (
                    this.DstStartDateFormat == input.DstStartDateFormat ||
                    (this.DstStartDateFormat != null &&
                    this.DstStartDateFormat.Equals(input.DstStartDateFormat))
                ) && 
                (
                    this.DstEndDateFormat == input.DstEndDateFormat ||
                    (this.DstEndDateFormat != null &&
                    this.DstEndDateFormat.Equals(input.DstEndDateFormat))
                ) && 
                (
                    this.DstStartDate == input.DstStartDate ||
                    (this.DstStartDate != null &&
                    this.DstStartDate.Equals(input.DstStartDate))
                ) && 
                (
                    this.DstStartTime == input.DstStartTime ||
                    (this.DstStartTime != null &&
                    this.DstStartTime.Equals(input.DstStartTime))
                ) && 
                (
                    this.DstEndTime == input.DstEndTime ||
                    (this.DstEndTime != null &&
                    this.DstEndTime.Equals(input.DstEndTime))
                ) && 
                (
                    this.DstEndDate == input.DstEndDate ||
                    (this.DstEndDate != null &&
                    this.DstEndDate.Equals(input.DstEndDate))
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
                if (this.TimezoneName != null)
                    hashCode = hashCode * 59 + this.TimezoneName.GetHashCode();
                if (this.ZoneType != null)
                    hashCode = hashCode * 59 + this.ZoneType.GetHashCode();
                if (this.UtcOffset != null)
                    hashCode = hashCode * 59 + this.UtcOffset.GetHashCode();
                if (this.DstOffset != null)
                    hashCode = hashCode * 59 + this.DstOffset.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.MatchedAddress != null)
                    hashCode = hashCode * 59 + this.MatchedAddress.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.TzValidFrom != null)
                    hashCode = hashCode * 59 + this.TzValidFrom.GetHashCode();
                if (this.TzValidUntill != null)
                    hashCode = hashCode * 59 + this.TzValidUntill.GetHashCode();
                if (this.DstRule != null)
                    hashCode = hashCode * 59 + this.DstRule.GetHashCode();
                if (this.DstValidFrom != null)
                    hashCode = hashCode * 59 + this.DstValidFrom.GetHashCode();
                if (this.DstValidUntill != null)
                    hashCode = hashCode * 59 + this.DstValidUntill.GetHashCode();
                if (this.DstStartDateFormat != null)
                    hashCode = hashCode * 59 + this.DstStartDateFormat.GetHashCode();
                if (this.DstEndDateFormat != null)
                    hashCode = hashCode * 59 + this.DstEndDateFormat.GetHashCode();
                if (this.DstStartDate != null)
                    hashCode = hashCode * 59 + this.DstStartDate.GetHashCode();
                if (this.DstStartTime != null)
                    hashCode = hashCode * 59 + this.DstStartTime.GetHashCode();
                if (this.DstEndTime != null)
                    hashCode = hashCode * 59 + this.DstEndTime.GetHashCode();
                if (this.DstEndDate != null)
                    hashCode = hashCode * 59 + this.DstEndDate.GetHashCode();
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
