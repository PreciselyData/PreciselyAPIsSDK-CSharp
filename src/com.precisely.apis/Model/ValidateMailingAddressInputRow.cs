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
    /// ValidateMailingAddressInputRow
    /// </summary>
    [DataContract]
    public partial class ValidateMailingAddressInputRow :  IEquatable<ValidateMailingAddressInputRow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateMailingAddressInputRow" /> class.
        /// </summary>
        /// <param name="UserFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="AddressLine1">The first address line..</param>
        /// <param name="AddressLine2">The second address line..</param>
        /// <param name="FirmName">The company or firm name..</param>
        /// <param name="City">The city name..</param>
        /// <param name="StateProvince">The state or province..</param>
        /// <param name="Country">The country code or name..</param>
        /// <param name="PostalCode">The postal code for the address..</param>
        public ValidateMailingAddressInputRow(List<ValidateMailingAddressInputRowUserFields> UserFields = null, string AddressLine1 = null, string AddressLine2 = null, string FirmName = null, string City = null, string StateProvince = null, string Country = null, string PostalCode = null)
        {
            this.UserFields = UserFields;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.FirmName = FirmName;
            this.City = City;
            this.StateProvince = StateProvince;
            this.Country = Country;
            this.PostalCode = PostalCode;
        }
        
        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<ValidateMailingAddressInputRowUserFields> UserFields { get; set; }
        /// <summary>
        /// The first address line.
        /// </summary>
        /// <value>The first address line.</value>
        [DataMember(Name="AddressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }
        /// <summary>
        /// The second address line.
        /// </summary>
        /// <value>The second address line.</value>
        [DataMember(Name="AddressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }
        /// <summary>
        /// The company or firm name.
        /// </summary>
        /// <value>The company or firm name.</value>
        [DataMember(Name="FirmName", EmitDefaultValue=false)]
        public string FirmName { get; set; }
        /// <summary>
        /// The city name.
        /// </summary>
        /// <value>The city name.</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// The state or province.
        /// </summary>
        /// <value>The state or province.</value>
        [DataMember(Name="StateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }
        /// <summary>
        /// The country code or name.
        /// </summary>
        /// <value>The country code or name.</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// The postal code for the address.
        /// </summary>
        /// <value>The postal code for the address.</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateMailingAddressInputRow {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  FirmName: ").Append(FirmName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(obj as ValidateMailingAddressInputRow);
        }

        /// <summary>
        /// Returns true if ValidateMailingAddressInputRow instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateMailingAddressInputRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateMailingAddressInputRow other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserFields == other.UserFields ||
                    this.UserFields != null &&
                    this.UserFields.SequenceEqual(other.UserFields)
                ) && 
                (
                    this.AddressLine1 == other.AddressLine1 ||
                    this.AddressLine1 != null &&
                    this.AddressLine1.Equals(other.AddressLine1)
                ) && 
                (
                    this.AddressLine2 == other.AddressLine2 ||
                    this.AddressLine2 != null &&
                    this.AddressLine2.Equals(other.AddressLine2)
                ) && 
                (
                    this.FirmName == other.FirmName ||
                    this.FirmName != null &&
                    this.FirmName.Equals(other.FirmName)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.StateProvince == other.StateProvince ||
                    this.StateProvince != null &&
                    this.StateProvince.Equals(other.StateProvince)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
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
                if (this.UserFields != null)
                    hash = hash * 59 + this.UserFields.GetHashCode();
                if (this.AddressLine1 != null)
                    hash = hash * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hash = hash * 59 + this.AddressLine2.GetHashCode();
                if (this.FirmName != null)
                    hash = hash * 59 + this.FirmName.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.StateProvince != null)
                    hash = hash * 59 + this.StateProvince.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                return hash;
            }
        }
    }

}
