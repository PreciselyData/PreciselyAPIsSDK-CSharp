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
    /// IpInfo
    /// </summary>
    [DataContract]
    public partial class IpInfo :  IEquatable<IpInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpInfo" /> class.
        /// </summary>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="proxy">proxy.</param>
        /// <param name="network">network.</param>
        /// <param name="place">place.</param>
        public IpInfo(string ipAddress = default(string), Proxy proxy = default(Proxy), Network network = default(Network), GeoLocationPlace place = default(GeoLocationPlace))
        {
            this.IpAddress = ipAddress;
            this.Proxy = proxy;
            this.Network = network;
            this.Place = place;
        }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name="proxy", EmitDefaultValue=false)]
        public Proxy Proxy { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public Network Network { get; set; }

        /// <summary>
        /// Gets or Sets Place
        /// </summary>
        [DataMember(Name="place", EmitDefaultValue=false)]
        public GeoLocationPlace Place { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpInfo {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Place: ").Append(Place).Append("\n");
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
            return this.Equals(input as IpInfo);
        }

        /// <summary>
        /// Returns true if IpInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IpInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Proxy == input.Proxy ||
                    (this.Proxy != null &&
                    this.Proxy.Equals(input.Proxy))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Place == input.Place ||
                    (this.Place != null &&
                    this.Place.Equals(input.Place))
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
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Proxy != null)
                    hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Place != null)
                    hashCode = hashCode * 59 + this.Place.GetHashCode();
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
