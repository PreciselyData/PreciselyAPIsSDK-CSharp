/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.3
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
    /// AreaCodeInfo
    /// </summary>
    [DataContract]
    public partial class AreaCodeInfo :  IEquatable<AreaCodeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AreaCodeInfo" /> class.
        /// </summary>
        /// <param name="companyName">companyName.</param>
        /// <param name="ocn">ocn.</param>
        /// <param name="ocnCategory">ocnCategory.</param>
        /// <param name="npa">npa.</param>
        /// <param name="nxx">nxx.</param>
        /// <param name="startRange">startRange.</param>
        /// <param name="endRange">endRange.</param>
        /// <param name="lata">lata.</param>
        /// <param name="areaName4">areaName4.</param>
        public AreaCodeInfo(string companyName = default(string), string ocn = default(string), string ocnCategory = default(string), string npa = default(string), string nxx = default(string), string startRange = default(string), string endRange = default(string), string lata = default(string), string areaName4 = default(string))
        {
            this.CompanyName = companyName;
            this.Ocn = ocn;
            this.OcnCategory = ocnCategory;
            this.Npa = npa;
            this.Nxx = nxx;
            this.StartRange = startRange;
            this.EndRange = endRange;
            this.Lata = lata;
            this.AreaName4 = areaName4;
        }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Ocn
        /// </summary>
        [DataMember(Name="ocn", EmitDefaultValue=false)]
        public string Ocn { get; set; }

        /// <summary>
        /// Gets or Sets OcnCategory
        /// </summary>
        [DataMember(Name="ocnCategory", EmitDefaultValue=false)]
        public string OcnCategory { get; set; }

        /// <summary>
        /// Gets or Sets Npa
        /// </summary>
        [DataMember(Name="npa", EmitDefaultValue=false)]
        public string Npa { get; set; }

        /// <summary>
        /// Gets or Sets Nxx
        /// </summary>
        [DataMember(Name="nxx", EmitDefaultValue=false)]
        public string Nxx { get; set; }

        /// <summary>
        /// Gets or Sets StartRange
        /// </summary>
        [DataMember(Name="startRange", EmitDefaultValue=false)]
        public string StartRange { get; set; }

        /// <summary>
        /// Gets or Sets EndRange
        /// </summary>
        [DataMember(Name="endRange", EmitDefaultValue=false)]
        public string EndRange { get; set; }

        /// <summary>
        /// Gets or Sets Lata
        /// </summary>
        [DataMember(Name="lata", EmitDefaultValue=false)]
        public string Lata { get; set; }

        /// <summary>
        /// Gets or Sets AreaName4
        /// </summary>
        [DataMember(Name="areaName4", EmitDefaultValue=false)]
        public string AreaName4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AreaCodeInfo {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Ocn: ").Append(Ocn).Append("\n");
            sb.Append("  OcnCategory: ").Append(OcnCategory).Append("\n");
            sb.Append("  Npa: ").Append(Npa).Append("\n");
            sb.Append("  Nxx: ").Append(Nxx).Append("\n");
            sb.Append("  StartRange: ").Append(StartRange).Append("\n");
            sb.Append("  EndRange: ").Append(EndRange).Append("\n");
            sb.Append("  Lata: ").Append(Lata).Append("\n");
            sb.Append("  AreaName4: ").Append(AreaName4).Append("\n");
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
            return this.Equals(input as AreaCodeInfo);
        }

        /// <summary>
        /// Returns true if AreaCodeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AreaCodeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AreaCodeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Ocn == input.Ocn ||
                    (this.Ocn != null &&
                    this.Ocn.Equals(input.Ocn))
                ) && 
                (
                    this.OcnCategory == input.OcnCategory ||
                    (this.OcnCategory != null &&
                    this.OcnCategory.Equals(input.OcnCategory))
                ) && 
                (
                    this.Npa == input.Npa ||
                    (this.Npa != null &&
                    this.Npa.Equals(input.Npa))
                ) && 
                (
                    this.Nxx == input.Nxx ||
                    (this.Nxx != null &&
                    this.Nxx.Equals(input.Nxx))
                ) && 
                (
                    this.StartRange == input.StartRange ||
                    (this.StartRange != null &&
                    this.StartRange.Equals(input.StartRange))
                ) && 
                (
                    this.EndRange == input.EndRange ||
                    (this.EndRange != null &&
                    this.EndRange.Equals(input.EndRange))
                ) && 
                (
                    this.Lata == input.Lata ||
                    (this.Lata != null &&
                    this.Lata.Equals(input.Lata))
                ) && 
                (
                    this.AreaName4 == input.AreaName4 ||
                    (this.AreaName4 != null &&
                    this.AreaName4.Equals(input.AreaName4))
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
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Ocn != null)
                    hashCode = hashCode * 59 + this.Ocn.GetHashCode();
                if (this.OcnCategory != null)
                    hashCode = hashCode * 59 + this.OcnCategory.GetHashCode();
                if (this.Npa != null)
                    hashCode = hashCode * 59 + this.Npa.GetHashCode();
                if (this.Nxx != null)
                    hashCode = hashCode * 59 + this.Nxx.GetHashCode();
                if (this.StartRange != null)
                    hashCode = hashCode * 59 + this.StartRange.GetHashCode();
                if (this.EndRange != null)
                    hashCode = hashCode * 59 + this.EndRange.GetHashCode();
                if (this.Lata != null)
                    hashCode = hashCode * 59 + this.Lata.GetHashCode();
                if (this.AreaName4 != null)
                    hashCode = hashCode * 59 + this.AreaName4.GetHashCode();
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
