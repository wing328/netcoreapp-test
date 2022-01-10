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
    /// Model for EmailResponse
    /// </summary>
    [DataContract(Name = "EmailResponse")]
    public partial class EmailResponse : IEquatable<EmailResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailResponse" /> class.
        /// </summary>
        /// <param name="emailID">emailID (required).</param>
        /// <param name="result">result.</param>
        public EmailResponse(string emailID = default(string), string result = default(string))
        {
            // to ensure "emailID" is required (not null)
            if (emailID == null) {
                throw new ArgumentNullException("emailID is a required property for EmailResponse and cannot be null");
            }
            this.EmailID = emailID;
            this.Result = result;
        }

        /// <summary>
        /// Gets or Sets EmailID
        /// </summary>
        [DataMember(Name = "EmailID", IsRequired = true, EmitDefaultValue = false)]
        public string EmailID { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "Result", EmitDefaultValue = false)]
        public string Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailResponse {\n");
            sb.Append("  EmailID: ").Append(EmailID).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as EmailResponse);
        }

        /// <summary>
        /// Returns true if EmailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailResponse input)
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
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
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