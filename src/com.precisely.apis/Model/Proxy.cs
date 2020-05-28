/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 9.0.0
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
    /// Proxy
    /// </summary>
    [DataContract]
    public partial class Proxy :  IEquatable<Proxy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Proxy" /> class.
        /// </summary>
        /// <param name="AnonymizerStatus">AnonymizerStatus.</param>
        /// <param name="Level">Level.</param>
        /// <param name="LastDetected">LastDetected.</param>
        /// <param name="Type">Type.</param>
        public Proxy(string AnonymizerStatus = null, string Level = null, string LastDetected = null, string Type = null)
        {
            this.AnonymizerStatus = AnonymizerStatus;
            this.Level = Level;
            this.LastDetected = LastDetected;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets AnonymizerStatus
        /// </summary>
        [DataMember(Name="anonymizerStatus", EmitDefaultValue=false)]
        public string AnonymizerStatus { get; set; }
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }
        /// <summary>
        /// Gets or Sets LastDetected
        /// </summary>
        [DataMember(Name="lastDetected", EmitDefaultValue=false)]
        public string LastDetected { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Proxy {\n");
            sb.Append("  AnonymizerStatus: ").Append(AnonymizerStatus).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  LastDetected: ").Append(LastDetected).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as Proxy);
        }

        /// <summary>
        /// Returns true if Proxy instances are equal
        /// </summary>
        /// <param name="other">Instance of Proxy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Proxy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AnonymizerStatus == other.AnonymizerStatus ||
                    this.AnonymizerStatus != null &&
                    this.AnonymizerStatus.Equals(other.AnonymizerStatus)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.LastDetected == other.LastDetected ||
                    this.LastDetected != null &&
                    this.LastDetected.Equals(other.LastDetected)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.AnonymizerStatus != null)
                    hash = hash * 59 + this.AnonymizerStatus.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.LastDetected != null)
                    hash = hash * 59 + this.LastDetected.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }
    }

}
