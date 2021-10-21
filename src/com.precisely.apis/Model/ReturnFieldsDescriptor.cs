/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.6.0
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
    /// ReturnFieldsDescriptor
    /// </summary>
    [DataContract]
    public partial class ReturnFieldsDescriptor :  IEquatable<ReturnFieldsDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnFieldsDescriptor" /> class.
        /// </summary>
        /// <param name="ReturnAllCustomFields">ReturnAllCustomFields (default to false).</param>
        /// <param name="ReturnMatchDescriptor">ReturnMatchDescriptor (default to false).</param>
        /// <param name="ReturnStreetAddressFields">ReturnStreetAddressFields (default to false).</param>
        /// <param name="ReturnUnitInformation">ReturnUnitInformation (default to false).</param>
        /// <param name="ReturnedCustomFieldKeys">ReturnedCustomFieldKeys.</param>
        public ReturnFieldsDescriptor(bool? ReturnAllCustomFields = null, bool? ReturnMatchDescriptor = null, bool? ReturnStreetAddressFields = null, bool? ReturnUnitInformation = null, List<string> ReturnedCustomFieldKeys = null)
        {
            // use default value if no "ReturnAllCustomFields" provided
            if (ReturnAllCustomFields == null)
            {
                this.ReturnAllCustomFields = false;
            }
            else
            {
                this.ReturnAllCustomFields = ReturnAllCustomFields;
            }
            // use default value if no "ReturnMatchDescriptor" provided
            if (ReturnMatchDescriptor == null)
            {
                this.ReturnMatchDescriptor = false;
            }
            else
            {
                this.ReturnMatchDescriptor = ReturnMatchDescriptor;
            }
            // use default value if no "ReturnStreetAddressFields" provided
            if (ReturnStreetAddressFields == null)
            {
                this.ReturnStreetAddressFields = false;
            }
            else
            {
                this.ReturnStreetAddressFields = ReturnStreetAddressFields;
            }
            // use default value if no "ReturnUnitInformation" provided
            if (ReturnUnitInformation == null)
            {
                this.ReturnUnitInformation = false;
            }
            else
            {
                this.ReturnUnitInformation = ReturnUnitInformation;
            }
            this.ReturnedCustomFieldKeys = ReturnedCustomFieldKeys;
        }
        
        /// <summary>
        /// Gets or Sets ReturnAllCustomFields
        /// </summary>
        [DataMember(Name="returnAllCustomFields", EmitDefaultValue=false)]
        public bool? ReturnAllCustomFields { get; set; }
        /// <summary>
        /// Gets or Sets ReturnMatchDescriptor
        /// </summary>
        [DataMember(Name="returnMatchDescriptor", EmitDefaultValue=false)]
        public bool? ReturnMatchDescriptor { get; set; }
        /// <summary>
        /// Gets or Sets ReturnStreetAddressFields
        /// </summary>
        [DataMember(Name="returnStreetAddressFields", EmitDefaultValue=false)]
        public bool? ReturnStreetAddressFields { get; set; }
        /// <summary>
        /// Gets or Sets ReturnUnitInformation
        /// </summary>
        [DataMember(Name="returnUnitInformation", EmitDefaultValue=false)]
        public bool? ReturnUnitInformation { get; set; }
        /// <summary>
        /// Gets or Sets ReturnedCustomFieldKeys
        /// </summary>
        [DataMember(Name="returnedCustomFieldKeys", EmitDefaultValue=false)]
        public List<string> ReturnedCustomFieldKeys { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturnFieldsDescriptor {\n");
            sb.Append("  ReturnAllCustomFields: ").Append(ReturnAllCustomFields).Append("\n");
            sb.Append("  ReturnMatchDescriptor: ").Append(ReturnMatchDescriptor).Append("\n");
            sb.Append("  ReturnStreetAddressFields: ").Append(ReturnStreetAddressFields).Append("\n");
            sb.Append("  ReturnUnitInformation: ").Append(ReturnUnitInformation).Append("\n");
            sb.Append("  ReturnedCustomFieldKeys: ").Append(ReturnedCustomFieldKeys).Append("\n");
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
            return this.Equals(obj as ReturnFieldsDescriptor);
        }

        /// <summary>
        /// Returns true if ReturnFieldsDescriptor instances are equal
        /// </summary>
        /// <param name="other">Instance of ReturnFieldsDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturnFieldsDescriptor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReturnAllCustomFields == other.ReturnAllCustomFields ||
                    this.ReturnAllCustomFields != null &&
                    this.ReturnAllCustomFields.Equals(other.ReturnAllCustomFields)
                ) && 
                (
                    this.ReturnMatchDescriptor == other.ReturnMatchDescriptor ||
                    this.ReturnMatchDescriptor != null &&
                    this.ReturnMatchDescriptor.Equals(other.ReturnMatchDescriptor)
                ) && 
                (
                    this.ReturnStreetAddressFields == other.ReturnStreetAddressFields ||
                    this.ReturnStreetAddressFields != null &&
                    this.ReturnStreetAddressFields.Equals(other.ReturnStreetAddressFields)
                ) && 
                (
                    this.ReturnUnitInformation == other.ReturnUnitInformation ||
                    this.ReturnUnitInformation != null &&
                    this.ReturnUnitInformation.Equals(other.ReturnUnitInformation)
                ) && 
                (
                    this.ReturnedCustomFieldKeys == other.ReturnedCustomFieldKeys ||
                    this.ReturnedCustomFieldKeys != null &&
                    this.ReturnedCustomFieldKeys.SequenceEqual(other.ReturnedCustomFieldKeys)
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
                if (this.ReturnAllCustomFields != null)
                    hash = hash * 59 + this.ReturnAllCustomFields.GetHashCode();
                if (this.ReturnMatchDescriptor != null)
                    hash = hash * 59 + this.ReturnMatchDescriptor.GetHashCode();
                if (this.ReturnStreetAddressFields != null)
                    hash = hash * 59 + this.ReturnStreetAddressFields.GetHashCode();
                if (this.ReturnUnitInformation != null)
                    hash = hash * 59 + this.ReturnUnitInformation.GetHashCode();
                if (this.ReturnedCustomFieldKeys != null)
                    hash = hash * 59 + this.ReturnedCustomFieldKeys.GetHashCode();
                return hash;
            }
        }
    }

}
