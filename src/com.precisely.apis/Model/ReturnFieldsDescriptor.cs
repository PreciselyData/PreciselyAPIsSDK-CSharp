/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.0.0
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
    /// ReturnFieldsDescriptor
    /// </summary>
    [DataContract]
    public partial class ReturnFieldsDescriptor :  IEquatable<ReturnFieldsDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnFieldsDescriptor" /> class.
        /// </summary>
        /// <param name="returnAllCustomFields">returnAllCustomFields.</param>
        /// <param name="returnMatchDescriptor">returnMatchDescriptor.</param>
        /// <param name="returnStreetAddressFields">returnStreetAddressFields.</param>
        /// <param name="returnUnitInformation">returnUnitInformation.</param>
        /// <param name="returnedCustomFieldKeys">returnedCustomFieldKeys.</param>
        public ReturnFieldsDescriptor(bool returnAllCustomFields = default(bool), bool returnMatchDescriptor = default(bool), bool returnStreetAddressFields = default(bool), bool returnUnitInformation = default(bool), List<string> returnedCustomFieldKeys = default(List<string>))
        {
            this.ReturnAllCustomFields = returnAllCustomFields;
            this.ReturnMatchDescriptor = returnMatchDescriptor;
            this.ReturnStreetAddressFields = returnStreetAddressFields;
            this.ReturnUnitInformation = returnUnitInformation;
            this.ReturnedCustomFieldKeys = returnedCustomFieldKeys;
        }

        /// <summary>
        /// Gets or Sets ReturnAllCustomFields
        /// </summary>
        [DataMember(Name="returnAllCustomFields", EmitDefaultValue=false)]
        public bool ReturnAllCustomFields { get; set; }

        /// <summary>
        /// Gets or Sets ReturnMatchDescriptor
        /// </summary>
        [DataMember(Name="returnMatchDescriptor", EmitDefaultValue=false)]
        public bool ReturnMatchDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets ReturnStreetAddressFields
        /// </summary>
        [DataMember(Name="returnStreetAddressFields", EmitDefaultValue=false)]
        public bool ReturnStreetAddressFields { get; set; }

        /// <summary>
        /// Gets or Sets ReturnUnitInformation
        /// </summary>
        [DataMember(Name="returnUnitInformation", EmitDefaultValue=false)]
        public bool ReturnUnitInformation { get; set; }

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
            return this.Equals(input as ReturnFieldsDescriptor);
        }

        /// <summary>
        /// Returns true if ReturnFieldsDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of ReturnFieldsDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturnFieldsDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnAllCustomFields == input.ReturnAllCustomFields ||
                    (this.ReturnAllCustomFields != null &&
                    this.ReturnAllCustomFields.Equals(input.ReturnAllCustomFields))
                ) && 
                (
                    this.ReturnMatchDescriptor == input.ReturnMatchDescriptor ||
                    (this.ReturnMatchDescriptor != null &&
                    this.ReturnMatchDescriptor.Equals(input.ReturnMatchDescriptor))
                ) && 
                (
                    this.ReturnStreetAddressFields == input.ReturnStreetAddressFields ||
                    (this.ReturnStreetAddressFields != null &&
                    this.ReturnStreetAddressFields.Equals(input.ReturnStreetAddressFields))
                ) && 
                (
                    this.ReturnUnitInformation == input.ReturnUnitInformation ||
                    (this.ReturnUnitInformation != null &&
                    this.ReturnUnitInformation.Equals(input.ReturnUnitInformation))
                ) && 
                (
                    this.ReturnedCustomFieldKeys == input.ReturnedCustomFieldKeys ||
                    this.ReturnedCustomFieldKeys != null &&
                    input.ReturnedCustomFieldKeys != null &&
                    this.ReturnedCustomFieldKeys.SequenceEqual(input.ReturnedCustomFieldKeys)
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
                if (this.ReturnAllCustomFields != null)
                    hashCode = hashCode * 59 + this.ReturnAllCustomFields.GetHashCode();
                if (this.ReturnMatchDescriptor != null)
                    hashCode = hashCode * 59 + this.ReturnMatchDescriptor.GetHashCode();
                if (this.ReturnStreetAddressFields != null)
                    hashCode = hashCode * 59 + this.ReturnStreetAddressFields.GetHashCode();
                if (this.ReturnUnitInformation != null)
                    hashCode = hashCode * 59 + this.ReturnUnitInformation.GetHashCode();
                if (this.ReturnedCustomFieldKeys != null)
                    hashCode = hashCode * 59 + this.ReturnedCustomFieldKeys.GetHashCode();
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
