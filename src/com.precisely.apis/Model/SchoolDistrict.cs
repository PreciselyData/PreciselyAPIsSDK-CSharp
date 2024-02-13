/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.0.0
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
    /// SchoolDistrict
    /// </summary>
    [DataContract]
    public partial class SchoolDistrict :  IEquatable<SchoolDistrict>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolDistrict" /> class.
        /// </summary>
        /// <param name="ncesDistrictId">ncesDistrictId.</param>
        /// <param name="name">name.</param>
        /// <param name="totalSchools">totalSchools.</param>
        /// <param name="districtType">districtType.</param>
        /// <param name="metro">metro.</param>
        /// <param name="areaInSqM">areaInSqM.</param>
        /// <param name="supervisoryUnionId">supervisoryUnionId.</param>
        /// <param name="districtEnrollment">districtEnrollment.</param>
        /// <param name="districtUrl">districtUrl.</param>
        public SchoolDistrict(string ncesDistrictId = default(string), string name = default(string), string totalSchools = default(string), string districtType = default(string), string metro = default(string), string areaInSqM = default(string), string supervisoryUnionId = default(string), string districtEnrollment = default(string), string districtUrl = default(string))
        {
            this.NcesDistrictId = ncesDistrictId;
            this.Name = name;
            this.TotalSchools = totalSchools;
            this.DistrictType = districtType;
            this.Metro = metro;
            this.AreaInSqM = areaInSqM;
            this.SupervisoryUnionId = supervisoryUnionId;
            this.DistrictEnrollment = districtEnrollment;
            this.DistrictUrl = districtUrl;
        }

        /// <summary>
        /// Gets or Sets NcesDistrictId
        /// </summary>
        [DataMember(Name="ncesDistrictId", EmitDefaultValue=false)]
        public string NcesDistrictId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TotalSchools
        /// </summary>
        [DataMember(Name="totalSchools", EmitDefaultValue=false)]
        public string TotalSchools { get; set; }

        /// <summary>
        /// Gets or Sets DistrictType
        /// </summary>
        [DataMember(Name="districtType", EmitDefaultValue=false)]
        public string DistrictType { get; set; }

        /// <summary>
        /// Gets or Sets Metro
        /// </summary>
        [DataMember(Name="metro", EmitDefaultValue=false)]
        public string Metro { get; set; }

        /// <summary>
        /// Gets or Sets AreaInSqM
        /// </summary>
        [DataMember(Name="areaInSqM", EmitDefaultValue=false)]
        public string AreaInSqM { get; set; }

        /// <summary>
        /// Gets or Sets SupervisoryUnionId
        /// </summary>
        [DataMember(Name="supervisoryUnionId", EmitDefaultValue=false)]
        public string SupervisoryUnionId { get; set; }

        /// <summary>
        /// Gets or Sets DistrictEnrollment
        /// </summary>
        [DataMember(Name="districtEnrollment", EmitDefaultValue=false)]
        public string DistrictEnrollment { get; set; }

        /// <summary>
        /// Gets or Sets DistrictUrl
        /// </summary>
        [DataMember(Name="districtUrl", EmitDefaultValue=false)]
        public string DistrictUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolDistrict {\n");
            sb.Append("  NcesDistrictId: ").Append(NcesDistrictId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TotalSchools: ").Append(TotalSchools).Append("\n");
            sb.Append("  DistrictType: ").Append(DistrictType).Append("\n");
            sb.Append("  Metro: ").Append(Metro).Append("\n");
            sb.Append("  AreaInSqM: ").Append(AreaInSqM).Append("\n");
            sb.Append("  SupervisoryUnionId: ").Append(SupervisoryUnionId).Append("\n");
            sb.Append("  DistrictEnrollment: ").Append(DistrictEnrollment).Append("\n");
            sb.Append("  DistrictUrl: ").Append(DistrictUrl).Append("\n");
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
            return this.Equals(input as SchoolDistrict);
        }

        /// <summary>
        /// Returns true if SchoolDistrict instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolDistrict to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolDistrict input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NcesDistrictId == input.NcesDistrictId ||
                    (this.NcesDistrictId != null &&
                    this.NcesDistrictId.Equals(input.NcesDistrictId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TotalSchools == input.TotalSchools ||
                    (this.TotalSchools != null &&
                    this.TotalSchools.Equals(input.TotalSchools))
                ) && 
                (
                    this.DistrictType == input.DistrictType ||
                    (this.DistrictType != null &&
                    this.DistrictType.Equals(input.DistrictType))
                ) && 
                (
                    this.Metro == input.Metro ||
                    (this.Metro != null &&
                    this.Metro.Equals(input.Metro))
                ) && 
                (
                    this.AreaInSqM == input.AreaInSqM ||
                    (this.AreaInSqM != null &&
                    this.AreaInSqM.Equals(input.AreaInSqM))
                ) && 
                (
                    this.SupervisoryUnionId == input.SupervisoryUnionId ||
                    (this.SupervisoryUnionId != null &&
                    this.SupervisoryUnionId.Equals(input.SupervisoryUnionId))
                ) && 
                (
                    this.DistrictEnrollment == input.DistrictEnrollment ||
                    (this.DistrictEnrollment != null &&
                    this.DistrictEnrollment.Equals(input.DistrictEnrollment))
                ) && 
                (
                    this.DistrictUrl == input.DistrictUrl ||
                    (this.DistrictUrl != null &&
                    this.DistrictUrl.Equals(input.DistrictUrl))
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
                if (this.NcesDistrictId != null)
                    hashCode = hashCode * 59 + this.NcesDistrictId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TotalSchools != null)
                    hashCode = hashCode * 59 + this.TotalSchools.GetHashCode();
                if (this.DistrictType != null)
                    hashCode = hashCode * 59 + this.DistrictType.GetHashCode();
                if (this.Metro != null)
                    hashCode = hashCode * 59 + this.Metro.GetHashCode();
                if (this.AreaInSqM != null)
                    hashCode = hashCode * 59 + this.AreaInSqM.GetHashCode();
                if (this.SupervisoryUnionId != null)
                    hashCode = hashCode * 59 + this.SupervisoryUnionId.GetHashCode();
                if (this.DistrictEnrollment != null)
                    hashCode = hashCode * 59 + this.DistrictEnrollment.GetHashCode();
                if (this.DistrictUrl != null)
                    hashCode = hashCode * 59 + this.DistrictUrl.GetHashCode();
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
