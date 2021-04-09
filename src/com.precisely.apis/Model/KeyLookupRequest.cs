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
    /// KeyLookupRequest
    /// </summary>
    [DataContract]
    public partial class KeyLookupRequest :  IEquatable<KeyLookupRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyLookupRequest" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Preferences">Preferences.</param>
        /// <param name="Keys">Keys.</param>
        public KeyLookupRequest(string Type = null, GeocodePreferences Preferences = null, List<Keys> Keys = null)
        {
            this.Type = Type;
            this.Preferences = Preferences;
            this.Keys = Keys;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public GeocodePreferences Preferences { get; set; }
        /// <summary>
        /// Gets or Sets Keys
        /// </summary>
        [DataMember(Name="keys", EmitDefaultValue=false)]
        public List<Keys> Keys { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyLookupRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
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
            return this.Equals(obj as KeyLookupRequest);
        }

        /// <summary>
        /// Returns true if KeyLookupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyLookupRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Preferences == other.Preferences ||
                    this.Preferences != null &&
                    this.Preferences.Equals(other.Preferences)
                ) && 
                (
                    this.Keys == other.Keys ||
                    this.Keys != null &&
                    this.Keys.SequenceEqual(other.Keys)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Preferences != null)
                    hash = hash * 59 + this.Preferences.GetHashCode();
                if (this.Keys != null)
                    hash = hash * 59 + this.Keys.GetHashCode();
                return hash;
            }
        }
    }

}
