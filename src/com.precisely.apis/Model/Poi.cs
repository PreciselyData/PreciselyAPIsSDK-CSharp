/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.5.0
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
    /// Poi
    /// </summary>
    [DataContract]
    public partial class Poi :  IEquatable<Poi>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Poi" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="BrandName">BrandName.</param>
        /// <param name="TradeName">TradeName.</param>
        /// <param name="FranchiseName">FranchiseName.</param>
        /// <param name="Open24Hours">Open24Hours.</param>
        /// <param name="ContactDetails">ContactDetails.</param>
        /// <param name="PoiClassification">PoiClassification.</param>
        /// <param name="EmployeeCount">EmployeeCount.</param>
        /// <param name="OrganizationStatusCode">OrganizationStatusCode.</param>
        /// <param name="OrganizationStatusCodeDescription">OrganizationStatusCodeDescription.</param>
        /// <param name="ParentBusiness">ParentBusiness.</param>
        /// <param name="TickerSymbol">TickerSymbol.</param>
        /// <param name="ExchangeName">ExchangeName.</param>
        public Poi(string Id = null, string Name = null, string BrandName = null, string TradeName = null, string FranchiseName = null, string Open24Hours = null, ContactDetails ContactDetails = null, PoiClassification PoiClassification = null, EmployeeCount EmployeeCount = null, string OrganizationStatusCode = null, string OrganizationStatusCodeDescription = null, ParentBusiness ParentBusiness = null, string TickerSymbol = null, string ExchangeName = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.BrandName = BrandName;
            this.TradeName = TradeName;
            this.FranchiseName = FranchiseName;
            this.Open24Hours = Open24Hours;
            this.ContactDetails = ContactDetails;
            this.PoiClassification = PoiClassification;
            this.EmployeeCount = EmployeeCount;
            this.OrganizationStatusCode = OrganizationStatusCode;
            this.OrganizationStatusCodeDescription = OrganizationStatusCodeDescription;
            this.ParentBusiness = ParentBusiness;
            this.TickerSymbol = TickerSymbol;
            this.ExchangeName = ExchangeName;
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
        public ContactDetails ContactDetails { get; set; }
        /// <summary>
        /// Gets or Sets PoiClassification
        /// </summary>
        [DataMember(Name="poiClassification", EmitDefaultValue=false)]
        public PoiClassification PoiClassification { get; set; }
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
        public ParentBusiness ParentBusiness { get; set; }
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
            sb.Append("class Poi {\n");
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
            return this.Equals(obj as Poi);
        }

        /// <summary>
        /// Returns true if Poi instances are equal
        /// </summary>
        /// <param name="other">Instance of Poi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Poi other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.BrandName == other.BrandName ||
                    this.BrandName != null &&
                    this.BrandName.Equals(other.BrandName)
                ) && 
                (
                    this.TradeName == other.TradeName ||
                    this.TradeName != null &&
                    this.TradeName.Equals(other.TradeName)
                ) && 
                (
                    this.FranchiseName == other.FranchiseName ||
                    this.FranchiseName != null &&
                    this.FranchiseName.Equals(other.FranchiseName)
                ) && 
                (
                    this.Open24Hours == other.Open24Hours ||
                    this.Open24Hours != null &&
                    this.Open24Hours.Equals(other.Open24Hours)
                ) && 
                (
                    this.ContactDetails == other.ContactDetails ||
                    this.ContactDetails != null &&
                    this.ContactDetails.Equals(other.ContactDetails)
                ) && 
                (
                    this.PoiClassification == other.PoiClassification ||
                    this.PoiClassification != null &&
                    this.PoiClassification.Equals(other.PoiClassification)
                ) && 
                (
                    this.EmployeeCount == other.EmployeeCount ||
                    this.EmployeeCount != null &&
                    this.EmployeeCount.Equals(other.EmployeeCount)
                ) && 
                (
                    this.OrganizationStatusCode == other.OrganizationStatusCode ||
                    this.OrganizationStatusCode != null &&
                    this.OrganizationStatusCode.Equals(other.OrganizationStatusCode)
                ) && 
                (
                    this.OrganizationStatusCodeDescription == other.OrganizationStatusCodeDescription ||
                    this.OrganizationStatusCodeDescription != null &&
                    this.OrganizationStatusCodeDescription.Equals(other.OrganizationStatusCodeDescription)
                ) && 
                (
                    this.ParentBusiness == other.ParentBusiness ||
                    this.ParentBusiness != null &&
                    this.ParentBusiness.Equals(other.ParentBusiness)
                ) && 
                (
                    this.TickerSymbol == other.TickerSymbol ||
                    this.TickerSymbol != null &&
                    this.TickerSymbol.Equals(other.TickerSymbol)
                ) && 
                (
                    this.ExchangeName == other.ExchangeName ||
                    this.ExchangeName != null &&
                    this.ExchangeName.Equals(other.ExchangeName)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.BrandName != null)
                    hash = hash * 59 + this.BrandName.GetHashCode();
                if (this.TradeName != null)
                    hash = hash * 59 + this.TradeName.GetHashCode();
                if (this.FranchiseName != null)
                    hash = hash * 59 + this.FranchiseName.GetHashCode();
                if (this.Open24Hours != null)
                    hash = hash * 59 + this.Open24Hours.GetHashCode();
                if (this.ContactDetails != null)
                    hash = hash * 59 + this.ContactDetails.GetHashCode();
                if (this.PoiClassification != null)
                    hash = hash * 59 + this.PoiClassification.GetHashCode();
                if (this.EmployeeCount != null)
                    hash = hash * 59 + this.EmployeeCount.GetHashCode();
                if (this.OrganizationStatusCode != null)
                    hash = hash * 59 + this.OrganizationStatusCode.GetHashCode();
                if (this.OrganizationStatusCodeDescription != null)
                    hash = hash * 59 + this.OrganizationStatusCodeDescription.GetHashCode();
                if (this.ParentBusiness != null)
                    hash = hash * 59 + this.ParentBusiness.GetHashCode();
                if (this.TickerSymbol != null)
                    hash = hash * 59 + this.TickerSymbol.GetHashCode();
                if (this.ExchangeName != null)
                    hash = hash * 59 + this.ExchangeName.GetHashCode();
                return hash;
            }
        }
    }

}
