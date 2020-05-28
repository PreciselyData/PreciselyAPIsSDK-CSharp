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
    /// GradeLevelsTaught
    /// </summary>
    [DataContract]
    public partial class GradeLevelsTaught :  IEquatable<GradeLevelsTaught>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GradeLevelsTaught" /> class.
        /// </summary>
        /// <param name="Pk">Pk.</param>
        /// <param name="Kg">Kg.</param>
        /// <param name="First">First.</param>
        /// <param name="Second">Second.</param>
        /// <param name="Third">Third.</param>
        /// <param name="Fourth">Fourth.</param>
        /// <param name="Fifth">Fifth.</param>
        /// <param name="Sixth">Sixth.</param>
        /// <param name="Seventh">Seventh.</param>
        /// <param name="Eighth">Eighth.</param>
        /// <param name="Ninth">Ninth.</param>
        /// <param name="Tenth">Tenth.</param>
        /// <param name="Eleventh">Eleventh.</param>
        /// <param name="Twelfth">Twelfth.</param>
        public GradeLevelsTaught(string Pk = null, string Kg = null, string First = null, string Second = null, string Third = null, string Fourth = null, string Fifth = null, string Sixth = null, string Seventh = null, string Eighth = null, string Ninth = null, string Tenth = null, string Eleventh = null, string Twelfth = null)
        {
            this.Pk = Pk;
            this.Kg = Kg;
            this.First = First;
            this.Second = Second;
            this.Third = Third;
            this.Fourth = Fourth;
            this.Fifth = Fifth;
            this.Sixth = Sixth;
            this.Seventh = Seventh;
            this.Eighth = Eighth;
            this.Ninth = Ninth;
            this.Tenth = Tenth;
            this.Eleventh = Eleventh;
            this.Twelfth = Twelfth;
        }
        
        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name="pk", EmitDefaultValue=false)]
        public string Pk { get; set; }
        /// <summary>
        /// Gets or Sets Kg
        /// </summary>
        [DataMember(Name="kg", EmitDefaultValue=false)]
        public string Kg { get; set; }
        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public string First { get; set; }
        /// <summary>
        /// Gets or Sets Second
        /// </summary>
        [DataMember(Name="second", EmitDefaultValue=false)]
        public string Second { get; set; }
        /// <summary>
        /// Gets or Sets Third
        /// </summary>
        [DataMember(Name="third", EmitDefaultValue=false)]
        public string Third { get; set; }
        /// <summary>
        /// Gets or Sets Fourth
        /// </summary>
        [DataMember(Name="fourth", EmitDefaultValue=false)]
        public string Fourth { get; set; }
        /// <summary>
        /// Gets or Sets Fifth
        /// </summary>
        [DataMember(Name="fifth", EmitDefaultValue=false)]
        public string Fifth { get; set; }
        /// <summary>
        /// Gets or Sets Sixth
        /// </summary>
        [DataMember(Name="sixth", EmitDefaultValue=false)]
        public string Sixth { get; set; }
        /// <summary>
        /// Gets or Sets Seventh
        /// </summary>
        [DataMember(Name="seventh", EmitDefaultValue=false)]
        public string Seventh { get; set; }
        /// <summary>
        /// Gets or Sets Eighth
        /// </summary>
        [DataMember(Name="eighth", EmitDefaultValue=false)]
        public string Eighth { get; set; }
        /// <summary>
        /// Gets or Sets Ninth
        /// </summary>
        [DataMember(Name="ninth", EmitDefaultValue=false)]
        public string Ninth { get; set; }
        /// <summary>
        /// Gets or Sets Tenth
        /// </summary>
        [DataMember(Name="tenth", EmitDefaultValue=false)]
        public string Tenth { get; set; }
        /// <summary>
        /// Gets or Sets Eleventh
        /// </summary>
        [DataMember(Name="eleventh", EmitDefaultValue=false)]
        public string Eleventh { get; set; }
        /// <summary>
        /// Gets or Sets Twelfth
        /// </summary>
        [DataMember(Name="twelfth", EmitDefaultValue=false)]
        public string Twelfth { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GradeLevelsTaught {\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  Kg: ").Append(Kg).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Second: ").Append(Second).Append("\n");
            sb.Append("  Third: ").Append(Third).Append("\n");
            sb.Append("  Fourth: ").Append(Fourth).Append("\n");
            sb.Append("  Fifth: ").Append(Fifth).Append("\n");
            sb.Append("  Sixth: ").Append(Sixth).Append("\n");
            sb.Append("  Seventh: ").Append(Seventh).Append("\n");
            sb.Append("  Eighth: ").Append(Eighth).Append("\n");
            sb.Append("  Ninth: ").Append(Ninth).Append("\n");
            sb.Append("  Tenth: ").Append(Tenth).Append("\n");
            sb.Append("  Eleventh: ").Append(Eleventh).Append("\n");
            sb.Append("  Twelfth: ").Append(Twelfth).Append("\n");
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
            return this.Equals(obj as GradeLevelsTaught);
        }

        /// <summary>
        /// Returns true if GradeLevelsTaught instances are equal
        /// </summary>
        /// <param name="other">Instance of GradeLevelsTaught to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GradeLevelsTaught other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Pk == other.Pk ||
                    this.Pk != null &&
                    this.Pk.Equals(other.Pk)
                ) && 
                (
                    this.Kg == other.Kg ||
                    this.Kg != null &&
                    this.Kg.Equals(other.Kg)
                ) && 
                (
                    this.First == other.First ||
                    this.First != null &&
                    this.First.Equals(other.First)
                ) && 
                (
                    this.Second == other.Second ||
                    this.Second != null &&
                    this.Second.Equals(other.Second)
                ) && 
                (
                    this.Third == other.Third ||
                    this.Third != null &&
                    this.Third.Equals(other.Third)
                ) && 
                (
                    this.Fourth == other.Fourth ||
                    this.Fourth != null &&
                    this.Fourth.Equals(other.Fourth)
                ) && 
                (
                    this.Fifth == other.Fifth ||
                    this.Fifth != null &&
                    this.Fifth.Equals(other.Fifth)
                ) && 
                (
                    this.Sixth == other.Sixth ||
                    this.Sixth != null &&
                    this.Sixth.Equals(other.Sixth)
                ) && 
                (
                    this.Seventh == other.Seventh ||
                    this.Seventh != null &&
                    this.Seventh.Equals(other.Seventh)
                ) && 
                (
                    this.Eighth == other.Eighth ||
                    this.Eighth != null &&
                    this.Eighth.Equals(other.Eighth)
                ) && 
                (
                    this.Ninth == other.Ninth ||
                    this.Ninth != null &&
                    this.Ninth.Equals(other.Ninth)
                ) && 
                (
                    this.Tenth == other.Tenth ||
                    this.Tenth != null &&
                    this.Tenth.Equals(other.Tenth)
                ) && 
                (
                    this.Eleventh == other.Eleventh ||
                    this.Eleventh != null &&
                    this.Eleventh.Equals(other.Eleventh)
                ) && 
                (
                    this.Twelfth == other.Twelfth ||
                    this.Twelfth != null &&
                    this.Twelfth.Equals(other.Twelfth)
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
                if (this.Pk != null)
                    hash = hash * 59 + this.Pk.GetHashCode();
                if (this.Kg != null)
                    hash = hash * 59 + this.Kg.GetHashCode();
                if (this.First != null)
                    hash = hash * 59 + this.First.GetHashCode();
                if (this.Second != null)
                    hash = hash * 59 + this.Second.GetHashCode();
                if (this.Third != null)
                    hash = hash * 59 + this.Third.GetHashCode();
                if (this.Fourth != null)
                    hash = hash * 59 + this.Fourth.GetHashCode();
                if (this.Fifth != null)
                    hash = hash * 59 + this.Fifth.GetHashCode();
                if (this.Sixth != null)
                    hash = hash * 59 + this.Sixth.GetHashCode();
                if (this.Seventh != null)
                    hash = hash * 59 + this.Seventh.GetHashCode();
                if (this.Eighth != null)
                    hash = hash * 59 + this.Eighth.GetHashCode();
                if (this.Ninth != null)
                    hash = hash * 59 + this.Ninth.GetHashCode();
                if (this.Tenth != null)
                    hash = hash * 59 + this.Tenth.GetHashCode();
                if (this.Eleventh != null)
                    hash = hash * 59 + this.Eleventh.GetHashCode();
                if (this.Twelfth != null)
                    hash = hash * 59 + this.Twelfth.GetHashCode();
                return hash;
            }
        }
    }

}
