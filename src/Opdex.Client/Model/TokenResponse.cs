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
    /// Details of a token
    /// </summary>
    [DataContract(Name = "tokenResponse")]
    public partial class TokenResponse : IEquatable<TokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponse" /> class.
        /// </summary>
        /// <param name="address">An address on the Cirrus network.</param>
        /// <param name="name">Name of the token.</param>
        /// <param name="symbol">Token ticker symbol.</param>
        /// <param name="decimals">Number of decimals of precision for token values.</param>
        /// <param name="sats">Number of parts which make up one whole token.</param>
        /// <param name="totalSupply">Decimal value with uncapped precision and size.</param>
        /// <param name="attributes">Attributes applied to the token.</param>
        /// <param name="wrappedToken">wrappedToken.</param>
        /// <param name="distribution">distribution.</param>
        /// <param name="createdBlock">Block number at which the entity was created.</param>
        /// <param name="modifiedBlock">Block number at which the entity state was last modified.</param>
        /// <param name="summary">summary.</param>
        public TokenResponse(string address = default(string), string name = default(string), string symbol = default(string), int decimals = default(int), string sats = default(string), string totalSupply = default(string), List<TokenAttribute> attributes = default(List<TokenAttribute>), WrappedTokenDetails wrappedToken = default(WrappedTokenDetails), MinedTokenDistributionDetails distribution = default(MinedTokenDistributionDetails), int createdBlock = default(int), int modifiedBlock = default(int), TokenSummary summary = default(TokenSummary))
        {
            this.Address = address;
            this.Name = name;
            this.Symbol = symbol;
            this.Decimals = decimals;
            this.Sats = sats;
            this.TotalSupply = totalSupply;
            this.Attributes = attributes;
            this.WrappedToken = wrappedToken;
            this.Distribution = distribution;
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
        /// Name of the token
        /// </summary>
        /// <value>Name of the token</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Token ticker symbol
        /// </summary>
        /// <value>Token ticker symbol</value>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Number of decimals of precision for token values
        /// </summary>
        /// <value>Number of decimals of precision for token values</value>
        [DataMember(Name = "decimals", EmitDefaultValue = false)]
        public int Decimals { get; set; }

        /// <summary>
        /// Number of parts which make up one whole token
        /// </summary>
        /// <value>Number of parts which make up one whole token</value>
        [DataMember(Name = "sats", EmitDefaultValue = false)]
        public string Sats { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "totalSupply", EmitDefaultValue = false)]
        public string TotalSupply { get; set; }

        /// <summary>
        /// Attributes applied to the token
        /// </summary>
        /// <value>Attributes applied to the token</value>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public List<TokenAttribute> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets WrappedToken
        /// </summary>
        [DataMember(Name = "wrappedToken", EmitDefaultValue = false)]
        public WrappedTokenDetails WrappedToken { get; set; }

        /// <summary>
        /// Gets or Sets Distribution
        /// </summary>
        [DataMember(Name = "distribution", EmitDefaultValue = false)]
        public MinedTokenDistributionDetails Distribution { get; set; }

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
        public TokenSummary Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  Sats: ").Append(Sats).Append("\n");
            sb.Append("  TotalSupply: ").Append(TotalSupply).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  WrappedToken: ").Append(WrappedToken).Append("\n");
            sb.Append("  Distribution: ").Append(Distribution).Append("\n");
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
            return this.Equals(input as TokenResponse);
        }

        /// <summary>
        /// Returns true if TokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenResponse input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Decimals == input.Decimals ||
                    this.Decimals.Equals(input.Decimals)
                ) && 
                (
                    this.Sats == input.Sats ||
                    (this.Sats != null &&
                    this.Sats.Equals(input.Sats))
                ) && 
                (
                    this.TotalSupply == input.TotalSupply ||
                    (this.TotalSupply != null &&
                    this.TotalSupply.Equals(input.TotalSupply))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.WrappedToken == input.WrappedToken ||
                    (this.WrappedToken != null &&
                    this.WrappedToken.Equals(input.WrappedToken))
                ) && 
                (
                    this.Distribution == input.Distribution ||
                    (this.Distribution != null &&
                    this.Distribution.Equals(input.Distribution))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Decimals.GetHashCode();
                if (this.Sats != null)
                {
                    hashCode = (hashCode * 59) + this.Sats.GetHashCode();
                }
                if (this.TotalSupply != null)
                {
                    hashCode = (hashCode * 59) + this.TotalSupply.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.WrappedToken != null)
                {
                    hashCode = (hashCode * 59) + this.WrappedToken.GetHashCode();
                }
                if (this.Distribution != null)
                {
                    hashCode = (hashCode * 59) + this.Distribution.GetHashCode();
                }
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

            // Decimals (int) minimum
            if (this.Decimals < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Decimals, must be a value greater than or equal to 0.", new [] { "Decimals" });
            }

            // Sats (string) pattern
            Regex regexSats = new Regex(@"^[0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexSats.Match(this.Sats).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sats, must match a pattern of " + regexSats, new [] { "Sats" });
            }

            // TotalSupply (string) pattern
            Regex regexTotalSupply = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTotalSupply.Match(this.TotalSupply).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalSupply, must match a pattern of " + regexTotalSupply, new [] { "TotalSupply" });
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
