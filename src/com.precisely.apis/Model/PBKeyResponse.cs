/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.2
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
    /// PBKeyResponse
    /// </summary>
    [DataContract]
    public partial class PBKeyResponse :  IEquatable<PBKeyResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PBKeyResponse" /> class.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="MatchedAddress">MatchedAddress.</param>
        public PBKeyResponse(string Key = null, MatchedAddress MatchedAddress = null)
        {
            this.Key = Key;
            this.MatchedAddress = MatchedAddress;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public MatchedAddress MatchedAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PBKeyResponse {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
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
            return this.Equals(obj as PBKeyResponse);
        }

        /// <summary>
        /// Returns true if PBKeyResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PBKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PBKeyResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.MatchedAddress == other.MatchedAddress ||
                    this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(other.MatchedAddress)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.MatchedAddress != null)
                    hash = hash * 59 + this.MatchedAddress.GetHashCode();
                return hash;
            }
        }
    }

}
