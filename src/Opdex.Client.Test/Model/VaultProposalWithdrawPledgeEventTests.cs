/*
 * Opdex Platform API
 *
 * The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Opdex.Client.Api;
using Opdex.Client.Model;
using Opdex.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Opdex.Client.Test.Model
{
    /// <summary>
    ///  Class for testing VaultProposalWithdrawPledgeEvent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VaultProposalWithdrawPledgeEventTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VaultProposalWithdrawPledgeEvent
        //private VaultProposalWithdrawPledgeEvent instance;

        public VaultProposalWithdrawPledgeEventTests()
        {
            // TODO uncomment below to create an instance of VaultProposalWithdrawPledgeEvent
            //instance = new VaultProposalWithdrawPledgeEvent();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VaultProposalWithdrawPledgeEvent
        /// </summary>
        [Fact]
        public void VaultProposalWithdrawPledgeEventInstanceTest()
        {
            // TODO uncomment below to test "IsType" VaultProposalWithdrawPledgeEvent
            //Assert.IsType<VaultProposalWithdrawPledgeEvent>(instance);
        }


        /// <summary>
        /// Test the property 'ProposalId'
        /// </summary>
        [Fact]
        public void ProposalIdTest()
        {
            // TODO unit test for the property 'ProposalId'
        }
        /// <summary>
        /// Test the property 'Pledger'
        /// </summary>
        [Fact]
        public void PledgerTest()
        {
            // TODO unit test for the property 'Pledger'
        }
        /// <summary>
        /// Test the property 'WithdrawAmount'
        /// </summary>
        [Fact]
        public void WithdrawAmountTest()
        {
            // TODO unit test for the property 'WithdrawAmount'
        }
        /// <summary>
        /// Test the property 'PledgerAmount'
        /// </summary>
        [Fact]
        public void PledgerAmountTest()
        {
            // TODO unit test for the property 'PledgerAmount'
        }
        /// <summary>
        /// Test the property 'ProposalPledgeAmount'
        /// </summary>
        [Fact]
        public void ProposalPledgeAmountTest()
        {
            // TODO unit test for the property 'ProposalPledgeAmount'
        }
        /// <summary>
        /// Test the property 'PledgeWithdrawn'
        /// </summary>
        [Fact]
        public void PledgeWithdrawnTest()
        {
            // TODO unit test for the property 'PledgeWithdrawn'
        }
        /// <summary>
        /// Test the property 'EventType'
        /// </summary>
        [Fact]
        public void EventTypeTest()
        {
            // TODO unit test for the property 'EventType'
        }
        /// <summary>
        /// Test the property 'Contract'
        /// </summary>
        [Fact]
        public void ContractTest()
        {
            // TODO unit test for the property 'Contract'
        }
        /// <summary>
        /// Test the property 'SortOrder'
        /// </summary>
        [Fact]
        public void SortOrderTest()
        {
            // TODO unit test for the property 'SortOrder'
        }

    }

}