/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.0
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
    /// Network
    /// </summary>
    [DataContract]
    public partial class Network :  IEquatable<Network>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Network" /> class.
        /// </summary>
        /// <param name="ConnectionFromHome">ConnectionFromHome.</param>
        /// <param name="Organization">Organization.</param>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="OrganizationType">OrganizationType.</param>
        /// <param name="ConnectionType">ConnectionType.</param>
        /// <param name="LineSpeed">LineSpeed.</param>
        /// <param name="IpRouteType">IpRouteType.</param>
        /// <param name="HostingFacility">HostingFacility.</param>
        public Network(string ConnectionFromHome = null, string Organization = null, Carrier Carrier = null, OrganizationType OrganizationType = null, string ConnectionType = null, string LineSpeed = null, string IpRouteType = null, string HostingFacility = null)
        {
            this.ConnectionFromHome = ConnectionFromHome;
            this.Organization = Organization;
            this.Carrier = Carrier;
            this.OrganizationType = OrganizationType;
            this.ConnectionType = ConnectionType;
            this.LineSpeed = LineSpeed;
            this.IpRouteType = IpRouteType;
            this.HostingFacility = HostingFacility;
        }
        
        /// <summary>
        /// Gets or Sets ConnectionFromHome
        /// </summary>
        [DataMember(Name="connectionFromHome", EmitDefaultValue=false)]
        public string ConnectionFromHome { get; set; }
        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }
        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public Carrier Carrier { get; set; }
        /// <summary>
        /// Gets or Sets OrganizationType
        /// </summary>
        [DataMember(Name="organizationType", EmitDefaultValue=false)]
        public OrganizationType OrganizationType { get; set; }
        /// <summary>
        /// Gets or Sets ConnectionType
        /// </summary>
        [DataMember(Name="connectionType", EmitDefaultValue=false)]
        public string ConnectionType { get; set; }
        /// <summary>
        /// Gets or Sets LineSpeed
        /// </summary>
        [DataMember(Name="lineSpeed", EmitDefaultValue=false)]
        public string LineSpeed { get; set; }
        /// <summary>
        /// Gets or Sets IpRouteType
        /// </summary>
        [DataMember(Name="ipRouteType", EmitDefaultValue=false)]
        public string IpRouteType { get; set; }
        /// <summary>
        /// Gets or Sets HostingFacility
        /// </summary>
        [DataMember(Name="hostingFacility", EmitDefaultValue=false)]
        public string HostingFacility { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Network {\n");
            sb.Append("  ConnectionFromHome: ").Append(ConnectionFromHome).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  OrganizationType: ").Append(OrganizationType).Append("\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  LineSpeed: ").Append(LineSpeed).Append("\n");
            sb.Append("  IpRouteType: ").Append(IpRouteType).Append("\n");
            sb.Append("  HostingFacility: ").Append(HostingFacility).Append("\n");
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
            return this.Equals(obj as Network);
        }

        /// <summary>
        /// Returns true if Network instances are equal
        /// </summary>
        /// <param name="other">Instance of Network to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Network other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConnectionFromHome == other.ConnectionFromHome ||
                    this.ConnectionFromHome != null &&
                    this.ConnectionFromHome.Equals(other.ConnectionFromHome)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.OrganizationType == other.OrganizationType ||
                    this.OrganizationType != null &&
                    this.OrganizationType.Equals(other.OrganizationType)
                ) && 
                (
                    this.ConnectionType == other.ConnectionType ||
                    this.ConnectionType != null &&
                    this.ConnectionType.Equals(other.ConnectionType)
                ) && 
                (
                    this.LineSpeed == other.LineSpeed ||
                    this.LineSpeed != null &&
                    this.LineSpeed.Equals(other.LineSpeed)
                ) && 
                (
                    this.IpRouteType == other.IpRouteType ||
                    this.IpRouteType != null &&
                    this.IpRouteType.Equals(other.IpRouteType)
                ) && 
                (
                    this.HostingFacility == other.HostingFacility ||
                    this.HostingFacility != null &&
                    this.HostingFacility.Equals(other.HostingFacility)
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
                if (this.ConnectionFromHome != null)
                    hash = hash * 59 + this.ConnectionFromHome.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                if (this.OrganizationType != null)
                    hash = hash * 59 + this.OrganizationType.GetHashCode();
                if (this.ConnectionType != null)
                    hash = hash * 59 + this.ConnectionType.GetHashCode();
                if (this.LineSpeed != null)
                    hash = hash * 59 + this.LineSpeed.GetHashCode();
                if (this.IpRouteType != null)
                    hash = hash * 59 + this.IpRouteType.GetHashCode();
                if (this.HostingFacility != null)
                    hash = hash * 59 + this.HostingFacility.GetHashCode();
                return hash;
            }
        }
    }

}
