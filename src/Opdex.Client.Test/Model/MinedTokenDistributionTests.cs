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
    ///  Class for testing MinedTokenDistribution
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MinedTokenDistributionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MinedTokenDistribution
        //private MinedTokenDistribution instance;

        public MinedTokenDistributionTests()
        {
            // TODO uncomment below to create an instance of MinedTokenDistribution
            //instance = new MinedTokenDistribution();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MinedTokenDistribution
        /// </summary>
        [Fact]
        public void MinedTokenDistributionInstanceTest()
        {
            // TODO uncomment below to test "IsType" MinedTokenDistribution
            //Assert.IsType<MinedTokenDistribution>(instance);
        }


        /// <summary>
        /// Test the property 'Vault'
        /// </summary>
        [Fact]
        public void VaultTest()
        {
            // TODO unit test for the property 'Vault'
        }
        /// <summary>
        /// Test the property 'MiningGovernance'
        /// </summary>
        [Fact]
        public void MiningGovernanceTest()
        {
            // TODO unit test for the property 'MiningGovernance'
        }
        /// <summary>
        /// Test the property 'Block'
        /// </summary>
        [Fact]
        public void BlockTest()
        {
            // TODO unit test for the property 'Block'
        }

    }

}
