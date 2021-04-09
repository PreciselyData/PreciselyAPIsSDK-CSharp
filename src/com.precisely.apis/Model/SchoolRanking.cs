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
    /// SchoolRanking
    /// </summary>
    [DataContract]
    public partial class SchoolRanking :  IEquatable<SchoolRanking>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolRanking" /> class.
        /// </summary>
        /// <param name="Current">Current.</param>
        /// <param name="RankYear">RankYear.</param>
        /// <param name="StateRank">StateRank.</param>
        /// <param name="NumberOfSchools">NumberOfSchools.</param>
        /// <param name="AvgMathScore">AvgMathScore.</param>
        /// <param name="AvgReadingScore">AvgReadingScore.</param>
        /// <param name="StatePercentileScore">StatePercentileScore.</param>
        public SchoolRanking(string Current = null, string RankYear = null, string StateRank = null, string NumberOfSchools = null, string AvgMathScore = null, string AvgReadingScore = null, string StatePercentileScore = null)
        {
            this.Current = Current;
            this.RankYear = RankYear;
            this.StateRank = StateRank;
            this.NumberOfSchools = NumberOfSchools;
            this.AvgMathScore = AvgMathScore;
            this.AvgReadingScore = AvgReadingScore;
            this.StatePercentileScore = StatePercentileScore;
        }
        
        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public string Current { get; set; }
        /// <summary>
        /// Gets or Sets RankYear
        /// </summary>
        [DataMember(Name="rankYear", EmitDefaultValue=false)]
        public string RankYear { get; set; }
        /// <summary>
        /// Gets or Sets StateRank
        /// </summary>
        [DataMember(Name="stateRank", EmitDefaultValue=false)]
        public string StateRank { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfSchools
        /// </summary>
        [DataMember(Name="numberOfSchools", EmitDefaultValue=false)]
        public string NumberOfSchools { get; set; }
        /// <summary>
        /// Gets or Sets AvgMathScore
        /// </summary>
        [DataMember(Name="avgMathScore", EmitDefaultValue=false)]
        public string AvgMathScore { get; set; }
        /// <summary>
        /// Gets or Sets AvgReadingScore
        /// </summary>
        [DataMember(Name="avgReadingScore", EmitDefaultValue=false)]
        public string AvgReadingScore { get; set; }
        /// <summary>
        /// Gets or Sets StatePercentileScore
        /// </summary>
        [DataMember(Name="statePercentileScore", EmitDefaultValue=false)]
        public string StatePercentileScore { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolRanking {\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  RankYear: ").Append(RankYear).Append("\n");
            sb.Append("  StateRank: ").Append(StateRank).Append("\n");
            sb.Append("  NumberOfSchools: ").Append(NumberOfSchools).Append("\n");
            sb.Append("  AvgMathScore: ").Append(AvgMathScore).Append("\n");
            sb.Append("  AvgReadingScore: ").Append(AvgReadingScore).Append("\n");
            sb.Append("  StatePercentileScore: ").Append(StatePercentileScore).Append("\n");
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
            return this.Equals(obj as SchoolRanking);
        }

        /// <summary>
        /// Returns true if SchoolRanking instances are equal
        /// </summary>
        /// <param name="other">Instance of SchoolRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolRanking other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Current == other.Current ||
                    this.Current != null &&
                    this.Current.Equals(other.Current)
                ) && 
                (
                    this.RankYear == other.RankYear ||
                    this.RankYear != null &&
                    this.RankYear.Equals(other.RankYear)
                ) && 
                (
                    this.StateRank == other.StateRank ||
                    this.StateRank != null &&
                    this.StateRank.Equals(other.StateRank)
                ) && 
                (
                    this.NumberOfSchools == other.NumberOfSchools ||
                    this.NumberOfSchools != null &&
                    this.NumberOfSchools.Equals(other.NumberOfSchools)
                ) && 
                (
                    this.AvgMathScore == other.AvgMathScore ||
                    this.AvgMathScore != null &&
                    this.AvgMathScore.Equals(other.AvgMathScore)
                ) && 
                (
                    this.AvgReadingScore == other.AvgReadingScore ||
                    this.AvgReadingScore != null &&
                    this.AvgReadingScore.Equals(other.AvgReadingScore)
                ) && 
                (
                    this.StatePercentileScore == other.StatePercentileScore ||
                    this.StatePercentileScore != null &&
                    this.StatePercentileScore.Equals(other.StatePercentileScore)
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
                if (this.Current != null)
                    hash = hash * 59 + this.Current.GetHashCode();
                if (this.RankYear != null)
                    hash = hash * 59 + this.RankYear.GetHashCode();
                if (this.StateRank != null)
                    hash = hash * 59 + this.StateRank.GetHashCode();
                if (this.NumberOfSchools != null)
                    hash = hash * 59 + this.NumberOfSchools.GetHashCode();
                if (this.AvgMathScore != null)
                    hash = hash * 59 + this.AvgMathScore.GetHashCode();
                if (this.AvgReadingScore != null)
                    hash = hash * 59 + this.AvgReadingScore.GetHashCode();
                if (this.StatePercentileScore != null)
                    hash = hash * 59 + this.StatePercentileScore.GetHashCode();
                return hash;
            }
        }
    }

}
