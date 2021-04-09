/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.0
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
    /// Coverage
    /// </summary>
    [DataContract]
    public partial class Coverage :  IEquatable<Coverage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coverage" /> class.
        /// </summary>
        /// <param name="Area">Area.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="Exceptions">Exceptions.</param>
        public Coverage(string Area = null, string Comments = null, string Exceptions = null)
        {
            this.Area = Area;
            this.Comments = Comments;
            this.Exceptions = Exceptions;
        }
        
        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public string Area { get; set; }
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }
        /// <summary>
        /// Gets or Sets Exceptions
        /// </summary>
        [DataMember(Name="exceptions", EmitDefaultValue=false)]
        public string Exceptions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Coverage {\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Exceptions: ").Append(Exceptions).Append("\n");
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
            return this.Equals(obj as Coverage);
        }

        /// <summary>
        /// Returns true if Coverage instances are equal
        /// </summary>
        /// <param name="other">Instance of Coverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Coverage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Area == other.Area ||
                    this.Area != null &&
                    this.Area.Equals(other.Area)
                ) && 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.Exceptions == other.Exceptions ||
                    this.Exceptions != null &&
                    this.Exceptions.Equals(other.Exceptions)
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
                if (this.Area != null)
                    hash = hash * 59 + this.Area.GetHashCode();
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.Exceptions != null)
                    hash = hash * 59 + this.Exceptions.GetHashCode();
                return hash;
            }
        }
    }

}
