/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.1
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
    /// Magnitude
    /// </summary>
    [DataContract]
    public partial class Magnitude :  IEquatable<Magnitude>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Magnitude" /> class.
        /// </summary>
        /// <param name="Value">Value.</param>
        /// <param name="Scale">Scale.</param>
        /// <param name="BodyWave">BodyWave.</param>
        /// <param name="SurfaceWave">SurfaceWave.</param>
        public Magnitude(double? Value = null, string Scale = null, double? BodyWave = null, double? SurfaceWave = null)
        {
            this.Value = Value;
            this.Scale = Scale;
            this.BodyWave = BodyWave;
            this.SurfaceWave = SurfaceWave;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }
        /// <summary>
        /// Gets or Sets Scale
        /// </summary>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public string Scale { get; set; }
        /// <summary>
        /// Gets or Sets BodyWave
        /// </summary>
        [DataMember(Name="bodyWave", EmitDefaultValue=false)]
        public double? BodyWave { get; set; }
        /// <summary>
        /// Gets or Sets SurfaceWave
        /// </summary>
        [DataMember(Name="surfaceWave", EmitDefaultValue=false)]
        public double? SurfaceWave { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Magnitude {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  BodyWave: ").Append(BodyWave).Append("\n");
            sb.Append("  SurfaceWave: ").Append(SurfaceWave).Append("\n");
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
            return this.Equals(obj as Magnitude);
        }

        /// <summary>
        /// Returns true if Magnitude instances are equal
        /// </summary>
        /// <param name="other">Instance of Magnitude to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Magnitude other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Scale == other.Scale ||
                    this.Scale != null &&
                    this.Scale.Equals(other.Scale)
                ) && 
                (
                    this.BodyWave == other.BodyWave ||
                    this.BodyWave != null &&
                    this.BodyWave.Equals(other.BodyWave)
                ) && 
                (
                    this.SurfaceWave == other.SurfaceWave ||
                    this.SurfaceWave != null &&
                    this.SurfaceWave.Equals(other.SurfaceWave)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Scale != null)
                    hash = hash * 59 + this.Scale.GetHashCode();
                if (this.BodyWave != null)
                    hash = hash * 59 + this.BodyWave.GetHashCode();
                if (this.SurfaceWave != null)
                    hash = hash * 59 + this.SurfaceWave.GetHashCode();
                return hash;
            }
        }
    }

}
