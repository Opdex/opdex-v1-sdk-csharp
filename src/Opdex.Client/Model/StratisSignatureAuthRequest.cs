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
using OpenAPIDateConverter = Opdex.Client.Client.OpenAPIDateConverter;

namespace Opdex.Client.Model
{
    /// <summary>
    /// StratisSignatureAuthRequest
    /// </summary>
    [DataContract(Name = "stratisSignatureAuthRequest")]
    public partial class StratisSignatureAuthRequest : IEquatable<StratisSignatureAuthRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StratisSignatureAuthRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StratisSignatureAuthRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StratisSignatureAuthRequest" /> class.
        /// </summary>
        /// <param name="signature">Signed Stratis ID (required).</param>
        /// <param name="publicKey">An address on the Cirrus network (required).</param>
        public StratisSignatureAuthRequest(byte[] signature = default(byte[]), string publicKey = default(string))
        {
            // to ensure "signature" is required (not null)
            if (signature == null) {
                throw new ArgumentNullException("signature is a required property for StratisSignatureAuthRequest and cannot be null");
            }
            this.Signature = signature;
            // to ensure "publicKey" is required (not null)
            if (publicKey == null) {
                throw new ArgumentNullException("publicKey is a required property for StratisSignatureAuthRequest and cannot be null");
            }
            this.PublicKey = publicKey;
        }

        /// <summary>
        /// Signed Stratis ID
        /// </summary>
        /// <value>Signed Stratis ID</value>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = false)]
        public byte[] Signature { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "publicKey", IsRequired = true, EmitDefaultValue = false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StratisSignatureAuthRequest {\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as StratisSignatureAuthRequest);
        }

        /// <summary>
        /// Returns true if StratisSignatureAuthRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StratisSignatureAuthRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StratisSignatureAuthRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
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
            // PublicKey (string) maxLength
            if (this.PublicKey != null && this.PublicKey.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicKey, length must be less than 42.", new [] { "PublicKey" });
            }

            // PublicKey (string) minLength
            if (this.PublicKey != null && this.PublicKey.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicKey, length must be greater than 30.", new [] { "PublicKey" });
            }

            // PublicKey (string) pattern
            Regex regexPublicKey = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexPublicKey.Match(this.PublicKey).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicKey, must match a pattern of " + regexPublicKey, new [] { "PublicKey" });
            }

            yield break;
        }
    }

}