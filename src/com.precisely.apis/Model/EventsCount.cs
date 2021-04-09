/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// EventsCount
    /// </summary>
    [DataContract]
    public partial class EventsCount :  IEquatable<EventsCount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsCount" /> class.
        /// </summary>
        /// <param name="Total">Total.</param>
        /// <param name="R0">R0.</param>
        /// <param name="R1">R1.</param>
        /// <param name="R2">R2.</param>
        /// <param name="R3">R3.</param>
        /// <param name="R4">R4.</param>
        /// <param name="R5">R5.</param>
        /// <param name="R6">R6.</param>
        /// <param name="R7">R7.</param>
        /// <param name="R0Ge">R0Ge.</param>
        /// <param name="R1Ge">R1Ge.</param>
        /// <param name="R2Ge">R2Ge.</param>
        /// <param name="R3Ge">R3Ge.</param>
        /// <param name="R4Ge">R4Ge.</param>
        /// <param name="R5Ge">R5Ge.</param>
        /// <param name="R6Ge">R6Ge.</param>
        /// <param name="R7Ge">R7Ge.</param>
        public EventsCount(string Total = null, string R0 = null, string R1 = null, string R2 = null, string R3 = null, string R4 = null, string R5 = null, string R6 = null, string R7 = null, string R0Ge = null, string R1Ge = null, string R2Ge = null, string R3Ge = null, string R4Ge = null, string R5Ge = null, string R6Ge = null, string R7Ge = null)
        {
            this.Total = Total;
            this.R0 = R0;
            this.R1 = R1;
            this.R2 = R2;
            this.R3 = R3;
            this.R4 = R4;
            this.R5 = R5;
            this.R6 = R6;
            this.R7 = R7;
            this.R0Ge = R0Ge;
            this.R1Ge = R1Ge;
            this.R2Ge = R2Ge;
            this.R3Ge = R3Ge;
            this.R4Ge = R4Ge;
            this.R5Ge = R5Ge;
            this.R6Ge = R6Ge;
            this.R7Ge = R7Ge;
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EventsCount);
        }

        /// <summary>
        /// Returns true if EventsCount instances are equal
        /// </summary>
        /// <param name="other">Instance of EventsCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventsCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.R0 == other.R0 ||
                    this.R0 != null &&
                    this.R0.Equals(other.R0)
                ) && 
                (
                    this.R1 == other.R1 ||
                    this.R1 != null &&
                    this.R1.Equals(other.R1)
                ) && 
                (
                    this.R2 == other.R2 ||
                    this.R2 != null &&
                    this.R2.Equals(other.R2)
                ) && 
                (
                    this.R3 == other.R3 ||
                    this.R3 != null &&
                    this.R3.Equals(other.R3)
                ) && 
                (
                    this.R4 == other.R4 ||
                    this.R4 != null &&
                    this.R4.Equals(other.R4)
                ) && 
                (
                    this.R5 == other.R5 ||
                    this.R5 != null &&
                    this.R5.Equals(other.R5)
                ) && 
                (
                    this.R6 == other.R6 ||
                    this.R6 != null &&
                    this.R6.Equals(other.R6)
                ) && 
                (
                    this.R7 == other.R7 ||
                    this.R7 != null &&
                    this.R7.Equals(other.R7)
                ) && 
                (
                    this.R0Ge == other.R0Ge ||
                    this.R0Ge != null &&
                    this.R0Ge.Equals(other.R0Ge)
                ) && 
                (
                    this.R1Ge == other.R1Ge ||
                    this.R1Ge != null &&
                    this.R1Ge.Equals(other.R1Ge)
                ) && 
                (
                    this.R2Ge == other.R2Ge ||
                    this.R2Ge != null &&
                    this.R2Ge.Equals(other.R2Ge)
                ) && 
                (
                    this.R3Ge == other.R3Ge ||
                    this.R3Ge != null &&
                    this.R3Ge.Equals(other.R3Ge)
                ) && 
                (
                    this.R4Ge == other.R4Ge ||
                    this.R4Ge != null &&
                    this.R4Ge.Equals(other.R4Ge)
                ) && 
                (
                    this.R5Ge == other.R5Ge ||
                    this.R5Ge != null &&
                    this.R5Ge.Equals(other.R5Ge)
                ) && 
                (
                    this.R6Ge == other.R6Ge ||
                    this.R6Ge != null &&
                    this.R6Ge.Equals(other.R6Ge)
                ) && 
                (
                    this.R7Ge == other.R7Ge ||
                    this.R7Ge != null &&
                    this.R7Ge.Equals(other.R7Ge)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.R0 != null)
                    hash = hash * 59 + this.R0.GetHashCode();
                if (this.R1 != null)
                    hash = hash * 59 + this.R1.GetHashCode();
                if (this.R2 != null)
                    hash = hash * 59 + this.R2.GetHashCode();
                if (this.R3 != null)
                    hash = hash * 59 + this.R3.GetHashCode();
                if (this.R4 != null)
                    hash = hash * 59 + this.R4.GetHashCode();
                if (this.R5 != null)
                    hash = hash * 59 + this.R5.GetHashCode();
                if (this.R6 != null)
                    hash = hash * 59 + this.R6.GetHashCode();
                if (this.R7 != null)
                    hash = hash * 59 + this.R7.GetHashCode();
                if (this.R0Ge != null)
                    hash = hash * 59 + this.R0Ge.GetHashCode();
                if (this.R1Ge != null)
                    hash = hash * 59 + this.R1Ge.GetHashCode();
                if (this.R2Ge != null)
                    hash = hash * 59 + this.R2Ge.GetHashCode();
                if (this.R3Ge != null)
                    hash = hash * 59 + this.R3Ge.GetHashCode();
                if (this.R4Ge != null)
                    hash = hash * 59 + this.R4Ge.GetHashCode();
                if (this.R5Ge != null)
                    hash = hash * 59 + this.R5Ge.GetHashCode();
                if (this.R6Ge != null)
                    hash = hash * 59 + this.R6Ge.GetHashCode();
                if (this.R7Ge != null)
                    hash = hash * 59 + this.R7Ge.GetHashCode();
                return hash;
            }
        }
    }

}
