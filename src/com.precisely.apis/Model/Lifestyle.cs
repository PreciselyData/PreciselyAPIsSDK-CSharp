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
    /// Lifestyle
    /// </summary>
    [DataContract]
    public partial class Lifestyle :  IEquatable<Lifestyle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lifestyle" /> class.
        /// </summary>
        /// <param name="InternationalType">InternationalType.</param>
        /// <param name="GroupType">GroupType.</param>
        /// <param name="CategoryType">CategoryType.</param>
        /// <param name="Boundary">Boundary.</param>
        public Lifestyle(string InternationalType = null, string GroupType = null, string CategoryType = null, Boundary Boundary = null)
        {
            this.InternationalType = InternationalType;
            this.GroupType = GroupType;
            this.CategoryType = CategoryType;
            this.Boundary = Boundary;
        }
        
        /// <summary>
        /// Gets or Sets InternationalType
        /// </summary>
        [DataMember(Name="internationalType", EmitDefaultValue=false)]
        public string InternationalType { get; set; }
        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public string GroupType { get; set; }
        /// <summary>
        /// Gets or Sets CategoryType
        /// </summary>
        [DataMember(Name="categoryType", EmitDefaultValue=false)]
        public string CategoryType { get; set; }
        /// <summary>
        /// Gets or Sets Boundary
        /// </summary>
        [DataMember(Name="boundary", EmitDefaultValue=false)]
        public Boundary Boundary { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Lifestyle {\n");
            sb.Append("  InternationalType: ").Append(InternationalType).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
            sb.Append("  Boundary: ").Append(Boundary).Append("\n");
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
            return this.Equals(obj as Lifestyle);
        }

        /// <summary>
        /// Returns true if Lifestyle instances are equal
        /// </summary>
        /// <param name="other">Instance of Lifestyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Lifestyle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InternationalType == other.InternationalType ||
                    this.InternationalType != null &&
                    this.InternationalType.Equals(other.InternationalType)
                ) && 
                (
                    this.GroupType == other.GroupType ||
                    this.GroupType != null &&
                    this.GroupType.Equals(other.GroupType)
                ) && 
                (
                    this.CategoryType == other.CategoryType ||
                    this.CategoryType != null &&
                    this.CategoryType.Equals(other.CategoryType)
                ) && 
                (
                    this.Boundary == other.Boundary ||
                    this.Boundary != null &&
                    this.Boundary.Equals(other.Boundary)
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
                if (this.InternationalType != null)
                    hash = hash * 59 + this.InternationalType.GetHashCode();
                if (this.GroupType != null)
                    hash = hash * 59 + this.GroupType.GetHashCode();
                if (this.CategoryType != null)
                    hash = hash * 59 + this.CategoryType.GetHashCode();
                if (this.Boundary != null)
                    hash = hash * 59 + this.Boundary.GetHashCode();
                return hash;
            }
        }
    }

}
