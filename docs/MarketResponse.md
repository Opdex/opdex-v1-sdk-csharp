# Opdex.Client.Model.MarketResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | An address on the Cirrus network | [optional] 
**PendingOwner** | **string** | An address on the Cirrus network | [optional] 
**Owner** | **string** | An address on the Cirrus network | [optional] 
**Tokens** | [**MarketTokenBreakdown**](MarketTokenBreakdown.md) |  | [optional] 
**AuthPoolCreators** | **bool** | Whether the market owner authorizes liquidity pool creators | [optional] 
**AuthTraders** | **bool** | Whether the market owner authorizes traders | [optional] 
**AuthProviders** | **bool** | Whether the market owner authorizes liquidity providers | [optional] 
**MarketFeeEnabled** | **bool** | Whether the market fee is enabled | [optional] 
**TransactionFeePercent** | **string** | Decimal value with uncapped precision and size | [optional] 
**CreatedBlock** | **int** | Block number at which the entity was created | [optional] 
**ModifiedBlock** | **int** | Block number at which the entity state was last modified | [optional] 
**Summary** | [**MarketSummary**](MarketSummary.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

