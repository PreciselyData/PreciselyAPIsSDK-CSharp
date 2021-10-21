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
    /// TaxJurisdiction
    /// </summary>
    [DataContract]
    public partial class TaxJurisdiction :  IEquatable<TaxJurisdiction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxJurisdiction" /> class.
        /// </summary>
        /// <param name="State">State.</param>
        /// <param name="County">County.</param>
        /// <param name="Place">Place.</param>
        /// <param name="Spds">Spds.</param>
        public TaxJurisdiction(TaxState State = null, TaxCounty County = null, TaxPlace Place = null, List<SpecialPurposeDistrict> Spds = null)
        {
            this.State = State;
            this.County = County;
            this.Place = Place;
            this.Spds = Spds;
        }
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public TaxState State { get; set; }
        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public TaxCounty County { get; set; }
        /// <summary>
        /// Gets or Sets Place
        /// </summary>
        [DataMember(Name="place", EmitDefaultValue=false)]
        public TaxPlace Place { get; set; }
        /// <summary>
        /// Gets or Sets Spds
        /// </summary>
        [DataMember(Name="spds", EmitDefaultValue=false)]
        public List<SpecialPurposeDistrict> Spds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxJurisdiction {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Place: ").Append(Place).Append("\n");
            sb.Append("  Spds: ").Append(Spds).Append("\n");
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
            return this.Equals(obj as TaxJurisdiction);
        }

        /// <summary>
        /// Returns true if TaxJurisdiction instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxJurisdiction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxJurisdiction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.Place == other.Place ||
                    this.Place != null &&
                    this.Place.Equals(other.Place)
                ) && 
                (
                    this.Spds == other.Spds ||
                    this.Spds != null &&
                    this.Spds.SequenceEqual(other.Spds)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.Place != null)
                    hash = hash * 59 + this.Place.GetHashCode();
                if (this.Spds != null)
                    hash = hash * 59 + this.Spds.GetHashCode();
                return hash;
            }
        }
    }

}
