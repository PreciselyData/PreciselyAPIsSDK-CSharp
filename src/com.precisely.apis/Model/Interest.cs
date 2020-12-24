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
    /// Interest
    /// </summary>
    [DataContract]
    public partial class Interest :  IEquatable<Interest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interest" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Affinity">Affinity.</param>
        /// <param name="ParentIds">ParentIds.</param>
        /// <param name="Category">Category.</param>
        public Interest(string Name = null, string Id = null, string Affinity = null, List<string> ParentIds = null, string Category = null)
        {
            this.Name = Name;
            this.Id = Id;
            this.Affinity = Affinity;
            this.ParentIds = ParentIds;
            this.Category = Category;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Affinity
        /// </summary>
        [DataMember(Name="affinity", EmitDefaultValue=false)]
        public string Affinity { get; set; }
        /// <summary>
        /// Gets or Sets ParentIds
        /// </summary>
        [DataMember(Name="parentIds", EmitDefaultValue=false)]
        public List<string> ParentIds { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Interest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Affinity: ").Append(Affinity).Append("\n");
            sb.Append("  ParentIds: ").Append(ParentIds).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as Interest);
        }

        /// <summary>
        /// Returns true if Interest instances are equal
        /// </summary>
        /// <param name="other">Instance of Interest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Interest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Affinity == other.Affinity ||
                    this.Affinity != null &&
                    this.Affinity.Equals(other.Affinity)
                ) && 
                (
                    this.ParentIds == other.ParentIds ||
                    this.ParentIds != null &&
                    this.ParentIds.SequenceEqual(other.ParentIds)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Affinity != null)
                    hash = hash * 59 + this.Affinity.GetHashCode();
                if (this.ParentIds != null)
                    hash = hash * 59 + this.ParentIds.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                return hash;
            }
        }
    }

}
