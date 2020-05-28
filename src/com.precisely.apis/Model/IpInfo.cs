/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 9.0.0
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
    /// IpInfo
    /// </summary>
    [DataContract]
    public partial class IpInfo :  IEquatable<IpInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpInfo" /> class.
        /// </summary>
        /// <param name="IpAddress">IpAddress.</param>
        /// <param name="Proxy">Proxy.</param>
        /// <param name="Network">Network.</param>
        /// <param name="Place">Place.</param>
        public IpInfo(string IpAddress = null, Proxy Proxy = null, Network Network = null, GeoLocationPlace Place = null)
        {
            this.IpAddress = IpAddress;
            this.Proxy = Proxy;
            this.Network = Network;
            this.Place = Place;
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
            return this.Equals(obj as IpInfo);
        }

        /// <summary>
        /// Returns true if IpInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of IpInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.Proxy == other.Proxy ||
                    this.Proxy != null &&
                    this.Proxy.Equals(other.Proxy)
                ) && 
                (
                    this.Network == other.Network ||
                    this.Network != null &&
                    this.Network.Equals(other.Network)
                ) && 
                (
                    this.Place == other.Place ||
                    this.Place != null &&
                    this.Place.Equals(other.Place)
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
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.Proxy != null)
                    hash = hash * 59 + this.Proxy.GetHashCode();
                if (this.Network != null)
                    hash = hash * 59 + this.Network.GetHashCode();
                if (this.Place != null)
                    hash = hash * 59 + this.Place.GetHashCode();
                return hash;
            }
        }
    }

}
