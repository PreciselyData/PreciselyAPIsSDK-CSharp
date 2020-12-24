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
    /// DemographicsThemes
    /// </summary>
    [DataContract]
    public partial class DemographicsThemes :  IEquatable<DemographicsThemes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DemographicsThemes" /> class.
        /// </summary>
        /// <param name="AgeTheme">AgeTheme.</param>
        /// <param name="GenderTheme">GenderTheme.</param>
        /// <param name="IncomeTheme">IncomeTheme.</param>
        /// <param name="RaceTheme">RaceTheme.</param>
        /// <param name="EthnicityTheme">EthnicityTheme.</param>
        /// <param name="MaritalStatusTheme">MaritalStatusTheme.</param>
        /// <param name="AutomobileTheme">AutomobileTheme.</param>
        /// <param name="PurchasingBehaviorTheme">PurchasingBehaviorTheme.</param>
        /// <param name="EducationalAttainmentTheme">EducationalAttainmentTheme.</param>
        /// <param name="FinancialProductsTheme">FinancialProductsTheme.</param>
        /// <param name="CommuterPatternsTheme">CommuterPatternsTheme.</param>
        /// <param name="AttitudesAndMotivationTheme">AttitudesAndMotivationTheme.</param>
        /// <param name="ChannelPreferencesTheme">ChannelPreferencesTheme.</param>
        /// <param name="HouseholdSizeTheme">HouseholdSizeTheme.</param>
        public DemographicsThemes(AgeTheme AgeTheme = null, GenderTheme GenderTheme = null, IncomeTheme IncomeTheme = null, RaceTheme RaceTheme = null, EthnicityTheme EthnicityTheme = null, MaritalStatusTheme MaritalStatusTheme = null, AutomobileTheme AutomobileTheme = null, PurchasingBehaviorTheme PurchasingBehaviorTheme = null, EducationalAttainmentTheme EducationalAttainmentTheme = null, FinancialProductsTheme FinancialProductsTheme = null, CommuterPatternsTheme CommuterPatternsTheme = null, AttitudesAndMotivationTheme AttitudesAndMotivationTheme = null, ChannelPreferencesTheme ChannelPreferencesTheme = null, HouseholdSizeTheme HouseholdSizeTheme = null)
        {
            this.AgeTheme = AgeTheme;
            this.GenderTheme = GenderTheme;
            this.IncomeTheme = IncomeTheme;
            this.RaceTheme = RaceTheme;
            this.EthnicityTheme = EthnicityTheme;
            this.MaritalStatusTheme = MaritalStatusTheme;
            this.AutomobileTheme = AutomobileTheme;
            this.PurchasingBehaviorTheme = PurchasingBehaviorTheme;
            this.EducationalAttainmentTheme = EducationalAttainmentTheme;
            this.FinancialProductsTheme = FinancialProductsTheme;
            this.CommuterPatternsTheme = CommuterPatternsTheme;
            this.AttitudesAndMotivationTheme = AttitudesAndMotivationTheme;
            this.ChannelPreferencesTheme = ChannelPreferencesTheme;
            this.HouseholdSizeTheme = HouseholdSizeTheme;
        }
        
        /// <summary>
        /// Gets or Sets AgeTheme
        /// </summary>
        [DataMember(Name="ageTheme", EmitDefaultValue=false)]
        public AgeTheme AgeTheme { get; set; }
        /// <summary>
        /// Gets or Sets GenderTheme
        /// </summary>
        [DataMember(Name="genderTheme", EmitDefaultValue=false)]
        public GenderTheme GenderTheme { get; set; }
        /// <summary>
        /// Gets or Sets IncomeTheme
        /// </summary>
        [DataMember(Name="incomeTheme", EmitDefaultValue=false)]
        public IncomeTheme IncomeTheme { get; set; }
        /// <summary>
        /// Gets or Sets RaceTheme
        /// </summary>
        [DataMember(Name="raceTheme", EmitDefaultValue=false)]
        public RaceTheme RaceTheme { get; set; }
        /// <summary>
        /// Gets or Sets EthnicityTheme
        /// </summary>
        [DataMember(Name="ethnicityTheme", EmitDefaultValue=false)]
        public EthnicityTheme EthnicityTheme { get; set; }
        /// <summary>
        /// Gets or Sets MaritalStatusTheme
        /// </summary>
        [DataMember(Name="maritalStatusTheme", EmitDefaultValue=false)]
        public MaritalStatusTheme MaritalStatusTheme { get; set; }
        /// <summary>
        /// Gets or Sets AutomobileTheme
        /// </summary>
        [DataMember(Name="automobileTheme", EmitDefaultValue=false)]
        public AutomobileTheme AutomobileTheme { get; set; }
        /// <summary>
        /// Gets or Sets PurchasingBehaviorTheme
        /// </summary>
        [DataMember(Name="purchasingBehaviorTheme", EmitDefaultValue=false)]
        public PurchasingBehaviorTheme PurchasingBehaviorTheme { get; set; }
        /// <summary>
        /// Gets or Sets EducationalAttainmentTheme
        /// </summary>
        [DataMember(Name="educationalAttainmentTheme", EmitDefaultValue=false)]
        public EducationalAttainmentTheme EducationalAttainmentTheme { get; set; }
        /// <summary>
        /// Gets or Sets FinancialProductsTheme
        /// </summary>
        [DataMember(Name="financialProductsTheme", EmitDefaultValue=false)]
        public FinancialProductsTheme FinancialProductsTheme { get; set; }
        /// <summary>
        /// Gets or Sets CommuterPatternsTheme
        /// </summary>
        [DataMember(Name="commuterPatternsTheme", EmitDefaultValue=false)]
        public CommuterPatternsTheme CommuterPatternsTheme { get; set; }
        /// <summary>
        /// Gets or Sets AttitudesAndMotivationTheme
        /// </summary>
        [DataMember(Name="attitudesAndMotivationTheme", EmitDefaultValue=false)]
        public AttitudesAndMotivationTheme AttitudesAndMotivationTheme { get; set; }
        /// <summary>
        /// Gets or Sets ChannelPreferencesTheme
        /// </summary>
        [DataMember(Name="channelPreferencesTheme", EmitDefaultValue=false)]
        public ChannelPreferencesTheme ChannelPreferencesTheme { get; set; }
        /// <summary>
        /// Gets or Sets HouseholdSizeTheme
        /// </summary>
        [DataMember(Name="householdSizeTheme", EmitDefaultValue=false)]
        public HouseholdSizeTheme HouseholdSizeTheme { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DemographicsThemes {\n");
            sb.Append("  AgeTheme: ").Append(AgeTheme).Append("\n");
            sb.Append("  GenderTheme: ").Append(GenderTheme).Append("\n");
            sb.Append("  IncomeTheme: ").Append(IncomeTheme).Append("\n");
            sb.Append("  RaceTheme: ").Append(RaceTheme).Append("\n");
            sb.Append("  EthnicityTheme: ").Append(EthnicityTheme).Append("\n");
            sb.Append("  MaritalStatusTheme: ").Append(MaritalStatusTheme).Append("\n");
            sb.Append("  AutomobileTheme: ").Append(AutomobileTheme).Append("\n");
            sb.Append("  PurchasingBehaviorTheme: ").Append(PurchasingBehaviorTheme).Append("\n");
            sb.Append("  EducationalAttainmentTheme: ").Append(EducationalAttainmentTheme).Append("\n");
            sb.Append("  FinancialProductsTheme: ").Append(FinancialProductsTheme).Append("\n");
            sb.Append("  CommuterPatternsTheme: ").Append(CommuterPatternsTheme).Append("\n");
            sb.Append("  AttitudesAndMotivationTheme: ").Append(AttitudesAndMotivationTheme).Append("\n");
            sb.Append("  ChannelPreferencesTheme: ").Append(ChannelPreferencesTheme).Append("\n");
            sb.Append("  HouseholdSizeTheme: ").Append(HouseholdSizeTheme).Append("\n");
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
            return this.Equals(obj as DemographicsThemes);
        }

        /// <summary>
        /// Returns true if DemographicsThemes instances are equal
        /// </summary>
        /// <param name="other">Instance of DemographicsThemes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DemographicsThemes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AgeTheme == other.AgeTheme ||
                    this.AgeTheme != null &&
                    this.AgeTheme.Equals(other.AgeTheme)
                ) && 
                (
                    this.GenderTheme == other.GenderTheme ||
                    this.GenderTheme != null &&
                    this.GenderTheme.Equals(other.GenderTheme)
                ) && 
                (
                    this.IncomeTheme == other.IncomeTheme ||
                    this.IncomeTheme != null &&
                    this.IncomeTheme.Equals(other.IncomeTheme)
                ) && 
                (
                    this.RaceTheme == other.RaceTheme ||
                    this.RaceTheme != null &&
                    this.RaceTheme.Equals(other.RaceTheme)
                ) && 
                (
                    this.EthnicityTheme == other.EthnicityTheme ||
                    this.EthnicityTheme != null &&
                    this.EthnicityTheme.Equals(other.EthnicityTheme)
                ) && 
                (
                    this.MaritalStatusTheme == other.MaritalStatusTheme ||
                    this.MaritalStatusTheme != null &&
                    this.MaritalStatusTheme.Equals(other.MaritalStatusTheme)
                ) && 
                (
                    this.AutomobileTheme == other.AutomobileTheme ||
                    this.AutomobileTheme != null &&
                    this.AutomobileTheme.Equals(other.AutomobileTheme)
                ) && 
                (
                    this.PurchasingBehaviorTheme == other.PurchasingBehaviorTheme ||
                    this.PurchasingBehaviorTheme != null &&
                    this.PurchasingBehaviorTheme.Equals(other.PurchasingBehaviorTheme)
                ) && 
                (
                    this.EducationalAttainmentTheme == other.EducationalAttainmentTheme ||
                    this.EducationalAttainmentTheme != null &&
                    this.EducationalAttainmentTheme.Equals(other.EducationalAttainmentTheme)
                ) && 
                (
                    this.FinancialProductsTheme == other.FinancialProductsTheme ||
                    this.FinancialProductsTheme != null &&
                    this.FinancialProductsTheme.Equals(other.FinancialProductsTheme)
                ) && 
                (
                    this.CommuterPatternsTheme == other.CommuterPatternsTheme ||
                    this.CommuterPatternsTheme != null &&
                    this.CommuterPatternsTheme.Equals(other.CommuterPatternsTheme)
                ) && 
                (
                    this.AttitudesAndMotivationTheme == other.AttitudesAndMotivationTheme ||
                    this.AttitudesAndMotivationTheme != null &&
                    this.AttitudesAndMotivationTheme.Equals(other.AttitudesAndMotivationTheme)
                ) && 
                (
                    this.ChannelPreferencesTheme == other.ChannelPreferencesTheme ||
                    this.ChannelPreferencesTheme != null &&
                    this.ChannelPreferencesTheme.Equals(other.ChannelPreferencesTheme)
                ) && 
                (
                    this.HouseholdSizeTheme == other.HouseholdSizeTheme ||
                    this.HouseholdSizeTheme != null &&
                    this.HouseholdSizeTheme.Equals(other.HouseholdSizeTheme)
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
                if (this.AgeTheme != null)
                    hash = hash * 59 + this.AgeTheme.GetHashCode();
                if (this.GenderTheme != null)
                    hash = hash * 59 + this.GenderTheme.GetHashCode();
                if (this.IncomeTheme != null)
                    hash = hash * 59 + this.IncomeTheme.GetHashCode();
                if (this.RaceTheme != null)
                    hash = hash * 59 + this.RaceTheme.GetHashCode();
                if (this.EthnicityTheme != null)
                    hash = hash * 59 + this.EthnicityTheme.GetHashCode();
                if (this.MaritalStatusTheme != null)
                    hash = hash * 59 + this.MaritalStatusTheme.GetHashCode();
                if (this.AutomobileTheme != null)
                    hash = hash * 59 + this.AutomobileTheme.GetHashCode();
                if (this.PurchasingBehaviorTheme != null)
                    hash = hash * 59 + this.PurchasingBehaviorTheme.GetHashCode();
                if (this.EducationalAttainmentTheme != null)
                    hash = hash * 59 + this.EducationalAttainmentTheme.GetHashCode();
                if (this.FinancialProductsTheme != null)
                    hash = hash * 59 + this.FinancialProductsTheme.GetHashCode();
                if (this.CommuterPatternsTheme != null)
                    hash = hash * 59 + this.CommuterPatternsTheme.GetHashCode();
                if (this.AttitudesAndMotivationTheme != null)
                    hash = hash * 59 + this.AttitudesAndMotivationTheme.GetHashCode();
                if (this.ChannelPreferencesTheme != null)
                    hash = hash * 59 + this.ChannelPreferencesTheme.GetHashCode();
                if (this.HouseholdSizeTheme != null)
                    hash = hash * 59 + this.HouseholdSizeTheme.GetHashCode();
                return hash;
            }
        }
    }

}
