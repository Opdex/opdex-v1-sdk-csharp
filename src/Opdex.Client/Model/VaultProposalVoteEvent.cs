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
    /// Indicates a vote was made on a vault proposal
    /// </summary>
    [DataContract(Name = "vaultProposalVoteEvent")]
    public partial class VaultProposalVoteEvent : IEquatable<VaultProposalVoteEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultProposalVoteEvent" /> class.
        /// </summary>
        /// <param name="proposalId">Identifier for the proposal.</param>
        /// <param name="voter">An address on the Cirrus network.</param>
        /// <param name="inFavor">Whether the vote is in favor or against the proposal.</param>
        /// <param name="voteAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="voterAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="proposalYesAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="proposalNoAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="contract">An address on the Cirrus network.</param>
        /// <param name="sortOrder">Index to sort event order.</param>
        public VaultProposalVoteEvent(decimal proposalId = default(decimal), string voter = default(string), bool inFavor = default(bool), string voteAmount = default(string), string voterAmount = default(string), string proposalYesAmount = default(string), string proposalNoAmount = default(string), TransactionEventType eventType = default(TransactionEventType), string contract = default(string), int sortOrder = default(int))
        {
            this.ProposalId = proposalId;
            this.Voter = voter;
            this.InFavor = inFavor;
            this.VoteAmount = voteAmount;
            this.VoterAmount = voterAmount;
            this.ProposalYesAmount = proposalYesAmount;
            this.ProposalNoAmount = proposalNoAmount;
            this.EventType = eventType;
            this.Contract = contract;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Identifier for the proposal
        /// </summary>
        /// <value>Identifier for the proposal</value>
        [DataMember(Name = "proposalId", EmitDefaultValue = false)]
        public decimal ProposalId { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "voter", EmitDefaultValue = false)]
        public string Voter { get; set; }

        /// <summary>
        /// Whether the vote is in favor or against the proposal
        /// </summary>
        /// <value>Whether the vote is in favor or against the proposal</value>
        [DataMember(Name = "inFavor", EmitDefaultValue = true)]
        public bool InFavor { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "voteAmount", EmitDefaultValue = false)]
        public string VoteAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "voterAmount", EmitDefaultValue = false)]
        public string VoterAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "proposalYesAmount", EmitDefaultValue = false)]
        public string ProposalYesAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "proposalNoAmount", EmitDefaultValue = false)]
        public string ProposalNoAmount { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public TransactionEventType EventType { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "contract", EmitDefaultValue = false)]
        public string Contract { get; set; }

        /// <summary>
        /// Index to sort event order
        /// </summary>
        /// <value>Index to sort event order</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VaultProposalVoteEvent {\n");
            sb.Append("  ProposalId: ").Append(ProposalId).Append("\n");
            sb.Append("  Voter: ").Append(Voter).Append("\n");
            sb.Append("  InFavor: ").Append(InFavor).Append("\n");
            sb.Append("  VoteAmount: ").Append(VoteAmount).Append("\n");
            sb.Append("  VoterAmount: ").Append(VoterAmount).Append("\n");
            sb.Append("  ProposalYesAmount: ").Append(ProposalYesAmount).Append("\n");
            sb.Append("  ProposalNoAmount: ").Append(ProposalNoAmount).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as VaultProposalVoteEvent);
        }

        /// <summary>
        /// Returns true if VaultProposalVoteEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultProposalVoteEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultProposalVoteEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProposalId == input.ProposalId ||
                    this.ProposalId.Equals(input.ProposalId)
                ) && 
                (
                    this.Voter == input.Voter ||
                    (this.Voter != null &&
                    this.Voter.Equals(input.Voter))
                ) && 
                (
                    this.InFavor == input.InFavor ||
                    this.InFavor.Equals(input.InFavor)
                ) && 
                (
                    this.VoteAmount == input.VoteAmount ||
                    (this.VoteAmount != null &&
                    this.VoteAmount.Equals(input.VoteAmount))
                ) && 
                (
                    this.VoterAmount == input.VoterAmount ||
                    (this.VoterAmount != null &&
                    this.VoterAmount.Equals(input.VoterAmount))
                ) && 
                (
                    this.ProposalYesAmount == input.ProposalYesAmount ||
                    (this.ProposalYesAmount != null &&
                    this.ProposalYesAmount.Equals(input.ProposalYesAmount))
                ) && 
                (
                    this.ProposalNoAmount == input.ProposalNoAmount ||
                    (this.ProposalNoAmount != null &&
                    this.ProposalNoAmount.Equals(input.ProposalNoAmount))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
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
                hashCode = (hashCode * 59) + this.ProposalId.GetHashCode();
                if (this.Voter != null)
                {
                    hashCode = (hashCode * 59) + this.Voter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InFavor.GetHashCode();
                if (this.VoteAmount != null)
                {
                    hashCode = (hashCode * 59) + this.VoteAmount.GetHashCode();
                }
                if (this.VoterAmount != null)
                {
                    hashCode = (hashCode * 59) + this.VoterAmount.GetHashCode();
                }
                if (this.ProposalYesAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ProposalYesAmount.GetHashCode();
                }
                if (this.ProposalNoAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ProposalNoAmount.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
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
            // ProposalId (decimal) minimum
            if (this.ProposalId < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProposalId, must be a value greater than or equal to 1.", new [] { "ProposalId" });
            }

            // Voter (string) maxLength
            if (this.Voter != null && this.Voter.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Voter, length must be less than 42.", new [] { "Voter" });
            }

            // Voter (string) minLength
            if (this.Voter != null && this.Voter.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Voter, length must be greater than 30.", new [] { "Voter" });
            }

            // Voter (string) pattern
            Regex regexVoter = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexVoter.Match(this.Voter).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Voter, must match a pattern of " + regexVoter, new [] { "Voter" });
            }

            // VoteAmount (string) pattern
            Regex regexVoteAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexVoteAmount.Match(this.VoteAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoteAmount, must match a pattern of " + regexVoteAmount, new [] { "VoteAmount" });
            }

            // VoterAmount (string) pattern
            Regex regexVoterAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexVoterAmount.Match(this.VoterAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoterAmount, must match a pattern of " + regexVoterAmount, new [] { "VoterAmount" });
            }

            // ProposalYesAmount (string) pattern
            Regex regexProposalYesAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexProposalYesAmount.Match(this.ProposalYesAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProposalYesAmount, must match a pattern of " + regexProposalYesAmount, new [] { "ProposalYesAmount" });
            }

            // ProposalNoAmount (string) pattern
            Regex regexProposalNoAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexProposalNoAmount.Match(this.ProposalNoAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProposalNoAmount, must match a pattern of " + regexProposalNoAmount, new [] { "ProposalNoAmount" });
            }

            // Contract (string) maxLength
            if (this.Contract != null && this.Contract.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, length must be less than 42.", new [] { "Contract" });
            }

            // Contract (string) minLength
            if (this.Contract != null && this.Contract.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, length must be greater than 30.", new [] { "Contract" });
            }

            // Contract (string) pattern
            Regex regexContract = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexContract.Match(this.Contract).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, must match a pattern of " + regexContract, new [] { "Contract" });
            }

            // SortOrder (int) minimum
            if (this.SortOrder < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortOrder, must be a value greater than or equal to 0.", new [] { "SortOrder" });
            }

            yield break;
        }
    }

}
