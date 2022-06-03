/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.precisely.apis.Client.OpenAPIDateConverter;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// UseTax
    /// </summary>
    [DataContract]
    public partial class UseTax :  IEquatable<UseTax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UseTax" /> class.
        /// </summary>
        /// <param name="specialTaxRulesApplied">specialTaxRulesApplied.</param>
        /// <param name="specialTaxRulesDescriptor">specialTaxRulesDescriptor.</param>
        /// <param name="totalTaxRate">totalTaxRate.</param>
        /// <param name="totalTaxAmount">totalTaxAmount.</param>
        /// <param name="stateTaxRate">stateTaxRate.</param>
        /// <param name="stateTaxAmount">stateTaxAmount.</param>
        /// <param name="countyTaxRate">countyTaxRate.</param>
        /// <param name="countyTaxAmount">countyTaxAmount.</param>
        /// <param name="municipalTaxRate">municipalTaxRate.</param>
        /// <param name="municipalTaxAmount">municipalTaxAmount.</param>
        /// <param name="spdsTax">spdsTax.</param>
        public UseTax(bool specialTaxRulesApplied = default(bool), string specialTaxRulesDescriptor = default(string), double totalTaxRate = default(double), double totalTaxAmount = default(double), double stateTaxRate = default(double), double stateTaxAmount = default(double), double countyTaxRate = default(double), double countyTaxAmount = default(double), double municipalTaxRate = default(double), double municipalTaxAmount = default(double), List<SpecialPurposeDistrictTax> spdsTax = default(List<SpecialPurposeDistrictTax>))
        {
            this.SpecialTaxRulesApplied = specialTaxRulesApplied;
            this.SpecialTaxRulesDescriptor = specialTaxRulesDescriptor;
            this.TotalTaxRate = totalTaxRate;
            this.TotalTaxAmount = totalTaxAmount;
            this.StateTaxRate = stateTaxRate;
            this.StateTaxAmount = stateTaxAmount;
            this.CountyTaxRate = countyTaxRate;
            this.CountyTaxAmount = countyTaxAmount;
            this.MunicipalTaxRate = municipalTaxRate;
            this.MunicipalTaxAmount = municipalTaxAmount;
            this.SpdsTax = spdsTax;
        }

        /// <summary>
        /// Gets or Sets SpecialTaxRulesApplied
        /// </summary>
        [DataMember(Name="specialTaxRulesApplied", EmitDefaultValue=false)]
        public bool SpecialTaxRulesApplied { get; set; }

        /// <summary>
        /// Gets or Sets SpecialTaxRulesDescriptor
        /// </summary>
        [DataMember(Name="specialTaxRulesDescriptor", EmitDefaultValue=false)]
        public string SpecialTaxRulesDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets TotalTaxRate
        /// </summary>
        [DataMember(Name="totalTaxRate", EmitDefaultValue=false)]
        public double TotalTaxRate { get; set; }

        /// <summary>
        /// Gets or Sets TotalTaxAmount
        /// </summary>
        [DataMember(Name="totalTaxAmount", EmitDefaultValue=false)]
        public double TotalTaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets StateTaxRate
        /// </summary>
        [DataMember(Name="stateTaxRate", EmitDefaultValue=false)]
        public double StateTaxRate { get; set; }

        /// <summary>
        /// Gets or Sets StateTaxAmount
        /// </summary>
        [DataMember(Name="stateTaxAmount", EmitDefaultValue=false)]
        public double StateTaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets CountyTaxRate
        /// </summary>
        [DataMember(Name="countyTaxRate", EmitDefaultValue=false)]
        public double CountyTaxRate { get; set; }

        /// <summary>
        /// Gets or Sets CountyTaxAmount
        /// </summary>
        [DataMember(Name="countyTaxAmount", EmitDefaultValue=false)]
        public double CountyTaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets MunicipalTaxRate
        /// </summary>
        [DataMember(Name="municipalTaxRate", EmitDefaultValue=false)]
        public double MunicipalTaxRate { get; set; }

        /// <summary>
        /// Gets or Sets MunicipalTaxAmount
        /// </summary>
        [DataMember(Name="municipalTaxAmount", EmitDefaultValue=false)]
        public double MunicipalTaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets SpdsTax
        /// </summary>
        [DataMember(Name="spdsTax", EmitDefaultValue=false)]
        public List<SpecialPurposeDistrictTax> SpdsTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UseTax {\n");
            sb.Append("  SpecialTaxRulesApplied: ").Append(SpecialTaxRulesApplied).Append("\n");
            sb.Append("  SpecialTaxRulesDescriptor: ").Append(SpecialTaxRulesDescriptor).Append("\n");
            sb.Append("  TotalTaxRate: ").Append(TotalTaxRate).Append("\n");
            sb.Append("  TotalTaxAmount: ").Append(TotalTaxAmount).Append("\n");
            sb.Append("  StateTaxRate: ").Append(StateTaxRate).Append("\n");
            sb.Append("  StateTaxAmount: ").Append(StateTaxAmount).Append("\n");
            sb.Append("  CountyTaxRate: ").Append(CountyTaxRate).Append("\n");
            sb.Append("  CountyTaxAmount: ").Append(CountyTaxAmount).Append("\n");
            sb.Append("  MunicipalTaxRate: ").Append(MunicipalTaxRate).Append("\n");
            sb.Append("  MunicipalTaxAmount: ").Append(MunicipalTaxAmount).Append("\n");
            sb.Append("  SpdsTax: ").Append(SpdsTax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UseTax);
        }

        /// <summary>
        /// Returns true if UseTax instances are equal
        /// </summary>
        /// <param name="input">Instance of UseTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UseTax input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecialTaxRulesApplied == input.SpecialTaxRulesApplied ||
                    (this.SpecialTaxRulesApplied != null &&
                    this.SpecialTaxRulesApplied.Equals(input.SpecialTaxRulesApplied))
                ) && 
                (
                    this.SpecialTaxRulesDescriptor == input.SpecialTaxRulesDescriptor ||
                    (this.SpecialTaxRulesDescriptor != null &&
                    this.SpecialTaxRulesDescriptor.Equals(input.SpecialTaxRulesDescriptor))
                ) && 
                (
                    this.TotalTaxRate == input.TotalTaxRate ||
                    (this.TotalTaxRate != null &&
                    this.TotalTaxRate.Equals(input.TotalTaxRate))
                ) && 
                (
                    this.TotalTaxAmount == input.TotalTaxAmount ||
                    (this.TotalTaxAmount != null &&
                    this.TotalTaxAmount.Equals(input.TotalTaxAmount))
                ) && 
                (
                    this.StateTaxRate == input.StateTaxRate ||
                    (this.StateTaxRate != null &&
                    this.StateTaxRate.Equals(input.StateTaxRate))
                ) && 
                (
                    this.StateTaxAmount == input.StateTaxAmount ||
                    (this.StateTaxAmount != null &&
                    this.StateTaxAmount.Equals(input.StateTaxAmount))
                ) && 
                (
                    this.CountyTaxRate == input.CountyTaxRate ||
                    (this.CountyTaxRate != null &&
                    this.CountyTaxRate.Equals(input.CountyTaxRate))
                ) && 
                (
                    this.CountyTaxAmount == input.CountyTaxAmount ||
                    (this.CountyTaxAmount != null &&
                    this.CountyTaxAmount.Equals(input.CountyTaxAmount))
                ) && 
                (
                    this.MunicipalTaxRate == input.MunicipalTaxRate ||
                    (this.MunicipalTaxRate != null &&
                    this.MunicipalTaxRate.Equals(input.MunicipalTaxRate))
                ) && 
                (
                    this.MunicipalTaxAmount == input.MunicipalTaxAmount ||
                    (this.MunicipalTaxAmount != null &&
                    this.MunicipalTaxAmount.Equals(input.MunicipalTaxAmount))
                ) && 
                (
                    this.SpdsTax == input.SpdsTax ||
                    this.SpdsTax != null &&
                    input.SpdsTax != null &&
                    this.SpdsTax.SequenceEqual(input.SpdsTax)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SpecialTaxRulesApplied != null)
                    hashCode = hashCode * 59 + this.SpecialTaxRulesApplied.GetHashCode();
                if (this.SpecialTaxRulesDescriptor != null)
                    hashCode = hashCode * 59 + this.SpecialTaxRulesDescriptor.GetHashCode();
                if (this.TotalTaxRate != null)
                    hashCode = hashCode * 59 + this.TotalTaxRate.GetHashCode();
                if (this.TotalTaxAmount != null)
                    hashCode = hashCode * 59 + this.TotalTaxAmount.GetHashCode();
                if (this.StateTaxRate != null)
                    hashCode = hashCode * 59 + this.StateTaxRate.GetHashCode();
                if (this.StateTaxAmount != null)
                    hashCode = hashCode * 59 + this.StateTaxAmount.GetHashCode();
                if (this.CountyTaxRate != null)
                    hashCode = hashCode * 59 + this.CountyTaxRate.GetHashCode();
                if (this.CountyTaxAmount != null)
                    hashCode = hashCode * 59 + this.CountyTaxAmount.GetHashCode();
                if (this.MunicipalTaxRate != null)
                    hashCode = hashCode * 59 + this.MunicipalTaxRate.GetHashCode();
                if (this.MunicipalTaxAmount != null)
                    hashCode = hashCode * 59 + this.MunicipalTaxAmount.GetHashCode();
                if (this.SpdsTax != null)
                    hashCode = hashCode * 59 + this.SpdsTax.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
