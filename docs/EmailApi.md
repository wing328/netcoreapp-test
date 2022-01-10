# Au.Com.Dingomail.Api.Dingomailau.Api.EmailApi

All URIs are relative to *https://api.dingomail.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckStatus**](EmailApi.md#checkstatus) | **GET** /email/{id} | 
[**Create**](EmailApi.md#create) | **POST** /email | 


<a name="checkstatus"></a>
# **CheckStatus**
> CheckStatus CheckStatus (string id, string keyid)



Check the status of an email previously sent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Au.Com.Dingomail.Api.Dingomailau.Api;
using Au.Com.Dingomail.Api.Dingomailau.Client;
using Au.Com.Dingomail.Api.Dingomailau.Model;

namespace Example
{
    public class CheckStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dingomail.com.au";
            // Configure API key authorization: Key Secret
            config.AddApiKey("keysecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("keysecret", "Bearer");

            var apiInstance = new EmailApi(config);
            var id = 61ad5fae747be1587d421562;  // string | ID of the Email
            var keyid = ;  // string | The ID of the API Key being used

            try
            {
                CheckStatus result = apiInstance.CheckStatus(id, keyid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailApi.CheckStatus: " + e.Message );
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
 **id** | **string**| ID of the Email | 
 **keyid** | **string**| The ID of the API Key being used | 

### Return type

[**CheckStatus**](CheckStatus.md)

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

<a name="create"></a>
# **Create**
> EmailResponse Create (string keyid, NewEmail newEmail)



Create a new email message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Au.Com.Dingomail.Api.Dingomailau.Api;
using Au.Com.Dingomail.Api.Dingomailau.Client;
using Au.Com.Dingomail.Api.Dingomailau.Model;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dingomail.com.au";
            // Configure API key authorization: Key Secret
            config.AddApiKey("keysecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("keysecret", "Bearer");

            var apiInstance = new EmailApi(config);
            var keyid = ;  // string | The ID of the API Key being used
            var newEmail = new NewEmail(); // NewEmail | Email Data

            try
            {
                EmailResponse result = apiInstance.Create(keyid, newEmail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailApi.Create: " + e.Message );
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
 **newEmail** | [**NewEmail**](NewEmail.md)| Email Data | 

### Return type

[**EmailResponse**](EmailResponse.md)

### Authorization

[Key Secret](../README.md#Key Secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

