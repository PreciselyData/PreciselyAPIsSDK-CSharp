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
    /// EventsCount
    /// </summary>
    [DataContract]
    public partial class EventsCount :  IEquatable<EventsCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsCount" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="r0">r0.</param>
        /// <param name="r1">r1.</param>
        /// <param name="r2">r2.</param>
        /// <param name="r3">r3.</param>
        /// <param name="r4">r4.</param>
        /// <param name="r5">r5.</param>
        /// <param name="r6">r6.</param>
        /// <param name="r7">r7.</param>
        /// <param name="r0Ge">r0Ge.</param>
        /// <param name="r1Ge">r1Ge.</param>
        /// <param name="r2Ge">r2Ge.</param>
        /// <param name="r3Ge">r3Ge.</param>
        /// <param name="r4Ge">r4Ge.</param>
        /// <param name="r5Ge">r5Ge.</param>
        /// <param name="r6Ge">r6Ge.</param>
        /// <param name="r7Ge">r7Ge.</param>
        public EventsCount(string total = default(string), string r0 = default(string), string r1 = default(string), string r2 = default(string), string r3 = default(string), string r4 = default(string), string r5 = default(string), string r6 = default(string), string r7 = default(string), string r0Ge = default(string), string r1Ge = default(string), string r2Ge = default(string), string r3Ge = default(string), string r4Ge = default(string), string r5Ge = default(string), string r6Ge = default(string), string r7Ge = default(string))
        {
            this.Total = total;
            this.R0 = r0;
            this.R1 = r1;
            this.R2 = r2;
            this.R3 = r3;
            this.R4 = r4;
            this.R5 = r5;
            this.R6 = r6;
            this.R7 = r7;
            this.R0Ge = r0Ge;
            this.R1Ge = r1Ge;
            this.R2Ge = r2Ge;
            this.R3Ge = r3Ge;
            this.R4Ge = r4Ge;
            this.R5Ge = r5Ge;
            this.R6Ge = r6Ge;
            this.R7Ge = r7Ge;
        }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public string Total { get; set; }

        /// <summary>
        /// Gets or Sets R0
        /// </summary>
        [DataMember(Name="r0", EmitDefaultValue=false)]
        public string R0 { get; set; }

        /// <summary>
        /// Gets or Sets R1
        /// </summary>
        [DataMember(Name="r1", EmitDefaultValue=false)]
        public string R1 { get; set; }

        /// <summary>
        /// Gets or Sets R2
        /// </summary>
        [DataMember(Name="r2", EmitDefaultValue=false)]
        public string R2 { get; set; }

        /// <summary>
        /// Gets or Sets R3
        /// </summary>
        [DataMember(Name="r3", EmitDefaultValue=false)]
        public string R3 { get; set; }

        /// <summary>
        /// Gets or Sets R4
        /// </summary>
        [DataMember(Name="r4", EmitDefaultValue=false)]
        public string R4 { get; set; }

        /// <summary>
        /// Gets or Sets R5
        /// </summary>
        [DataMember(Name="r5", EmitDefaultValue=false)]
        public string R5 { get; set; }

        /// <summary>
        /// Gets or Sets R6
        /// </summary>
        [DataMember(Name="r6", EmitDefaultValue=false)]
        public string R6 { get; set; }

        /// <summary>
        /// Gets or Sets R7
        /// </summary>
        [DataMember(Name="r7", EmitDefaultValue=false)]
        public string R7 { get; set; }

        /// <summary>
        /// Gets or Sets R0Ge
        /// </summary>
        [DataMember(Name="r0_ge", EmitDefaultValue=false)]
        public string R0Ge { get; set; }

        /// <summary>
        /// Gets or Sets R1Ge
        /// </summary>
        [DataMember(Name="r1_ge", EmitDefaultValue=false)]
        public string R1Ge { get; set; }

        /// <summary>
        /// Gets or Sets R2Ge
        /// </summary>
        [DataMember(Name="r2_ge", EmitDefaultValue=false)]
        public string R2Ge { get; set; }

        /// <summary>
        /// Gets or Sets R3Ge
        /// </summary>
        [DataMember(Name="r3_ge", EmitDefaultValue=false)]
        public string R3Ge { get; set; }

        /// <summary>
        /// Gets or Sets R4Ge
        /// </summary>
        [DataMember(Name="r4_ge", EmitDefaultValue=false)]
        public string R4Ge { get; set; }

        /// <summary>
        /// Gets or Sets R5Ge
        /// </summary>
        [DataMember(Name="r5_ge", EmitDefaultValue=false)]
        public string R5Ge { get; set; }

        /// <summary>
        /// Gets or Sets R6Ge
        /// </summary>
        [DataMember(Name="r6_ge", EmitDefaultValue=false)]
        public string R6Ge { get; set; }

        /// <summary>
        /// Gets or Sets R7Ge
        /// </summary>
        [DataMember(Name="r7_ge", EmitDefaultValue=false)]
        public string R7Ge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventsCount {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  R0: ").Append(R0).Append("\n");
            sb.Append("  R1: ").Append(R1).Append("\n");
            sb.Append("  R2: ").Append(R2).Append("\n");
            sb.Append("  R3: ").Append(R3).Append("\n");
            sb.Append("  R4: ").Append(R4).Append("\n");
            sb.Append("  R5: ").Append(R5).Append("\n");
            sb.Append("  R6: ").Append(R6).Append("\n");
            sb.Append("  R7: ").Append(R7).Append("\n");
            sb.Append("  R0Ge: ").Append(R0Ge).Append("\n");
            sb.Append("  R1Ge: ").Append(R1Ge).Append("\n");
            sb.Append("  R2Ge: ").Append(R2Ge).Append("\n");
            sb.Append("  R3Ge: ").Append(R3Ge).Append("\n");
            sb.Append("  R4Ge: ").Append(R4Ge).Append("\n");
            sb.Append("  R5Ge: ").Append(R5Ge).Append("\n");
            sb.Append("  R6Ge: ").Append(R6Ge).Append("\n");
            sb.Append("  R7Ge: ").Append(R7Ge).Append("\n");
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
            return this.Equals(input as EventsCount);
        }

        /// <summary>
        /// Returns true if EventsCount instances are equal
        /// </summary>
        /// <param name="input">Instance of EventsCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventsCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.R0 == input.R0 ||
                    (this.R0 != null &&
                    this.R0.Equals(input.R0))
                ) && 
                (
                    this.R1 == input.R1 ||
                    (this.R1 != null &&
                    this.R1.Equals(input.R1))
                ) && 
                (
                    this.R2 == input.R2 ||
                    (this.R2 != null &&
                    this.R2.Equals(input.R2))
                ) && 
                (
                    this.R3 == input.R3 ||
                    (this.R3 != null &&
                    this.R3.Equals(input.R3))
                ) && 
                (
                    this.R4 == input.R4 ||
                    (this.R4 != null &&
                    this.R4.Equals(input.R4))
                ) && 
                (
                    this.R5 == input.R5 ||
                    (this.R5 != null &&
                    this.R5.Equals(input.R5))
                ) && 
                (
                    this.R6 == input.R6 ||
                    (this.R6 != null &&
                    this.R6.Equals(input.R6))
                ) && 
                (
                    this.R7 == input.R7 ||
                    (this.R7 != null &&
                    this.R7.Equals(input.R7))
                ) && 
                (
                    this.R0Ge == input.R0Ge ||
                    (this.R0Ge != null &&
                    this.R0Ge.Equals(input.R0Ge))
                ) && 
                (
                    this.R1Ge == input.R1Ge ||
                    (this.R1Ge != null &&
                    this.R1Ge.Equals(input.R1Ge))
                ) && 
                (
                    this.R2Ge == input.R2Ge ||
                    (this.R2Ge != null &&
                    this.R2Ge.Equals(input.R2Ge))
                ) && 
                (
                    this.R3Ge == input.R3Ge ||
                    (this.R3Ge != null &&
                    this.R3Ge.Equals(input.R3Ge))
                ) && 
                (
                    this.R4Ge == input.R4Ge ||
                    (this.R4Ge != null &&
                    this.R4Ge.Equals(input.R4Ge))
                ) && 
                (
                    this.R5Ge == input.R5Ge ||
                    (this.R5Ge != null &&
                    this.R5Ge.Equals(input.R5Ge))
                ) && 
                (
                    this.R6Ge == input.R6Ge ||
                    (this.R6Ge != null &&
                    this.R6Ge.Equals(input.R6Ge))
                ) && 
                (
                    this.R7Ge == input.R7Ge ||
                    (this.R7Ge != null &&
                    this.R7Ge.Equals(input.R7Ge))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.R0 != null)
                    hashCode = hashCode * 59 + this.R0.GetHashCode();
                if (this.R1 != null)
                    hashCode = hashCode * 59 + this.R1.GetHashCode();
                if (this.R2 != null)
                    hashCode = hashCode * 59 + this.R2.GetHashCode();
                if (this.R3 != null)
                    hashCode = hashCode * 59 + this.R3.GetHashCode();
                if (this.R4 != null)
                    hashCode = hashCode * 59 + this.R4.GetHashCode();
                if (this.R5 != null)
                    hashCode = hashCode * 59 + this.R5.GetHashCode();
                if (this.R6 != null)
                    hashCode = hashCode * 59 + this.R6.GetHashCode();
                if (this.R7 != null)
                    hashCode = hashCode * 59 + this.R7.GetHashCode();
                if (this.R0Ge != null)
                    hashCode = hashCode * 59 + this.R0Ge.GetHashCode();
                if (this.R1Ge != null)
                    hashCode = hashCode * 59 + this.R1Ge.GetHashCode();
                if (this.R2Ge != null)
                    hashCode = hashCode * 59 + this.R2Ge.GetHashCode();
                if (this.R3Ge != null)
                    hashCode = hashCode * 59 + this.R3Ge.GetHashCode();
                if (this.R4Ge != null)
                    hashCode = hashCode * 59 + this.R4Ge.GetHashCode();
                if (this.R5Ge != null)
                    hashCode = hashCode * 59 + this.R5Ge.GetHashCode();
                if (this.R6Ge != null)
                    hashCode = hashCode * 59 + this.R6Ge.GetHashCode();
                if (this.R7Ge != null)
                    hashCode = hashCode * 59 + this.R7Ge.GetHashCode();
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
