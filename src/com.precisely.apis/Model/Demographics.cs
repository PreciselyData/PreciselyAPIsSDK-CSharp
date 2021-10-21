/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.6.0
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
    /// Demographics
    /// </summary>
    [DataContract]
    public partial class Demographics :  IEquatable<Demographics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Demographics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Demographics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Demographics" /> class.
        /// </summary>
        /// <param name="Boundaries">Boundaries (required).</param>
        /// <param name="Themes">Themes (required).</param>
        /// <param name="BoundaryThemes">BoundaryThemes.</param>
        public Demographics(Boundaries Boundaries = null, DemographicsThemesV2 Themes = null, List<DemographicsThemesV2> BoundaryThemes = null)
        {
            // to ensure "Boundaries" is required (not null)
            if (Boundaries == null)
            {
                throw new InvalidDataException("Boundaries is a required property for Demographics and cannot be null");
            }
            else
            {
                this.Boundaries = Boundaries;
            }
            // to ensure "Themes" is required (not null)
            if (Themes == null)
            {
                throw new InvalidDataException("Themes is a required property for Demographics and cannot be null");
            }
            else
            {
                this.Themes = Themes;
            }
            this.BoundaryThemes = BoundaryThemes;
        }
        
        /// <summary>
        /// Gets or Sets Boundaries
        /// </summary>
        [DataMember(Name="boundaries", EmitDefaultValue=false)]
        public Boundaries Boundaries { get; set; }
        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public DemographicsThemesV2 Themes { get; set; }
        /// <summary>
        /// Gets or Sets BoundaryThemes
        /// </summary>
        [DataMember(Name="boundaryThemes", EmitDefaultValue=false)]
        public List<DemographicsThemesV2> BoundaryThemes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Demographics {\n");
            sb.Append("  Boundaries: ").Append(Boundaries).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  BoundaryThemes: ").Append(BoundaryThemes).Append("\n");
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
            return this.Equals(obj as Demographics);
        }

        /// <summary>
        /// Returns true if Demographics instances are equal
        /// </summary>
        /// <param name="other">Instance of Demographics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Demographics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Boundaries == other.Boundaries ||
                    this.Boundaries != null &&
                    this.Boundaries.Equals(other.Boundaries)
                ) && 
                (
                    this.Themes == other.Themes ||
                    this.Themes != null &&
                    this.Themes.Equals(other.Themes)
                ) && 
                (
                    this.BoundaryThemes == other.BoundaryThemes ||
                    this.BoundaryThemes != null &&
                    this.BoundaryThemes.SequenceEqual(other.BoundaryThemes)
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
                if (this.Boundaries != null)
                    hash = hash * 59 + this.Boundaries.GetHashCode();
                if (this.Themes != null)
                    hash = hash * 59 + this.Themes.GetHashCode();
                if (this.BoundaryThemes != null)
                    hash = hash * 59 + this.BoundaryThemes.GetHashCode();
                return hash;
            }
        }
    }

}
