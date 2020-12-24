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
    /// PhoneVerification
    /// </summary>
    [DataContract]
    public partial class PhoneVerification :  IEquatable<PhoneVerification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerification" /> class.
        /// </summary>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="Locatable">Locatable.</param>
        /// <param name="Network">Network.</param>
        /// <param name="PrivacyConsentRequired">PrivacyConsentRequired.</param>
        public PhoneVerification(string PhoneNumber = null, string Locatable = null, DeviceStatusNetwork Network = null, string PrivacyConsentRequired = null)
        {
            this.PhoneNumber = PhoneNumber;
            this.Locatable = Locatable;
            this.Network = Network;
            this.PrivacyConsentRequired = PrivacyConsentRequired;
        }
        
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or Sets Locatable
        /// </summary>
        [DataMember(Name="locatable", EmitDefaultValue=false)]
        public string Locatable { get; set; }
        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public DeviceStatusNetwork Network { get; set; }
        /// <summary>
        /// Gets or Sets PrivacyConsentRequired
        /// </summary>
        [DataMember(Name="privacyConsentRequired", EmitDefaultValue=false)]
        public string PrivacyConsentRequired { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneVerification {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Locatable: ").Append(Locatable).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  PrivacyConsentRequired: ").Append(PrivacyConsentRequired).Append("\n");
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
            return this.Equals(obj as PhoneVerification);
        }

        /// <summary>
        /// Returns true if PhoneVerification instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneVerification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Locatable == other.Locatable ||
                    this.Locatable != null &&
                    this.Locatable.Equals(other.Locatable)
                ) && 
                (
                    this.Network == other.Network ||
                    this.Network != null &&
                    this.Network.Equals(other.Network)
                ) && 
                (
                    this.PrivacyConsentRequired == other.PrivacyConsentRequired ||
                    this.PrivacyConsentRequired != null &&
                    this.PrivacyConsentRequired.Equals(other.PrivacyConsentRequired)
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
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.Locatable != null)
                    hash = hash * 59 + this.Locatable.GetHashCode();
                if (this.Network != null)
                    hash = hash * 59 + this.Network.GetHashCode();
                if (this.PrivacyConsentRequired != null)
                    hash = hash * 59 + this.PrivacyConsentRequired.GetHashCode();
                return hash;
            }
        }
    }

}
