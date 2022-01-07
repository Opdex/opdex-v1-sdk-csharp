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
    ///  Class for testing EnableMiningEvent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EnableMiningEventTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EnableMiningEvent
        //private EnableMiningEvent instance;

        public EnableMiningEventTests()
        {
            // TODO uncomment below to create an instance of EnableMiningEvent
            //instance = new EnableMiningEvent();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EnableMiningEvent
        /// </summary>
        [Fact]
        public void EnableMiningEventInstanceTest()
        {
            // TODO uncomment below to test "IsType" EnableMiningEvent
            //Assert.IsType<EnableMiningEvent>(instance);
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'RewardRate'
        /// </summary>
        [Fact]
        public void RewardRateTest()
        {
            // TODO unit test for the property 'RewardRate'
        }
        /// <summary>
        /// Test the property 'MiningPeriodEndBlock'
        /// </summary>
        [Fact]
        public void MiningPeriodEndBlockTest()
        {
            // TODO unit test for the property 'MiningPeriodEndBlock'
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