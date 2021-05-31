/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.1
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
    /// StudentEthnicity
    /// </summary>
    [DataContract]
    public partial class StudentEthnicity :  IEquatable<StudentEthnicity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentEthnicity" /> class.
        /// </summary>
        /// <param name="IndianAlaskaNative">IndianAlaskaNative.</param>
        /// <param name="Asian">Asian.</param>
        /// <param name="Hispanic">Hispanic.</param>
        /// <param name="Black">Black.</param>
        /// <param name="White">White.</param>
        /// <param name="HawaiianPacificlslander">HawaiianPacificlslander.</param>
        /// <param name="TwoOrMoreRaces">TwoOrMoreRaces.</param>
        public StudentEthnicity(string IndianAlaskaNative = null, string Asian = null, string Hispanic = null, string Black = null, string White = null, string HawaiianPacificlslander = null, string TwoOrMoreRaces = null)
        {
            this.IndianAlaskaNative = IndianAlaskaNative;
            this.Asian = Asian;
            this.Hispanic = Hispanic;
            this.Black = Black;
            this.White = White;
            this.HawaiianPacificlslander = HawaiianPacificlslander;
            this.TwoOrMoreRaces = TwoOrMoreRaces;
        }
        
        /// <summary>
        /// Gets or Sets IndianAlaskaNative
        /// </summary>
        [DataMember(Name="indianAlaskaNative", EmitDefaultValue=false)]
        public string IndianAlaskaNative { get; set; }
        /// <summary>
        /// Gets or Sets Asian
        /// </summary>
        [DataMember(Name="asian", EmitDefaultValue=false)]
        public string Asian { get; set; }
        /// <summary>
        /// Gets or Sets Hispanic
        /// </summary>
        [DataMember(Name="hispanic", EmitDefaultValue=false)]
        public string Hispanic { get; set; }
        /// <summary>
        /// Gets or Sets Black
        /// </summary>
        [DataMember(Name="black", EmitDefaultValue=false)]
        public string Black { get; set; }
        /// <summary>
        /// Gets or Sets White
        /// </summary>
        [DataMember(Name="white", EmitDefaultValue=false)]
        public string White { get; set; }
        /// <summary>
        /// Gets or Sets HawaiianPacificlslander
        /// </summary>
        [DataMember(Name="hawaiianPacificlslander", EmitDefaultValue=false)]
        public string HawaiianPacificlslander { get; set; }
        /// <summary>
        /// Gets or Sets TwoOrMoreRaces
        /// </summary>
        [DataMember(Name="twoOrMoreRaces", EmitDefaultValue=false)]
        public string TwoOrMoreRaces { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentEthnicity {\n");
            sb.Append("  IndianAlaskaNative: ").Append(IndianAlaskaNative).Append("\n");
            sb.Append("  Asian: ").Append(Asian).Append("\n");
            sb.Append("  Hispanic: ").Append(Hispanic).Append("\n");
            sb.Append("  Black: ").Append(Black).Append("\n");
            sb.Append("  White: ").Append(White).Append("\n");
            sb.Append("  HawaiianPacificlslander: ").Append(HawaiianPacificlslander).Append("\n");
            sb.Append("  TwoOrMoreRaces: ").Append(TwoOrMoreRaces).Append("\n");
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
            return this.Equals(obj as StudentEthnicity);
        }

        /// <summary>
        /// Returns true if StudentEthnicity instances are equal
        /// </summary>
        /// <param name="other">Instance of StudentEthnicity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentEthnicity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IndianAlaskaNative == other.IndianAlaskaNative ||
                    this.IndianAlaskaNative != null &&
                    this.IndianAlaskaNative.Equals(other.IndianAlaskaNative)
                ) && 
                (
                    this.Asian == other.Asian ||
                    this.Asian != null &&
                    this.Asian.Equals(other.Asian)
                ) && 
                (
                    this.Hispanic == other.Hispanic ||
                    this.Hispanic != null &&
                    this.Hispanic.Equals(other.Hispanic)
                ) && 
                (
                    this.Black == other.Black ||
                    this.Black != null &&
                    this.Black.Equals(other.Black)
                ) && 
                (
                    this.White == other.White ||
                    this.White != null &&
                    this.White.Equals(other.White)
                ) && 
                (
                    this.HawaiianPacificlslander == other.HawaiianPacificlslander ||
                    this.HawaiianPacificlslander != null &&
                    this.HawaiianPacificlslander.Equals(other.HawaiianPacificlslander)
                ) && 
                (
                    this.TwoOrMoreRaces == other.TwoOrMoreRaces ||
                    this.TwoOrMoreRaces != null &&
                    this.TwoOrMoreRaces.Equals(other.TwoOrMoreRaces)
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
                if (this.IndianAlaskaNative != null)
                    hash = hash * 59 + this.IndianAlaskaNative.GetHashCode();
                if (this.Asian != null)
                    hash = hash * 59 + this.Asian.GetHashCode();
                if (this.Hispanic != null)
                    hash = hash * 59 + this.Hispanic.GetHashCode();
                if (this.Black != null)
                    hash = hash * 59 + this.Black.GetHashCode();
                if (this.White != null)
                    hash = hash * 59 + this.White.GetHashCode();
                if (this.HawaiianPacificlslander != null)
                    hash = hash * 59 + this.HawaiianPacificlslander.GetHashCode();
                if (this.TwoOrMoreRaces != null)
                    hash = hash * 59 + this.TwoOrMoreRaces.GetHashCode();
                return hash;
            }
        }
    }

}
