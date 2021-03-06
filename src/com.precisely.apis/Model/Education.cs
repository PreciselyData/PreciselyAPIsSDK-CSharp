/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.1
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
    /// Education
    /// </summary>
    [DataContract]
    public partial class Education :  IEquatable<Education>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Education" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Degree">Degree.</param>
        /// <param name="End">End.</param>
        public Education(string Name = null, string Degree = null, End End = null)
        {
            this.Name = Name;
            this.Degree = Degree;
            this.End = End;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Degree
        /// </summary>
        [DataMember(Name="degree", EmitDefaultValue=false)]
        public string Degree { get; set; }
        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public End End { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Education {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Degree: ").Append(Degree).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(obj as Education);
        }

        /// <summary>
        /// Returns true if Education instances are equal
        /// </summary>
        /// <param name="other">Instance of Education to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Education other)
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
                    this.Degree == other.Degree ||
                    this.Degree != null &&
                    this.Degree.Equals(other.Degree)
                ) && 
                (
                    this.End == other.End ||
                    this.End != null &&
                    this.End.Equals(other.End)
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
                if (this.Degree != null)
                    hash = hash * 59 + this.Degree.GetHashCode();
                if (this.End != null)
                    hash = hash * 59 + this.End.GetHashCode();
                return hash;
            }
        }
    }

}
