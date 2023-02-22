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
    /// SpeedLimit
    /// </summary>
    [DataContract]
    public partial class SpeedLimit :  IEquatable<SpeedLimit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedLimit" /> class.
        /// </summary>
        /// <param name="maxSpeed">maxSpeed.</param>
        /// <param name="speedUnit">speedUnit.</param>
        /// <param name="speedVerification">speedVerification.</param>
        /// <param name="amPeakAvgSpeed">amPeakAvgSpeed.</param>
        /// <param name="pmPeakAvgSpeed">pmPeakAvgSpeed.</param>
        /// <param name="offPeakAvgSpeed">offPeakAvgSpeed.</param>
        /// <param name="nightAvgSpeed">nightAvgSpeed.</param>
        /// <param name="weekAvgSpeed">weekAvgSpeed.</param>
        /// <param name="road">road.</param>
        public SpeedLimit(string maxSpeed = default(string), string speedUnit = default(string), string speedVerification = default(string), string amPeakAvgSpeed = default(string), string pmPeakAvgSpeed = default(string), string offPeakAvgSpeed = default(string), string nightAvgSpeed = default(string), string weekAvgSpeed = default(string), Road road = default(Road))
        {
            this.MaxSpeed = maxSpeed;
            this.SpeedUnit = speedUnit;
            this.SpeedVerification = speedVerification;
            this.AmPeakAvgSpeed = amPeakAvgSpeed;
            this.PmPeakAvgSpeed = pmPeakAvgSpeed;
            this.OffPeakAvgSpeed = offPeakAvgSpeed;
            this.NightAvgSpeed = nightAvgSpeed;
            this.WeekAvgSpeed = weekAvgSpeed;
            this.Road = road;
        }

        /// <summary>
        /// Gets or Sets MaxSpeed
        /// </summary>
        [DataMember(Name="maxSpeed", EmitDefaultValue=false)]
        public string MaxSpeed { get; set; }

        /// <summary>
        /// Gets or Sets SpeedUnit
        /// </summary>
        [DataMember(Name="speedUnit", EmitDefaultValue=false)]
        public string SpeedUnit { get; set; }

        /// <summary>
        /// Gets or Sets SpeedVerification
        /// </summary>
        [DataMember(Name="speedVerification", EmitDefaultValue=false)]
        public string SpeedVerification { get; set; }

        /// <summary>
        /// Gets or Sets AmPeakAvgSpeed
        /// </summary>
        [DataMember(Name="amPeakAvgSpeed", EmitDefaultValue=false)]
        public string AmPeakAvgSpeed { get; set; }

        /// <summary>
        /// Gets or Sets PmPeakAvgSpeed
        /// </summary>
        [DataMember(Name="pmPeakAvgSpeed", EmitDefaultValue=false)]
        public string PmPeakAvgSpeed { get; set; }

        /// <summary>
        /// Gets or Sets OffPeakAvgSpeed
        /// </summary>
        [DataMember(Name="offPeakAvgSpeed", EmitDefaultValue=false)]
        public string OffPeakAvgSpeed { get; set; }

        /// <summary>
        /// Gets or Sets NightAvgSpeed
        /// </summary>
        [DataMember(Name="nightAvgSpeed", EmitDefaultValue=false)]
        public string NightAvgSpeed { get; set; }

        /// <summary>
        /// Gets or Sets WeekAvgSpeed
        /// </summary>
        [DataMember(Name="weekAvgSpeed", EmitDefaultValue=false)]
        public string WeekAvgSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Road
        /// </summary>
        [DataMember(Name="road", EmitDefaultValue=false)]
        public Road Road { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeedLimit {\n");
            sb.Append("  MaxSpeed: ").Append(MaxSpeed).Append("\n");
            sb.Append("  SpeedUnit: ").Append(SpeedUnit).Append("\n");
            sb.Append("  SpeedVerification: ").Append(SpeedVerification).Append("\n");
            sb.Append("  AmPeakAvgSpeed: ").Append(AmPeakAvgSpeed).Append("\n");
            sb.Append("  PmPeakAvgSpeed: ").Append(PmPeakAvgSpeed).Append("\n");
            sb.Append("  OffPeakAvgSpeed: ").Append(OffPeakAvgSpeed).Append("\n");
            sb.Append("  NightAvgSpeed: ").Append(NightAvgSpeed).Append("\n");
            sb.Append("  WeekAvgSpeed: ").Append(WeekAvgSpeed).Append("\n");
            sb.Append("  Road: ").Append(Road).Append("\n");
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
            return this.Equals(input as SpeedLimit);
        }

        /// <summary>
        /// Returns true if SpeedLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of SpeedLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpeedLimit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxSpeed == input.MaxSpeed ||
                    (this.MaxSpeed != null &&
                    this.MaxSpeed.Equals(input.MaxSpeed))
                ) && 
                (
                    this.SpeedUnit == input.SpeedUnit ||
                    (this.SpeedUnit != null &&
                    this.SpeedUnit.Equals(input.SpeedUnit))
                ) && 
                (
                    this.SpeedVerification == input.SpeedVerification ||
                    (this.SpeedVerification != null &&
                    this.SpeedVerification.Equals(input.SpeedVerification))
                ) && 
                (
                    this.AmPeakAvgSpeed == input.AmPeakAvgSpeed ||
                    (this.AmPeakAvgSpeed != null &&
                    this.AmPeakAvgSpeed.Equals(input.AmPeakAvgSpeed))
                ) && 
                (
                    this.PmPeakAvgSpeed == input.PmPeakAvgSpeed ||
                    (this.PmPeakAvgSpeed != null &&
                    this.PmPeakAvgSpeed.Equals(input.PmPeakAvgSpeed))
                ) && 
                (
                    this.OffPeakAvgSpeed == input.OffPeakAvgSpeed ||
                    (this.OffPeakAvgSpeed != null &&
                    this.OffPeakAvgSpeed.Equals(input.OffPeakAvgSpeed))
                ) && 
                (
                    this.NightAvgSpeed == input.NightAvgSpeed ||
                    (this.NightAvgSpeed != null &&
                    this.NightAvgSpeed.Equals(input.NightAvgSpeed))
                ) && 
                (
                    this.WeekAvgSpeed == input.WeekAvgSpeed ||
                    (this.WeekAvgSpeed != null &&
                    this.WeekAvgSpeed.Equals(input.WeekAvgSpeed))
                ) && 
                (
                    this.Road == input.Road ||
                    (this.Road != null &&
                    this.Road.Equals(input.Road))
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
                if (this.MaxSpeed != null)
                    hashCode = hashCode * 59 + this.MaxSpeed.GetHashCode();
                if (this.SpeedUnit != null)
                    hashCode = hashCode * 59 + this.SpeedUnit.GetHashCode();
                if (this.SpeedVerification != null)
                    hashCode = hashCode * 59 + this.SpeedVerification.GetHashCode();
                if (this.AmPeakAvgSpeed != null)
                    hashCode = hashCode * 59 + this.AmPeakAvgSpeed.GetHashCode();
                if (this.PmPeakAvgSpeed != null)
                    hashCode = hashCode * 59 + this.PmPeakAvgSpeed.GetHashCode();
                if (this.OffPeakAvgSpeed != null)
                    hashCode = hashCode * 59 + this.OffPeakAvgSpeed.GetHashCode();
                if (this.NightAvgSpeed != null)
                    hashCode = hashCode * 59 + this.NightAvgSpeed.GetHashCode();
                if (this.WeekAvgSpeed != null)
                    hashCode = hashCode * 59 + this.WeekAvgSpeed.GetHashCode();
                if (this.Road != null)
                    hashCode = hashCode * 59 + this.Road.GetHashCode();
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
