# Opdex.Client.Api.MarketTokensApi

All URIs are relative to *https://v1-test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketToken**](MarketTokensApi.md#getmarkettoken) | **GET** /markets/{market}/tokens/{token} | Get Market Token
[**GetMarketTokenHistory**](MarketTokensApi.md#getmarkettokenhistory) | **GET** /markets/{market}/tokens/{token}/history | Get Market Token History
[**GetMarketTokens**](MarketTokensApi.md#getmarkettokens) | **GET** /markets/{market}/tokens | Get Market Tokens
[**GetSwapAmountInQuote**](MarketTokensApi.md#getswapamountinquote) | **POST** /markets/{market}/tokens/{token}/swap/amount-in | Swap Amount In Quote
[**GetSwapAmountOutQuote**](MarketTokensApi.md#getswapamountoutquote) | **POST** /markets/{market}/tokens/{token}/swap/amount-out | Swap Amount Out Quote
[**Swap**](MarketTokensApi.md#swap) | **POST** /markets/{market}/tokens/{token}/swap | Build Swap Tokens Transaction Quote


<a name="getmarkettoken"></a>
# **GetMarketToken**
> MarketTokenResponse GetMarketToken (string market, string token)

Get Market Token

Retrieves details of a token, that is tracked within a specified market.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetMarketTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketTokensApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of the market
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the token

            try
            {
                // Get Market Token
                MarketTokenResponse result = apiInstance.GetMarketToken(market, token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketTokensApi.GetMarketToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Address of the market | 
 **token** | **string**| Address of the token | 

### Return type

[**MarketTokenResponse**](MarketTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Market token found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Market or token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarkettokenhistory"></a>
# **GetMarketTokenHistory**
> TokenSnapshotsResponse GetMarketTokenHistory (string market, string token, Interval? interval = null, DateTime? startDateTime = null, DateTime? endDateTime = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Market Token History

Retrieves historical pricing data for a token tracked within a specified market. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetMarketTokenHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketTokensApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of the market
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the token
            var interval = 1D;  // Interval? | Time range between each snapshot (optional) 
            var startDateTime = 2022-01-01T00:00:00Z;  // DateTime? | Start time for which to retrieve snapshots (optional) 
            var endDateTime = 2022-12-31T23:59:59;  // DateTime? | End time for which to retrieve snapshots (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 100;  // int? | Number of results per page; defaults to 168 for hourly snapshots (1 week), or 28 for daily snapshots (4 weeks) (optional)  (default to 168)
            var cursor = "cursor_example";  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Market Token History
                TokenSnapshotsResponse result = apiInstance.GetMarketTokenHistory(market, token, interval, startDateTime, endDateTime, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketTokensApi.GetMarketTokenHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Address of the market | 
 **token** | **string**| Address of the token | 
 **interval** | **Interval?**| Time range between each snapshot | [optional] 
 **startDateTime** | **DateTime?**| Start time for which to retrieve snapshots | [optional] 
 **endDateTime** | **DateTime?**| End time for which to retrieve snapshots | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page; defaults to 168 for hourly snapshots (1 week), or 28 for daily snapshots (4 weeks) | [optional] [default to 168]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**TokenSnapshotsResponse**](TokenSnapshotsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Market token snapshot results found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Market or token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarkettokens"></a>
# **GetMarketTokens**
> MarketTokensResponse GetMarketTokens (string market, List<TokenAttributeFilter> tokenAttributes = null, List<ChainFilter> nativeChains = null, List<string> tokens = null, string keyword = null, TokenOrderByType? orderBy = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Market Tokens

Retrieves details of tokens tracked within a specified market. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetMarketTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketTokensApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of the market
            var tokenAttributes = new List<TokenAttributeFilter>(); // List<TokenAttributeFilter> | Token attributes filter (optional) 
            var nativeChains = new List<ChainFilter>(); // List<ChainFilter> | Native chain filter (optional) 
            var tokens = new List<string>(); // List<string> | Specific tokens to include (optional) 
            var keyword = "keyword_example";  // string | Keyword search against token address, name and ticker symbol (optional) 
            var orderBy = PriceUsd;  // TokenOrderByType? | Property by which to sort results (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = "cursor_example";  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Market Tokens
                MarketTokensResponse result = apiInstance.GetMarketTokens(market, tokenAttributes, nativeChains, tokens, keyword, orderBy, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketTokensApi.GetMarketTokens: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Address of the market | 
 **tokenAttributes** | [**List&lt;TokenAttributeFilter&gt;**](TokenAttributeFilter.md)| Token attributes filter | [optional] 
 **nativeChains** | [**List&lt;ChainFilter&gt;**](ChainFilter.md)| Native chain filter | [optional] 
 **tokens** | [**List&lt;string&gt;**](string.md)| Specific tokens to include | [optional] 
 **keyword** | **string**| Keyword search against token address, name and ticker symbol | [optional] 
 **orderBy** | **TokenOrderByType?**| Property by which to sort results | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**MarketTokensResponse**](MarketTokensResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Market token results found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getswapamountinquote"></a>
# **GetSwapAmountInQuote**
> SwapAmountInQuoteResponse GetSwapAmountInQuote (string market, string token, SwapAmountInQuoteRequest swapAmountInQuoteRequest)

Swap Amount In Quote

Retrieves an estimate for the amount of tokens to be input, given a swap output.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetSwapAmountInQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketTokensApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of the market
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the input token
            var swapAmountInQuoteRequest = new SwapAmountInQuoteRequest(); // SwapAmountInQuoteRequest | 

            try
            {
                // Swap Amount In Quote
                SwapAmountInQuoteResponse result = apiInstance.GetSwapAmountInQuote(market, token, swapAmountInQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketTokensApi.GetSwapAmountInQuote: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Address of the market | 
 **token** | **string**| Address of the input token | 
 **swapAmountInQuoteRequest** | [**SwapAmountInQuoteRequest**](SwapAmountInQuoteRequest.md)|  | 

### Return type

[**SwapAmountInQuoteResponse**](SwapAmountInQuoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Swap amount in quote retrieved |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Market or token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getswapamountoutquote"></a>
# **GetSwapAmountOutQuote**
> SwapAmountOutQuoteResponse GetSwapAmountOutQuote (string market, string token, SwapAmountOutQuoteRequest swapAmountOutQuoteRequest)

Swap Amount Out Quote

Retrieves an estimate for the amount of tokens output, given a swap input.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetSwapAmountOutQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketTokensApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of the market
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the input token
            var swapAmountOutQuoteRequest = new SwapAmountOutQuoteRequest(); // SwapAmountOutQuoteRequest | 

            try
            {
                // Swap Amount Out Quote
                SwapAmountOutQuoteResponse result = apiInstance.GetSwapAmountOutQuote(market, token, swapAmountOutQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketTokensApi.GetSwapAmountOutQuote: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Address of the market | 
 **token** | **string**| Address of the input token | 
 **swapAmountOutQuoteRequest** | [**SwapAmountOutQuoteRequest**](SwapAmountOutQuoteRequest.md)|  | 

### Return type

[**SwapAmountOutQuoteResponse**](SwapAmountOutQuoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Swap amount out quote retrieved |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Market or token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swap"></a>
# **Swap**
> TransactionQuoteResponse Swap (string market, string token, QuoteSwapTransactionRequest quoteSwapTransactionRequest)

Build Swap Tokens Transaction Quote

Builds a quote for a token swap transaction. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class SwapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketTokensApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of the market
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the input token
            var quoteSwapTransactionRequest = new QuoteSwapTransactionRequest(); // QuoteSwapTransactionRequest | 

            try
            {
                // Build Swap Tokens Transaction Quote
                TransactionQuoteResponse result = apiInstance.Swap(market, token, quoteSwapTransactionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketTokensApi.Swap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Address of the market | 
 **token** | **string**| Address of the input token | 
 **quoteSwapTransactionRequest** | [**QuoteSwapTransactionRequest**](QuoteSwapTransactionRequest.md)|  | 

### Return type

[**TransactionQuoteResponse**](TransactionQuoteResponse.md)

### Authorization

[opdexAuth](../README.md#opdexAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Built swap transaction quote |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Market or token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

