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
    /// Details for an external token that is wrapped
    /// </summary>
    [DataContract(Name = "wrappedTokenDetails")]
    public partial class WrappedTokenDetails : IEquatable<WrappedTokenDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedTokenDetails" /> class.
        /// </summary>
        /// <param name="custodian">An address on the Cirrus network.</param>
        /// <param name="chain">chain.</param>
        /// <param name="address">Address of the token on the native chain, or unset if the base token of the external chain is wrapped.</param>
        /// <param name="trusted">True if the custodian is configured as trusted; otherwise false.</param>
        /// <param name="validated">True if the native token it points to is valid; otherwise false.</param>
        /// <param name="createdBlock">Block number at which the entity state was created.</param>
        /// <param name="modifiedBlock">Block number at which the entity state was last modified.</param>
        public WrappedTokenDetails(string custodian = default(string), ExternalChain chain = default(ExternalChain), string address = default(string), bool trusted = default(bool), bool validated = default(bool), int createdBlock = default(int), int modifiedBlock = default(int))
        {
            this.Custodian = custodian;
            this.Chain = chain;
            this.Address = address;
            this.Trusted = trusted;
            this.Validated = validated;
            this.CreatedBlock = createdBlock;
            this.ModifiedBlock = modifiedBlock;
        }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "custodian", EmitDefaultValue = false)]
        public string Custodian { get; set; }

        /// <summary>
        /// Gets or Sets Chain
        /// </summary>
        [DataMember(Name = "chain", EmitDefaultValue = false)]
        public ExternalChain Chain { get; set; }

        /// <summary>
        /// Address of the token on the native chain, or unset if the base token of the external chain is wrapped
        /// </summary>
        /// <value>Address of the token on the native chain, or unset if the base token of the external chain is wrapped</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// True if the custodian is configured as trusted; otherwise false
        /// </summary>
        /// <value>True if the custodian is configured as trusted; otherwise false</value>
        [DataMember(Name = "trusted", EmitDefaultValue = true)]
        public bool Trusted { get; set; }

        /// <summary>
        /// True if the native token it points to is valid; otherwise false
        /// </summary>
        /// <value>True if the native token it points to is valid; otherwise false</value>
        [DataMember(Name = "validated", EmitDefaultValue = true)]
        public bool Validated { get; set; }

        /// <summary>
        /// Block number at which the entity state was created
        /// </summary>
        /// <value>Block number at which the entity state was created</value>
        [DataMember(Name = "createdBlock", EmitDefaultValue = false)]
        public int CreatedBlock { get; set; }

        /// <summary>
        /// Block number at which the entity state was last modified
        /// </summary>
        /// <value>Block number at which the entity state was last modified</value>
        [DataMember(Name = "modifiedBlock", EmitDefaultValue = false)]
        public int ModifiedBlock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WrappedTokenDetails {\n");
            sb.Append("  Custodian: ").Append(Custodian).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Trusted: ").Append(Trusted).Append("\n");
            sb.Append("  Validated: ").Append(Validated).Append("\n");
            sb.Append("  CreatedBlock: ").Append(CreatedBlock).Append("\n");
            sb.Append("  ModifiedBlock: ").Append(ModifiedBlock).Append("\n");
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
            return this.Equals(input as WrappedTokenDetails);
        }

        /// <summary>
        /// Returns true if WrappedTokenDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of WrappedTokenDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WrappedTokenDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Custodian == input.Custodian ||
                    (this.Custodian != null &&
                    this.Custodian.Equals(input.Custodian))
                ) && 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Trusted == input.Trusted ||
                    this.Trusted.Equals(input.Trusted)
                ) && 
                (
                    this.Validated == input.Validated ||
                    this.Validated.Equals(input.Validated)
                ) && 
                (
                    this.CreatedBlock == input.CreatedBlock ||
                    this.CreatedBlock.Equals(input.CreatedBlock)
                ) && 
                (
                    this.ModifiedBlock == input.ModifiedBlock ||
                    this.ModifiedBlock.Equals(input.ModifiedBlock)
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
                if (this.Custodian != null)
                {
                    hashCode = (hashCode * 59) + this.Custodian.GetHashCode();
                }
                if (this.Chain != null)
                {
                    hashCode = (hashCode * 59) + this.Chain.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Trusted.GetHashCode();
                hashCode = (hashCode * 59) + this.Validated.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedBlock.GetHashCode();
                hashCode = (hashCode * 59) + this.ModifiedBlock.GetHashCode();
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
            // Custodian (string) maxLength
            if (this.Custodian != null && this.Custodian.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Custodian, length must be less than 42.", new [] { "Custodian" });
            }

            // Custodian (string) minLength
            if (this.Custodian != null && this.Custodian.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Custodian, length must be greater than 30.", new [] { "Custodian" });
            }

            // Custodian (string) pattern
            Regex regexCustodian = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexCustodian.Match(this.Custodian).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Custodian, must match a pattern of " + regexCustodian, new [] { "Custodian" });
            }

            // CreatedBlock (int) minimum
            if (this.CreatedBlock < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedBlock, must be a value greater than or equal to 1.", new [] { "CreatedBlock" });
            }

            // ModifiedBlock (int) minimum
            if (this.ModifiedBlock < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModifiedBlock, must be a value greater than or equal to 1.", new [] { "ModifiedBlock" });
            }

            yield break;
        }
    }

}
