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
    /// MarketResponse
    /// </summary>
    [DataContract(Name = "marketResponse")]
    public partial class MarketResponse : IEquatable<MarketResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketResponse" /> class.
        /// </summary>
        /// <param name="address">An address on the Cirrus network.</param>
        /// <param name="pendingOwner">An address on the Cirrus network.</param>
        /// <param name="owner">An address on the Cirrus network.</param>
        /// <param name="tokens">tokens.</param>
        /// <param name="authPoolCreators">Whether the market owner authorizes liquidity pool creators.</param>
        /// <param name="authTraders">Whether the market owner authorizes traders.</param>
        /// <param name="authProviders">Whether the market owner authorizes liquidity providers.</param>
        /// <param name="marketFeeEnabled">Whether the market fee is enabled.</param>
        /// <param name="transactionFeePercent">Percentage fee for a trade.</param>
        /// <param name="createdBlock">Block number at which the entity was created.</param>
        /// <param name="modifiedBlock">Block number at which the entity state was last modified.</param>
        /// <param name="summary">summary.</param>
        public MarketResponse(string address = default(string), string pendingOwner = default(string), string owner = default(string), MarketTokenBreakdown tokens = default(MarketTokenBreakdown), bool authPoolCreators = default(bool), bool authTraders = default(bool), bool authProviders = default(bool), bool marketFeeEnabled = default(bool), decimal transactionFeePercent = default(decimal), int createdBlock = default(int), int modifiedBlock = default(int), MarketSummary summary = default(MarketSummary))
        {
            this.Address = address;
            this.PendingOwner = pendingOwner;
            this.Owner = owner;
            this.Tokens = tokens;
            this.AuthPoolCreators = authPoolCreators;
            this.AuthTraders = authTraders;
            this.AuthProviders = authProviders;
            this.MarketFeeEnabled = marketFeeEnabled;
            this.TransactionFeePercent = transactionFeePercent;
            this.CreatedBlock = createdBlock;
            this.ModifiedBlock = modifiedBlock;
            this.Summary = summary;
        }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "pendingOwner", EmitDefaultValue = false)]
        public string PendingOwner { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name = "tokens", EmitDefaultValue = false)]
        public MarketTokenBreakdown Tokens { get; set; }

        /// <summary>
        /// Whether the market owner authorizes liquidity pool creators
        /// </summary>
        /// <value>Whether the market owner authorizes liquidity pool creators</value>
        [DataMember(Name = "authPoolCreators", EmitDefaultValue = true)]
        public bool AuthPoolCreators { get; set; }

        /// <summary>
        /// Whether the market owner authorizes traders
        /// </summary>
        /// <value>Whether the market owner authorizes traders</value>
        [DataMember(Name = "authTraders", EmitDefaultValue = true)]
        public bool AuthTraders { get; set; }

        /// <summary>
        /// Whether the market owner authorizes liquidity providers
        /// </summary>
        /// <value>Whether the market owner authorizes liquidity providers</value>
        [DataMember(Name = "authProviders", EmitDefaultValue = true)]
        public bool AuthProviders { get; set; }

        /// <summary>
        /// Whether the market fee is enabled
        /// </summary>
        /// <value>Whether the market fee is enabled</value>
        [DataMember(Name = "marketFeeEnabled", EmitDefaultValue = true)]
        public bool MarketFeeEnabled { get; set; }

        /// <summary>
        /// Percentage fee for a trade
        /// </summary>
        /// <value>Percentage fee for a trade</value>
        [DataMember(Name = "transactionFeePercent", EmitDefaultValue = false)]
        public decimal TransactionFeePercent { get; set; }

        /// <summary>
        /// Block number at which the entity was created
        /// </summary>
        /// <value>Block number at which the entity was created</value>
        [DataMember(Name = "createdBlock", EmitDefaultValue = false)]
        public int CreatedBlock { get; set; }

        /// <summary>
        /// Block number at which the entity state was last modified
        /// </summary>
        /// <value>Block number at which the entity state was last modified</value>
        [DataMember(Name = "modifiedBlock", EmitDefaultValue = false)]
        public int ModifiedBlock { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public MarketSummary Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarketResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PendingOwner: ").Append(PendingOwner).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  AuthPoolCreators: ").Append(AuthPoolCreators).Append("\n");
            sb.Append("  AuthTraders: ").Append(AuthTraders).Append("\n");
            sb.Append("  AuthProviders: ").Append(AuthProviders).Append("\n");
            sb.Append("  MarketFeeEnabled: ").Append(MarketFeeEnabled).Append("\n");
            sb.Append("  TransactionFeePercent: ").Append(TransactionFeePercent).Append("\n");
            sb.Append("  CreatedBlock: ").Append(CreatedBlock).Append("\n");
            sb.Append("  ModifiedBlock: ").Append(ModifiedBlock).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
            return this.Equals(input as MarketResponse);
        }

        /// <summary>
        /// Returns true if MarketResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PendingOwner == input.PendingOwner ||
                    (this.PendingOwner != null &&
                    this.PendingOwner.Equals(input.PendingOwner))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Tokens == input.Tokens ||
                    (this.Tokens != null &&
                    this.Tokens.Equals(input.Tokens))
                ) && 
                (
                    this.AuthPoolCreators == input.AuthPoolCreators ||
                    this.AuthPoolCreators.Equals(input.AuthPoolCreators)
                ) && 
                (
                    this.AuthTraders == input.AuthTraders ||
                    this.AuthTraders.Equals(input.AuthTraders)
                ) && 
                (
                    this.AuthProviders == input.AuthProviders ||
                    this.AuthProviders.Equals(input.AuthProviders)
                ) && 
                (
                    this.MarketFeeEnabled == input.MarketFeeEnabled ||
                    this.MarketFeeEnabled.Equals(input.MarketFeeEnabled)
                ) && 
                (
                    this.TransactionFeePercent == input.TransactionFeePercent ||
                    this.TransactionFeePercent.Equals(input.TransactionFeePercent)
                ) && 
                (
                    this.CreatedBlock == input.CreatedBlock ||
                    this.CreatedBlock.Equals(input.CreatedBlock)
                ) && 
                (
                    this.ModifiedBlock == input.ModifiedBlock ||
                    this.ModifiedBlock.Equals(input.ModifiedBlock)
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.PendingOwner != null)
                {
                    hashCode = (hashCode * 59) + this.PendingOwner.GetHashCode();
                }
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
                }
                if (this.Tokens != null)
                {
                    hashCode = (hashCode * 59) + this.Tokens.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AuthPoolCreators.GetHashCode();
                hashCode = (hashCode * 59) + this.AuthTraders.GetHashCode();
                hashCode = (hashCode * 59) + this.AuthProviders.GetHashCode();
                hashCode = (hashCode * 59) + this.MarketFeeEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.TransactionFeePercent.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedBlock.GetHashCode();
                hashCode = (hashCode * 59) + this.ModifiedBlock.GetHashCode();
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
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
            // Address (string) maxLength
            if (this.Address != null && this.Address.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be less than 42.", new [] { "Address" });
            }

            // Address (string) minLength
            if (this.Address != null && this.Address.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be greater than 30.", new [] { "Address" });
            }

            // Address (string) pattern
            Regex regexAddress = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexAddress.Match(this.Address).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, must match a pattern of " + regexAddress, new [] { "Address" });
            }

            // PendingOwner (string) maxLength
            if (this.PendingOwner != null && this.PendingOwner.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PendingOwner, length must be less than 42.", new [] { "PendingOwner" });
            }

            // PendingOwner (string) minLength
            if (this.PendingOwner != null && this.PendingOwner.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PendingOwner, length must be greater than 30.", new [] { "PendingOwner" });
            }

            // PendingOwner (string) pattern
            Regex regexPendingOwner = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexPendingOwner.Match(this.PendingOwner).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PendingOwner, must match a pattern of " + regexPendingOwner, new [] { "PendingOwner" });
            }

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
            Regex regexOwner = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexOwner.Match(this.Owner).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Owner, must match a pattern of " + regexOwner, new [] { "Owner" });
            }

            // TransactionFeePercent (decimal) maximum
            if (this.TransactionFeePercent > (decimal)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionFeePercent, must be a value less than or equal to 1.0.", new [] { "TransactionFeePercent" });
            }

            // TransactionFeePercent (decimal) minimum
            if (this.TransactionFeePercent < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionFeePercent, must be a value greater than or equal to 0.0.", new [] { "TransactionFeePercent" });
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
