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
    /// Model for NewEmail
    /// </summary>
    [DataContract(Name = "NewEmail")]
    public partial class NewEmail : IEquatable<NewEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewEmail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewEmail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewEmail" /> class.
        /// </summary>
        /// <param name="html">html.</param>
        /// <param name="recipient">recipient (required).</param>
        /// <param name="senderEmail">senderEmail (required).</param>
        /// <param name="senderName">senderName.</param>
        /// <param name="subject">subject (required).</param>
        /// <param name="text">text (required).</param>
        /// <param name="unsubLink">unsubLink.</param>
        public NewEmail(string html = default(string), string recipient = default(string), string senderEmail = default(string), string senderName = default(string), string subject = default(string), string text = default(string), bool unsubLink = default(bool))
        {
            // to ensure "recipient" is required (not null)
            if (recipient == null) {
                throw new ArgumentNullException("recipient is a required property for NewEmail and cannot be null");
            }
            this.Recipient = recipient;
            // to ensure "senderEmail" is required (not null)
            if (senderEmail == null) {
                throw new ArgumentNullException("senderEmail is a required property for NewEmail and cannot be null");
            }
            this.SenderEmail = senderEmail;
            // to ensure "subject" is required (not null)
            if (subject == null) {
                throw new ArgumentNullException("subject is a required property for NewEmail and cannot be null");
            }
            this.Subject = subject;
            // to ensure "text" is required (not null)
            if (text == null) {
                throw new ArgumentNullException("text is a required property for NewEmail and cannot be null");
            }
            this.Text = text;
            this.Html = html;
            this.SenderName = senderName;
            this.UnsubLink = unsubLink;
        }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "Html", EmitDefaultValue = false)]
        public string Html { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "Recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Gets or Sets SenderEmail
        /// </summary>
        [DataMember(Name = "SenderEmail", IsRequired = true, EmitDefaultValue = false)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Gets or Sets SenderName
        /// </summary>
        [DataMember(Name = "SenderName", EmitDefaultValue = false)]
        public string SenderName { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "Subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "Text", IsRequired = true, EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets UnsubLink
        /// </summary>
        [DataMember(Name = "UnsubLink", EmitDefaultValue = true)]
        public bool UnsubLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewEmail {\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  UnsubLink: ").Append(UnsubLink).Append("\n");
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
            return this.Equals(input as NewEmail);
        }

        /// <summary>
        /// Returns true if NewEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of NewEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewEmail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.SenderEmail == input.SenderEmail ||
                    (this.SenderEmail != null &&
                    this.SenderEmail.Equals(input.SenderEmail))
                ) && 
                (
                    this.SenderName == input.SenderName ||
                    (this.SenderName != null &&
                    this.SenderName.Equals(input.SenderName))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.UnsubLink == input.UnsubLink ||
                    this.UnsubLink.Equals(input.UnsubLink)
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
                if (this.Html != null)
                {
                    hashCode = (hashCode * 59) + this.Html.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.SenderEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SenderEmail.GetHashCode();
                }
                if (this.SenderName != null)
                {
                    hashCode = (hashCode * 59) + this.SenderName.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnsubLink.GetHashCode();
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