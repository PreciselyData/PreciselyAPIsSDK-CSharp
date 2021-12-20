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
    /// PoiBoundary
    /// </summary>
    [DataContract]
    public partial class PoiBoundary :  IEquatable<PoiBoundary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoiBoundary" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="Center">Center.</param>
        /// <param name="Countyfips">Countyfips.</param>
        /// <param name="Geometry">Geometry.</param>
        /// <param name="PoiList">PoiList.</param>
        /// <param name="MatchedAddress">MatchedAddress.</param>
        /// <param name="Id">Id.</param>
        public PoiBoundary(string ObjectId = null, GeoZoneGeometry Center = null, string Countyfips = null, CommonGeometry Geometry = null, List<Poi> PoiList = null, MatchedAddress MatchedAddress = null, string Id = null)
        {
            this.ObjectId = ObjectId;
            this.Center = Center;
            this.Countyfips = Countyfips;
            this.Geometry = Geometry;
            this.PoiList = PoiList;
            this.MatchedAddress = MatchedAddress;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets Center
        /// </summary>
        [DataMember(Name="center", EmitDefaultValue=false)]
        public GeoZoneGeometry Center { get; set; }
        /// <summary>
        /// Gets or Sets Countyfips
        /// </summary>
        [DataMember(Name="countyfips", EmitDefaultValue=false)]
        public string Countyfips { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public CommonGeometry Geometry { get; set; }
        /// <summary>
        /// Gets or Sets PoiList
        /// </summary>
        [DataMember(Name="poiList", EmitDefaultValue=false)]
        public List<Poi> PoiList { get; set; }
        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public MatchedAddress MatchedAddress { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoiBoundary {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Center: ").Append(Center).Append("\n");
            sb.Append("  Countyfips: ").Append(Countyfips).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  PoiList: ").Append(PoiList).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as PoiBoundary);
        }

        /// <summary>
        /// Returns true if PoiBoundary instances are equal
        /// </summary>
        /// <param name="other">Instance of PoiBoundary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoiBoundary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ObjectId == other.ObjectId ||
                    this.ObjectId != null &&
                    this.ObjectId.Equals(other.ObjectId)
                ) && 
                (
                    this.Center == other.Center ||
                    this.Center != null &&
                    this.Center.Equals(other.Center)
                ) && 
                (
                    this.Countyfips == other.Countyfips ||
                    this.Countyfips != null &&
                    this.Countyfips.Equals(other.Countyfips)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.PoiList == other.PoiList ||
                    this.PoiList != null &&
                    this.PoiList.SequenceEqual(other.PoiList)
                ) && 
                (
                    this.MatchedAddress == other.MatchedAddress ||
                    this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(other.MatchedAddress)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.ObjectId != null)
                    hash = hash * 59 + this.ObjectId.GetHashCode();
                if (this.Center != null)
                    hash = hash * 59 + this.Center.GetHashCode();
                if (this.Countyfips != null)
                    hash = hash * 59 + this.Countyfips.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.PoiList != null)
                    hash = hash * 59 + this.PoiList.GetHashCode();
                if (this.MatchedAddress != null)
                    hash = hash * 59 + this.MatchedAddress.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}
