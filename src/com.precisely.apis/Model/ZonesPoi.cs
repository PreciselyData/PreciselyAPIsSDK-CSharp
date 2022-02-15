/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.2
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
    /// ZonesPoi
    /// </summary>
    [DataContract]
    public partial class ZonesPoi :  IEquatable<ZonesPoi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZonesPoi" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="brandName">brandName.</param>
        /// <param name="tradeName">tradeName.</param>
        /// <param name="franchiseName">franchiseName.</param>
        /// <param name="open24Hours">open24Hours.</param>
        /// <param name="contactDetails">contactDetails.</param>
        /// <param name="poiClassification">poiClassification.</param>
        /// <param name="employeeCount">employeeCount.</param>
        /// <param name="organizationStatusCode">organizationStatusCode.</param>
        /// <param name="organizationStatusCodeDescription">organizationStatusCodeDescription.</param>
        /// <param name="parentBusiness">parentBusiness.</param>
        /// <param name="tickerSymbol">tickerSymbol.</param>
        /// <param name="exchangeName">exchangeName.</param>
        public ZonesPoi(string id = default(string), string name = default(string), string brandName = default(string), string tradeName = default(string), string franchiseName = default(string), string open24Hours = default(string), ZonesContactDetails contactDetails = default(ZonesContactDetails), ZonesPoiClassification poiClassification = default(ZonesPoiClassification), EmployeeCount employeeCount = default(EmployeeCount), string organizationStatusCode = default(string), string organizationStatusCodeDescription = default(string), ZonesParentBusiness parentBusiness = default(ZonesParentBusiness), string tickerSymbol = default(string), string exchangeName = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.BrandName = brandName;
            this.TradeName = tradeName;
            this.FranchiseName = franchiseName;
            this.Open24Hours = open24Hours;
            this.ContactDetails = contactDetails;
            this.PoiClassification = poiClassification;
            this.EmployeeCount = employeeCount;
            this.OrganizationStatusCode = organizationStatusCode;
            this.OrganizationStatusCodeDescription = organizationStatusCodeDescription;
            this.ParentBusiness = parentBusiness;
            this.TickerSymbol = tickerSymbol;
            this.ExchangeName = exchangeName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets BrandName
        /// </summary>
        [DataMember(Name="brandName", EmitDefaultValue=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// Gets or Sets TradeName
        /// </summary>
        [DataMember(Name="tradeName", EmitDefaultValue=false)]
        public string TradeName { get; set; }

        /// <summary>
        /// Gets or Sets FranchiseName
        /// </summary>
        [DataMember(Name="franchiseName", EmitDefaultValue=false)]
        public string FranchiseName { get; set; }

        /// <summary>
        /// Gets or Sets Open24Hours
        /// </summary>
        [DataMember(Name="open24Hours", EmitDefaultValue=false)]
        public string Open24Hours { get; set; }

        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name="contactDetails", EmitDefaultValue=false)]
        public ZonesContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Gets or Sets PoiClassification
        /// </summary>
        [DataMember(Name="poiClassification", EmitDefaultValue=false)]
        public ZonesPoiClassification PoiClassification { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeCount
        /// </summary>
        [DataMember(Name="employeeCount", EmitDefaultValue=false)]
        public EmployeeCount EmployeeCount { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationStatusCode
        /// </summary>
        [DataMember(Name="organizationStatusCode", EmitDefaultValue=false)]
        public string OrganizationStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationStatusCodeDescription
        /// </summary>
        [DataMember(Name="organizationStatusCodeDescription", EmitDefaultValue=false)]
        public string OrganizationStatusCodeDescription { get; set; }

        /// <summary>
        /// Gets or Sets ParentBusiness
        /// </summary>
        [DataMember(Name="parentBusiness", EmitDefaultValue=false)]
        public ZonesParentBusiness ParentBusiness { get; set; }

        /// <summary>
        /// Gets or Sets TickerSymbol
        /// </summary>
        [DataMember(Name="tickerSymbol", EmitDefaultValue=false)]
        public string TickerSymbol { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeName
        /// </summary>
        [DataMember(Name="exchangeName", EmitDefaultValue=false)]
        public string ExchangeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZonesPoi {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  TradeName: ").Append(TradeName).Append("\n");
            sb.Append("  FranchiseName: ").Append(FranchiseName).Append("\n");
            sb.Append("  Open24Hours: ").Append(Open24Hours).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  PoiClassification: ").Append(PoiClassification).Append("\n");
            sb.Append("  EmployeeCount: ").Append(EmployeeCount).Append("\n");
            sb.Append("  OrganizationStatusCode: ").Append(OrganizationStatusCode).Append("\n");
            sb.Append("  OrganizationStatusCodeDescription: ").Append(OrganizationStatusCodeDescription).Append("\n");
            sb.Append("  ParentBusiness: ").Append(ParentBusiness).Append("\n");
            sb.Append("  TickerSymbol: ").Append(TickerSymbol).Append("\n");
            sb.Append("  ExchangeName: ").Append(ExchangeName).Append("\n");
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
            return this.Equals(input as ZonesPoi);
        }

        /// <summary>
        /// Returns true if ZonesPoi instances are equal
        /// </summary>
        /// <param name="input">Instance of ZonesPoi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZonesPoi input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.TradeName == input.TradeName ||
                    (this.TradeName != null &&
                    this.TradeName.Equals(input.TradeName))
                ) && 
                (
                    this.FranchiseName == input.FranchiseName ||
                    (this.FranchiseName != null &&
                    this.FranchiseName.Equals(input.FranchiseName))
                ) && 
                (
                    this.Open24Hours == input.Open24Hours ||
                    (this.Open24Hours != null &&
                    this.Open24Hours.Equals(input.Open24Hours))
                ) && 
                (
                    this.ContactDetails == input.ContactDetails ||
                    (this.ContactDetails != null &&
                    this.ContactDetails.Equals(input.ContactDetails))
                ) && 
                (
                    this.PoiClassification == input.PoiClassification ||
                    (this.PoiClassification != null &&
                    this.PoiClassification.Equals(input.PoiClassification))
                ) && 
                (
                    this.EmployeeCount == input.EmployeeCount ||
                    (this.EmployeeCount != null &&
                    this.EmployeeCount.Equals(input.EmployeeCount))
                ) && 
                (
                    this.OrganizationStatusCode == input.OrganizationStatusCode ||
                    (this.OrganizationStatusCode != null &&
                    this.OrganizationStatusCode.Equals(input.OrganizationStatusCode))
                ) && 
                (
                    this.OrganizationStatusCodeDescription == input.OrganizationStatusCodeDescription ||
                    (this.OrganizationStatusCodeDescription != null &&
                    this.OrganizationStatusCodeDescription.Equals(input.OrganizationStatusCodeDescription))
                ) && 
                (
                    this.ParentBusiness == input.ParentBusiness ||
                    (this.ParentBusiness != null &&
                    this.ParentBusiness.Equals(input.ParentBusiness))
                ) && 
                (
                    this.TickerSymbol == input.TickerSymbol ||
                    (this.TickerSymbol != null &&
                    this.TickerSymbol.Equals(input.TickerSymbol))
                ) && 
                (
                    this.ExchangeName == input.ExchangeName ||
                    (this.ExchangeName != null &&
                    this.ExchangeName.Equals(input.ExchangeName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BrandName != null)
                    hashCode = hashCode * 59 + this.BrandName.GetHashCode();
                if (this.TradeName != null)
                    hashCode = hashCode * 59 + this.TradeName.GetHashCode();
                if (this.FranchiseName != null)
                    hashCode = hashCode * 59 + this.FranchiseName.GetHashCode();
                if (this.Open24Hours != null)
                    hashCode = hashCode * 59 + this.Open24Hours.GetHashCode();
                if (this.ContactDetails != null)
                    hashCode = hashCode * 59 + this.ContactDetails.GetHashCode();
                if (this.PoiClassification != null)
                    hashCode = hashCode * 59 + this.PoiClassification.GetHashCode();
                if (this.EmployeeCount != null)
                    hashCode = hashCode * 59 + this.EmployeeCount.GetHashCode();
                if (this.OrganizationStatusCode != null)
                    hashCode = hashCode * 59 + this.OrganizationStatusCode.GetHashCode();
                if (this.OrganizationStatusCodeDescription != null)
                    hashCode = hashCode * 59 + this.OrganizationStatusCodeDescription.GetHashCode();
                if (this.ParentBusiness != null)
                    hashCode = hashCode * 59 + this.ParentBusiness.GetHashCode();
                if (this.TickerSymbol != null)
                    hashCode = hashCode * 59 + this.TickerSymbol.GetHashCode();
                if (this.ExchangeName != null)
                    hashCode = hashCode * 59 + this.ExchangeName.GetHashCode();
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