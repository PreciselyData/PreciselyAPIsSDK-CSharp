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
    /// Identity
    /// </summary>
    [DataContract]
    public partial class Identity :  IEquatable<Identity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Identity" /> class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="EmailHash">EmailHash.</param>
        /// <param name="Twitter">Twitter.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="FullName">FullName.</param>
        /// <param name="AgeRange">AgeRange.</param>
        /// <param name="Gender">Gender.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Organization">Organization.</param>
        /// <param name="Linkedin">Linkedin.</param>
        /// <param name="Facebook">Facebook.</param>
        /// <param name="Bio">Bio.</param>
        /// <param name="Avatar">Avatar.</param>
        /// <param name="Website">Website.</param>
        /// <param name="Details">Details.</param>
        /// <param name="Property">Property.</param>
        /// <param name="Neighborhood">Neighborhood.</param>
        public Identity(string Email = null, string EmailHash = null, string Twitter = null, string Phone = null, string FullName = null, string AgeRange = null, string Gender = null, string Location = null, string Title = null, string Organization = null, string Linkedin = null, string Facebook = null, string Bio = null, string Avatar = null, string Website = null, IdentityDetail Details = null, Property Property = null, Neighborhood Neighborhood = null)
        {
            this.Email = Email;
            this.EmailHash = EmailHash;
            this.Twitter = Twitter;
            this.Phone = Phone;
            this.FullName = FullName;
            this.AgeRange = AgeRange;
            this.Gender = Gender;
            this.Location = Location;
            this.Title = Title;
            this.Organization = Organization;
            this.Linkedin = Linkedin;
            this.Facebook = Facebook;
            this.Bio = Bio;
            this.Avatar = Avatar;
            this.Website = Website;
            this.Details = Details;
            this.Property = Property;
            this.Neighborhood = Neighborhood;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets EmailHash
        /// </summary>
        [DataMember(Name="emailHash", EmitDefaultValue=false)]
        public string EmailHash { get; set; }
        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name="twitter", EmitDefaultValue=false)]
        public string Twitter { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }
        /// <summary>
        /// Gets or Sets AgeRange
        /// </summary>
        [DataMember(Name="ageRange", EmitDefaultValue=false)]
        public string AgeRange { get; set; }
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }
        /// <summary>
        /// Gets or Sets Linkedin
        /// </summary>
        [DataMember(Name="linkedin", EmitDefaultValue=false)]
        public string Linkedin { get; set; }
        /// <summary>
        /// Gets or Sets Facebook
        /// </summary>
        [DataMember(Name="facebook", EmitDefaultValue=false)]
        public string Facebook { get; set; }
        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name="bio", EmitDefaultValue=false)]
        public string Bio { get; set; }
        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }
        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public IdentityDetail Details { get; set; }
        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public Property Property { get; set; }
        /// <summary>
        /// Gets or Sets Neighborhood
        /// </summary>
        [DataMember(Name="neighborhood", EmitDefaultValue=false)]
        public Neighborhood Neighborhood { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Identity {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailHash: ").Append(EmailHash).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  AgeRange: ").Append(AgeRange).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
            sb.Append("  Facebook: ").Append(Facebook).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Neighborhood: ").Append(Neighborhood).Append("\n");
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
            return this.Equals(obj as Identity);
        }

        /// <summary>
        /// Returns true if Identity instances are equal
        /// </summary>
        /// <param name="other">Instance of Identity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Identity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailHash == other.EmailHash ||
                    this.EmailHash != null &&
                    this.EmailHash.Equals(other.EmailHash)
                ) && 
                (
                    this.Twitter == other.Twitter ||
                    this.Twitter != null &&
                    this.Twitter.Equals(other.Twitter)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.AgeRange == other.AgeRange ||
                    this.AgeRange != null &&
                    this.AgeRange.Equals(other.AgeRange)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.Linkedin == other.Linkedin ||
                    this.Linkedin != null &&
                    this.Linkedin.Equals(other.Linkedin)
                ) && 
                (
                    this.Facebook == other.Facebook ||
                    this.Facebook != null &&
                    this.Facebook.Equals(other.Facebook)
                ) && 
                (
                    this.Bio == other.Bio ||
                    this.Bio != null &&
                    this.Bio.Equals(other.Bio)
                ) && 
                (
                    this.Avatar == other.Avatar ||
                    this.Avatar != null &&
                    this.Avatar.Equals(other.Avatar)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) && 
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) && 
                (
                    this.Neighborhood == other.Neighborhood ||
                    this.Neighborhood != null &&
                    this.Neighborhood.Equals(other.Neighborhood)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EmailHash != null)
                    hash = hash * 59 + this.EmailHash.GetHashCode();
                if (this.Twitter != null)
                    hash = hash * 59 + this.Twitter.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                if (this.AgeRange != null)
                    hash = hash * 59 + this.AgeRange.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.Linkedin != null)
                    hash = hash * 59 + this.Linkedin.GetHashCode();
                if (this.Facebook != null)
                    hash = hash * 59 + this.Facebook.GetHashCode();
                if (this.Bio != null)
                    hash = hash * 59 + this.Bio.GetHashCode();
                if (this.Avatar != null)
                    hash = hash * 59 + this.Avatar.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                if (this.Neighborhood != null)
                    hash = hash * 59 + this.Neighborhood.GetHashCode();
                return hash;
            }
        }
    }

}
