/*
 * Opdex Platform API
 *
 * The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.
 *
 * The version of the OpenAPI document: 1.0.0
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
using FileParameter = Opdex.Client.Client.FileParameter;
using OpenAPIDateConverter = Opdex.Client.Client.OpenAPIDateConverter;

namespace Opdex.Client.Model
{
    /// <summary>
    /// Request to retrieve a propose revoke certificate call quote
    /// </summary>
    [DataContract(Name = "quoteProposeRevokeCertificateRequest")]
    public partial class QuoteProposeRevokeCertificateRequest : IEquatable<QuoteProposeRevokeCertificateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteProposeRevokeCertificateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteProposeRevokeCertificateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteProposeRevokeCertificateRequest" /> class.
        /// </summary>
        /// <param name="owner">An address on the Cirrus network (required).</param>
        /// <param name="description">Short description for the proposal; it is recommended to add a link with futher details (required).</param>
        public QuoteProposeRevokeCertificateRequest(string owner = default(string), string description = default(string))
        {
            // to ensure "owner" is required (not null)
            if (owner == null) {
                throw new ArgumentNullException("owner is a required property for QuoteProposeRevokeCertificateRequest and cannot be null");
            }
            this.Owner = owner;
            // to ensure "description" is required (not null)
            if (description == null) {
                throw new ArgumentNullException("description is a required property for QuoteProposeRevokeCertificateRequest and cannot be null");
            }
            this.Description = description;
        }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = false)]
        public string Owner { get; set; }

        /// <summary>
        /// Short description for the proposal; it is recommended to add a link with futher details
        /// </summary>
        /// <value>Short description for the proposal; it is recommended to add a link with futher details</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteProposeRevokeCertificateRequest {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as QuoteProposeRevokeCertificateRequest);
        }

        /// <summary>
        /// Returns true if QuoteProposeRevokeCertificateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteProposeRevokeCertificateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteProposeRevokeCertificateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
            // Owner (string) maxLength
            if (this.Owner != null && this.Owner.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Owner, length must be less than 42.", new [] { "Owner" });
            }

            // Owner (string) minLength
            if (this.Owner != null && this.Owner.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Owner, length must be greater than 30.", new [] { "Owner" });
            }

            // Owner (string) pattern
            Regex regexOwner = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexOwner.Match(this.Owner).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Owner, must match a pattern of " + regexOwner, new [] { "Owner" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 200.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            yield break;
        }
    }

}
