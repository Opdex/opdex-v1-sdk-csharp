# Opdex.Client - the C# library for the Opdex Platform API

The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0-alpha1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://github.com/Opdex/opdex-v1-api](https://github.com/Opdex/opdex-v1-api)

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Opdex.Client.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new AuthenticationApi(config);
            var uid = Lf5t5J-oAn3CZ9YY27JnK5XtpbjIOD3BxyvHhd80AQ4fsJ7o0J8i5uSjzHZ9jeS3;  // string | Unique identifier for the Stratis ID
            var stratisSignatureAuthRequest = new StratisSignatureAuthRequest(); // StratisSignatureAuthRequest | The Stratis Signature Auth body
            var exp = 1641220000;  // long? | Unix timestamp indicating when the signature expires (optional) 

            try
            {
                // Stratis Signature Auth
                apiInstance.AuthPost(uid, stratisSignatureAuthRequest, exp);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://test-api.opdex.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**AuthPost**](docs/AuthenticationApi.md#authpost) | **POST** /auth | Stratis Signature Auth
*MarketTokensApi* | [**MarketsMarketTokensGet**](docs/MarketTokensApi.md#marketsmarkettokensget) | **GET** /markets/{market}/tokens | Get Market Tokens
*MarketTokensApi* | [**MarketsMarketTokensTokenGet**](docs/MarketTokensApi.md#marketsmarkettokenstokenget) | **GET** /markets/{market}/tokens/{token} | Get Market Token
*MarketTokensApi* | [**MarketsMarketTokensTokenHistoryGet**](docs/MarketTokensApi.md#marketsmarkettokenstokenhistoryget) | **GET** /markets/{market}/tokens/{token}/history | Get Market Token History
*MarketTokensApi* | [**MarketsMarketTokensTokenSwapAmountInPost**](docs/MarketTokensApi.md#marketsmarkettokenstokenswapamountinpost) | **POST** /markets/{market}/tokens/{token}/swap/amount-in | Swap Amount In Quote
*MarketTokensApi* | [**MarketsMarketTokensTokenSwapAmountOutPost**](docs/MarketTokensApi.md#marketsmarkettokenstokenswapamountoutpost) | **POST** /markets/{market}/tokens/{token}/swap/amount-out | Swap Amount Out Quote
*MarketTokensApi* | [**MarketsMarketTokensTokenSwapPost**](docs/MarketTokensApi.md#marketsmarkettokenstokenswappost) | **POST** /markets/{market}/tokens/{token}/swap | Build Swap Tokens Transaction Quote
*MarketsApi* | [**MarketsGet**](docs/MarketsApi.md#marketsget) | **GET** /markets | Get Markets
*StatusApi* | [**StatusGet**](docs/StatusApi.md#statusget) | **GET** /status | Get Status
*TokensApi* | [**TokensGet**](docs/TokensApi.md#tokensget) | **GET** /tokens | Get Tokens
*TokensApi* | [**TokensPost**](docs/TokensApi.md#tokenspost) | **POST** /tokens | Add Token
*TokensApi* | [**TokensTokenApprovePost**](docs/TokensApi.md#tokenstokenapprovepost) | **POST** /tokens/{token}/approve | Build Approve Allowance Transaction Quote
*TokensApi* | [**TokensTokenDistributePost**](docs/TokensApi.md#tokenstokendistributepost) | **POST** /tokens/{token}/distribute | Build Distribute Tokens Transaction Quote
*TokensApi* | [**TokensTokenGet**](docs/TokensApi.md#tokenstokenget) | **GET** /tokens/{token} | Get Token
*TokensApi* | [**TokensTokenHistoryGet**](docs/TokensApi.md#tokenstokenhistoryget) | **GET** /tokens/{token}/history | Get Token History
*TransactionsApi* | [**TransactionHashGet**](docs/TransactionsApi.md#transactionhashget) | **GET** /transaction/{hash} | Get Transaction
*TransactionsApi* | [**TransactionReplayQuotePost**](docs/TransactionsApi.md#transactionreplayquotepost) | **POST** /transaction/replay-quote | Replay Transaction Quote
*TransactionsApi* | [**TransactionsGet**](docs/TransactionsApi.md#transactionsget) | **GET** /transactions | Get Transactions
*TransactionsApi* | [**TransactionsPost**](docs/TransactionsApi.md#transactionspost) | **POST** /transactions | Notify Broadcast


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddLiquidityEvent](docs/AddLiquidityEvent.md)
 - [Model.AddTokenRequest](docs/AddTokenRequest.md)
 - [Model.ApprovalEvent](docs/ApprovalEvent.md)
 - [Model.BlockResponse](docs/BlockResponse.md)
 - [Model.ChangeMarketPermissionEvent](docs/ChangeMarketPermissionEvent.md)
 - [Model.ClaimPendingDeployerOwnershipEvent](docs/ClaimPendingDeployerOwnershipEvent.md)
 - [Model.ClaimPendingMarketOwnershipEvent](docs/ClaimPendingMarketOwnershipEvent.md)
 - [Model.CollectMiningRewardsEvent](docs/CollectMiningRewardsEvent.md)
 - [Model.CollectStakingRewardsEvent](docs/CollectStakingRewardsEvent.md)
 - [Model.CompleteVaultProposalEvent](docs/CompleteVaultProposalEvent.md)
 - [Model.CreateLiquidityPoolEvent](docs/CreateLiquidityPoolEvent.md)
 - [Model.CreateMarketEvent](docs/CreateMarketEvent.md)
 - [Model.CreateVaultCertificateEvent](docs/CreateVaultCertificateEvent.md)
 - [Model.CreateVaultProposalEvent](docs/CreateVaultProposalEvent.md)
 - [Model.DistributionEvent](docs/DistributionEvent.md)
 - [Model.EnableMiningEvent](docs/EnableMiningEvent.md)
 - [Model.Interval](docs/Interval.md)
 - [Model.MarketOrderByType](docs/MarketOrderByType.md)
 - [Model.MarketPermission](docs/MarketPermission.md)
 - [Model.MarketResponse](docs/MarketResponse.md)
 - [Model.MarketSummary](docs/MarketSummary.md)
 - [Model.MarketTokenResponse](docs/MarketTokenResponse.md)
 - [Model.MarketTokensResponse](docs/MarketTokensResponse.md)
 - [Model.MarketType](docs/MarketType.md)
 - [Model.MarketsResponse](docs/MarketsResponse.md)
 - [Model.NominationEvent](docs/NominationEvent.md)
 - [Model.NotifyBroadcastRequest](docs/NotifyBroadcastRequest.md)
 - [Model.OhlcDecimalResponse](docs/OhlcDecimalResponse.md)
 - [Model.PagingResponse](docs/PagingResponse.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.ProposalStatus](docs/ProposalStatus.md)
 - [Model.ProposalType](docs/ProposalType.md)
 - [Model.QuoteSwapTransactionRequest](docs/QuoteSwapTransactionRequest.md)
 - [Model.RemoveLiquidityEvent](docs/RemoveLiquidityEvent.md)
 - [Model.ReplayQuoteRequest](docs/ReplayQuoteRequest.md)
 - [Model.RevokeVaultCertificateEvent](docs/RevokeVaultCertificateEvent.md)
 - [Model.RewardMiningPoolEvent](docs/RewardMiningPoolEvent.md)
 - [Model.RewardSummary](docs/RewardSummary.md)
 - [Model.SetPendingDeployerOwnershipEvent](docs/SetPendingDeployerOwnershipEvent.md)
 - [Model.SetPendingMarketOwnershipEvent](docs/SetPendingMarketOwnershipEvent.md)
 - [Model.SortDirection](docs/SortDirection.md)
 - [Model.StakingSummary](docs/StakingSummary.md)
 - [Model.StartMiningEvent](docs/StartMiningEvent.md)
 - [Model.StartStakingEvent](docs/StartStakingEvent.md)
 - [Model.StatusResponse](docs/StatusResponse.md)
 - [Model.StopMiningEvent](docs/StopMiningEvent.md)
 - [Model.StopStakingEvent](docs/StopStakingEvent.md)
 - [Model.StratisSignatureAuthRequest](docs/StratisSignatureAuthRequest.md)
 - [Model.SwapAmountInQuoteRequest](docs/SwapAmountInQuoteRequest.md)
 - [Model.SwapAmountInQuoteResponse](docs/SwapAmountInQuoteResponse.md)
 - [Model.SwapAmountOutQuoteRequest](docs/SwapAmountOutQuoteRequest.md)
 - [Model.SwapAmountOutQuoteResponse](docs/SwapAmountOutQuoteResponse.md)
 - [Model.SwapEvent](docs/SwapEvent.md)
 - [Model.TokenAddress](docs/TokenAddress.md)
 - [Model.TokenOrderByType](docs/TokenOrderByType.md)
 - [Model.TokenResponse](docs/TokenResponse.md)
 - [Model.TokenSnapshotResponse](docs/TokenSnapshotResponse.md)
 - [Model.TokenSnapshotsResponse](docs/TokenSnapshotsResponse.md)
 - [Model.TokenSummaryResponse](docs/TokenSummaryResponse.md)
 - [Model.TokenType](docs/TokenType.md)
 - [Model.TokensResponse](docs/TokensResponse.md)
 - [Model.TransactionEvent](docs/TransactionEvent.md)
 - [Model.TransactionEventType](docs/TransactionEventType.md)
 - [Model.TransactionQuoteResponse](docs/TransactionQuoteResponse.md)
 - [Model.TransactionResponse](docs/TransactionResponse.md)
 - [Model.TransactionsResponse](docs/TransactionsResponse.md)
 - [Model.TransferEvent](docs/TransferEvent.md)
 - [Model.ValidationProblemDetails](docs/ValidationProblemDetails.md)
 - [Model.ValidationProblemDetailsAllOf](docs/ValidationProblemDetailsAllOf.md)
 - [Model.VaultProposalPledgeEvent](docs/VaultProposalPledgeEvent.md)
 - [Model.VaultProposalVoteEvent](docs/VaultProposalVoteEvent.md)
 - [Model.VaultProposalWithdrawPledgeEvent](docs/VaultProposalWithdrawPledgeEvent.md)
 - [Model.VaultProposalWithdrawVoteEvent](docs/VaultProposalWithdrawVoteEvent.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="opdexAuth"></a>
### opdexAuth

- **Type**: Bearer Authentication

