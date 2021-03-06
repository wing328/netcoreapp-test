/*
 * Dingo Mail AU API
 *
 * <p>API for api.dingomail.com.au</p> 
 *
 * The version of the OpenAPI document: 0.2.4
 * Contact: info@dingomail.com.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Au.Com.Dingomail.Api.Dingomailau.Client.OpenAPIDateConverter;

namespace Au.Com.Dingomail.Api.Dingomailau.Model
{
    /// <summary>
    /// Model for CheckStatus
    /// </summary>
    [DataContract(Name = "CheckStatus")]
    public partial class CheckStatus : IEquatable<CheckStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckStatus" /> class.
        /// </summary>
        /// <param name="emailID">emailID (required).</param>
        /// <param name="from">from.</param>
        /// <param name="status">status.</param>
        /// <param name="subject">subject.</param>
        /// <param name="to">to.</param>
        public CheckStatus(string emailID = default(string), string from = default(string), string status = default(string), string subject = default(string), string to = default(string))
        {
            // to ensure "emailID" is required (not null)
            if (emailID == null) {
                throw new ArgumentNullException("emailID is a required property for CheckStatus and cannot be null");
            }
            this.EmailID = emailID;
            this.From = from;
            this.Status = status;
            this.Subject = subject;
            this.To = to;
        }

        /// <summary>
        /// Gets or Sets EmailID
        /// </summary>
        [DataMember(Name = "EmailID", IsRequired = true, EmitDefaultValue = false)]
        public string EmailID { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "From", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "Subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "To", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckStatus {\n");
            sb.Append("  EmailID: ").Append(EmailID).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as CheckStatus);
        }

        /// <summary>
        /// Returns true if CheckStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmailID == input.EmailID ||
                    (this.EmailID != null &&
                    this.EmailID.Equals(input.EmailID))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.EmailID != null)
                {
                    hashCode = (hashCode * 59) + this.EmailID.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
