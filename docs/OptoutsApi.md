# Au.Com.Dingomail.Api.Dingomailau.Api.OptoutsApi

All URIs are relative to *https://api.dingomail.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUnsubscribes**](OptoutsApi.md#getunsubscribes) | **GET** /optouts | 


<a name="getunsubscribes"></a>
# **GetUnsubscribes**
> List&lt;GetUnsubscribes&gt; GetUnsubscribes (string keyid)



Get list of email addresses that have unsubscribed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Au.Com.Dingomail.Api.Dingomailau.Api;
using Au.Com.Dingomail.Api.Dingomailau.Client;
using Au.Com.Dingomail.Api.Dingomailau.Model;

namespace Example
{
    public class GetUnsubscribesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dingomail.com.au";
            // Configure API key authorization: Key Secret
            config.AddApiKey("keysecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("keysecret", "Bearer");

            var apiInstance = new OptoutsApi(config);
            var keyid = ;  // string | The ID of the API Key being used

            try
            {
                List<GetUnsubscribes> result = apiInstance.GetUnsubscribes(keyid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptoutsApi.GetUnsubscribes: " + e.Message );
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
 **keyid** | **string**| The ID of the API Key being used | 

### Return type

[**List&lt;GetUnsubscribes&gt;**](GetUnsubscribes.md)

### Authorization

[Key Secret](../README.md#Key Secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

