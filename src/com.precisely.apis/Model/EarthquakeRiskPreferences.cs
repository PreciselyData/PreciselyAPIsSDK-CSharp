/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.0.0
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
    /// EarthquakeRiskPreferences
    /// </summary>
    [DataContract]
    public partial class EarthquakeRiskPreferences :  IEquatable<EarthquakeRiskPreferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarthquakeRiskPreferences" /> class.
        /// </summary>
        /// <param name="IncludeGeometry">IncludeGeometry.</param>
        /// <param name="RichterValue">RichterValue.</param>
        public EarthquakeRiskPreferences(string IncludeGeometry = null, string RichterValue = null)
        {
            this.IncludeGeometry = IncludeGeometry;
            this.RichterValue = RichterValue;
        }
        
        /// <summary>
        /// Gets or Sets IncludeGeometry
        /// </summary>
        [DataMember(Name="includeGeometry", EmitDefaultValue=false)]
        public string IncludeGeometry { get; set; }
        /// <summary>
        /// Gets or Sets RichterValue
        /// </summary>
        [DataMember(Name="richterValue", EmitDefaultValue=false)]
        public string RichterValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarthquakeRiskPreferences {\n");
            sb.Append("  IncludeGeometry: ").Append(IncludeGeometry).Append("\n");
            sb.Append("  RichterValue: ").Append(RichterValue).Append("\n");
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
            return this.Equals(obj as EarthquakeRiskPreferences);
        }

        /// <summary>
        /// Returns true if EarthquakeRiskPreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of EarthquakeRiskPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarthquakeRiskPreferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IncludeGeometry == other.IncludeGeometry ||
                    this.IncludeGeometry != null &&
                    this.IncludeGeometry.Equals(other.IncludeGeometry)
                ) && 
                (
                    this.RichterValue == other.RichterValue ||
                    this.RichterValue != null &&
                    this.RichterValue.Equals(other.RichterValue)
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
                if (this.IncludeGeometry != null)
                    hash = hash * 59 + this.IncludeGeometry.GetHashCode();
                if (this.RichterValue != null)
                    hash = hash * 59 + this.RichterValue.GetHashCode();
                return hash;
            }
        }
    }

}
