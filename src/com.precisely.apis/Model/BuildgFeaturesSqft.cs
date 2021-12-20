/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.8.0
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
    /// BuildgFeaturesSqft
    /// </summary>
    [DataContract]
    public partial class BuildgFeaturesSqft :  IEquatable<BuildgFeaturesSqft>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildgFeaturesSqft" /> class.
        /// </summary>
        /// <param name="FeatureAreaSqft">FeatureAreaSqft.</param>
        /// <param name="AreaIndicator">AreaIndicator.</param>
        /// <param name="Description">Description.</param>
        public BuildgFeaturesSqft(string FeatureAreaSqft = null, string AreaIndicator = null, string Description = null)
        {
            this.FeatureAreaSqft = FeatureAreaSqft;
            this.AreaIndicator = AreaIndicator;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets FeatureAreaSqft
        /// </summary>
        [DataMember(Name="featureAreaSqft", EmitDefaultValue=false)]
        public string FeatureAreaSqft { get; set; }
        /// <summary>
        /// Gets or Sets AreaIndicator
        /// </summary>
        [DataMember(Name="areaIndicator", EmitDefaultValue=false)]
        public string AreaIndicator { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildgFeaturesSqft {\n");
            sb.Append("  FeatureAreaSqft: ").Append(FeatureAreaSqft).Append("\n");
            sb.Append("  AreaIndicator: ").Append(AreaIndicator).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as BuildgFeaturesSqft);
        }

        /// <summary>
        /// Returns true if BuildgFeaturesSqft instances are equal
        /// </summary>
        /// <param name="other">Instance of BuildgFeaturesSqft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildgFeaturesSqft other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FeatureAreaSqft == other.FeatureAreaSqft ||
                    this.FeatureAreaSqft != null &&
                    this.FeatureAreaSqft.Equals(other.FeatureAreaSqft)
                ) && 
                (
                    this.AreaIndicator == other.AreaIndicator ||
                    this.AreaIndicator != null &&
                    this.AreaIndicator.Equals(other.AreaIndicator)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.FeatureAreaSqft != null)
                    hash = hash * 59 + this.FeatureAreaSqft.GetHashCode();
                if (this.AreaIndicator != null)
                    hash = hash * 59 + this.AreaIndicator.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }
    }

}
