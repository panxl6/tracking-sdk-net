# AfterShip Tracking API library for C#

This library allows you to quickly and easily use the AfterShip Tracking API via C#.

For updates to this library, see our [GitHub release page](https://github.com/AfterShip/tracking-sdk-net/releases).

If you need support using AfterShip products, please contact support@aftership.com.

## Table of Contents

- [AfterShip Tracking API library for C#](#aftership-tracking-api-library-for-c)
    - [Table of Contents](#table-of-contents)
    - [Before you begin](#before-you-begin)
    - [Quick Start](#quick-start)
        - [Installation](#installation)
    - [Constructor](#constructor)
        - [Example](#example)
    - [Rate Limiter](#rate-limiter)
    - [Error Handling](#error-handling)
        - [Error List](#error-list)
    - [Endpoints](#endpoints)
        - [/trackings](#trackings)
        - [/couriers](#couriers)
        - [/last\_checkpoint](#last_checkpoint)
        - [/notifications](#notifications)
        - [/estimated-delivery-date](#estimated-delivery-date)
    - [Help](#help)
    - [License](#license)

## Before you begin

Before you begin to integrate:

- [Create an AfterShip account](https://admin.aftership.com/).
- [Create an API key](https://organization.automizely.com/api-keys).
- [Install .Net](https://dotnet.microsoft.com/en-us/download) version 6.0 or later.

## Quick Start

### Installation

Using the [.NET Core command-line interface (CLI) tools]:

```sh
dotnet add package Aftership
```

Using the [NuGet Command Line Interface (CLI)]:

```sh
nuget install Aftership
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Aftership".
5. Click on the Aftership package, select the appropriate version in the
   right-tab and click *Install*.

For with Visual Studio Code:

1. Open the Command Palette then type “NuGet Package Manager“
2. In the opened window, search for "Aftership".
3. Select the Aftership package and the package version.

## Constructor

Create AfterShip instance with options

| Name       | Type   | Required | Description                                                                                                                                                                                                               |
|------------|--------|----------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| api_key    | string | ✔        | Your AfterShip API key                                                                                                                                                                                                    |
| auth_type  | enum   |          | Default value: `AfterShipConfiguration.AUTHENTICATION_TYPE_API_KEY` <br > AES authentication: `AfterShipConfiguration.AUTHENTICATION_TYPE_AES` <br > RSA authentication: `AfterShipConfiguration.AUTHENTICATION_TYPE_RSA` |
| api_secret | string |          | Required if the authentication type is `AfterShipConfiguration.AUTHENTICATION_TYPE_AES` or `AfterShipConfiguration.AUTHENTICATION_TYPE_RSA`                                                                               |
| domain     | string |          | AfterShip API domain. Default value: https://api.aftership.com                                                                                                                                                            |
| user_agent | string |          | User-defined user-agent string, please follow [RFC9110](https://www.rfc-editor.org/rfc/rfc9110#field.user-agent) format standard.                                                                                         |
| proxy      | string |          | HTTP proxy URL to use for requests. <br > Default value: `null` <br > Example: `http://192.168.0.100:8888`                                                                                                                |
| max_retry  | number |          | Number of retries for each request. Default value: 2. Min is 0, Max is 10.                                                                                                                                                |
| timeout    | number |          | Timeout for each request in milliseconds.                                                                                                                                                                                 |

### Example

```csharp
using Tracking;

class Program
{
    static void Main()
    {
        try
        {
            AfterShipClient client = new AfterShipClient(
                            apiKey: "YOUR_API_KEY",
                            apiSecret: "YOUR_AES_SECRET",
                            authenticationType: AfterShipConfiguration.AUTHENTICATION_TYPE_AES);

            CreateTrackingOptions options = new CreateTrackingOptions();
            options.CreateTrackingRequest = new CreateTrackingRequest();
            TrackingCreateTrackingRequest newTracking = new TrackingCreateTrackingRequest();
            newTracking.TrackingNumber = "<tracking_number>";
            newTracking.Slug = "<slug>";
            options.CreateTrackingRequest.Tracking = newTracking;
            Tracking.Tracking tracking = client.Tracking.CreateTracking(options);
            if (tracking != null)
            {
                Console.WriteLine(tracking.Id);
            }
        }catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
```

## Rate Limiter

See the [Rate Limit](https://www.aftership.com/docs/tracking/2024-04/quickstart/rate-limit) to understand the AfterShip
rate limit policy.

## Error Handling

The SDK will return an error object when there is any error during the request, with the following specification:

| Name          | Type   | Description                    |
|---------------|--------|--------------------------------|
| message       | string | Detail message of the error    |
| code          | enum   | Error code enum for API Error. |
| meta_code     | number | API response meta code.        |
| status_code   | number | HTTP status code.              |
| response_body | string | API response body.             |

### Error List

| code                              | meta_code       | status_code     | message                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
|-----------------------------------|-----------------|-----------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| INVALID_REQUEST                   | 400             | 400             | The request was invalid or cannot be otherwise served.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| INVALID_JSON                      | 4001            | 400             | Invalid JSON data.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| TRACKING_ALREADY_EXIST            | 4003            | 400             | Tracking already exists.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| TRACKING_DOES_NOT_EXIST           | 4004            | 404             | Tracking does not exist.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| TRACKING_NUMBER_INVALID           | 4005            | 400             | The value of tracking_number is invalid.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| TRACKING_REQUIRED                 | 4006            | 400             | tracking object is required.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| TRACKING_NUMBER_REQUIRED          | 4007            | 400             | tracking_number is required.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| VALUE_INVALID                     | 4008            | 400             | The value of [field_name] is invalid.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| VALUE_REQUIRED                    | 4009            | 400             | [field_name] is required.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| SLUG_INVALID                      | 4010            | 400             | The value of slug is invalid.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| MISSING_OR_INVALID_REQUIRED_FIELD | 4011            | 400             | Missing or invalid value of the required fields for this courier. Besides tracking_number, also required: [field_name]                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| BAD_COURIER                       | 4012            | 400             | The error message will be one of the following:<br/>1. Unable to import shipment as the carrier is not on your approved list for carrier auto-detection. Add the carrier here: https://admin.aftership.com/settings/couriers<br/>2. Unable to import shipment as we don’t recognize the carrier from this tracking number.<br/>3. Unable to import shipment as the tracking number has an invalid format.<br/>4. Unable to import shipment as this carrier is no longer supported.<br/>5. Unable to import shipment as the tracking number does not belong to a carrier in that group. |
| INACTIVE_RETRACK_NOT_ALLOWED      | 4013            | 400             | Retrack is not allowed. You can only retrack an inactive tracking.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| NOTIFICATION_REUQIRED             | 4014            | 400             | notification object is required.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| ID_INVALID                        | 4015            | 400             | The value of id is invalid.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| RETRACK_ONCE_ALLOWED              | 4016            | 400             | Retrack is not allowed. You can only retrack each shipment once.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| TRACKING_NUMBER_FORMAT_INVALID    | 4017            | 400             | The format of tracking_number is invalid.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| API_KEY_INVALID                   | 401             | 401             | The API key is invalid.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| REQUEST_NOT_ALLOWED               | 403             | 403             | The request is understood, but it has been refused or access is not allowed.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| NOT_FOUND                         | 404             | 404             | The URI requested is invalid or the resource requested does not exist.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| TOO_MANY_REQUEST                  | 429             | 429             | You have exceeded the API call rate limit. The default limit is 10 requests per second.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| INTERNAL_ERROR                    | 500 502 503 504 | 500 502 503 504 | Something went wrong on AfterShip's end.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |

## Endpoints

The AfterShip instance has the following properties which are exactly the same as the API endpoints:

- courier - Get a list of our supported couriers.
- tracking - Create trackings, update trackings, and get tracking results.
- last_checkpoint - Get tracking information of the last checkpoint of a tracking.
- notification - Get, add or remove contacts (sms or email) to be notified when the status of a tracking has changed.
- estimated-delivery-date - Get estimated delivery date for your order.

### /trackings

**POST** /trackings

```csharp
AfterShipClient client = new AfterShipClient(
                            apiKey: "YOUR_API_KEY",
                            apiSecret: "YOUR_AES_SECRET",
                            authenticationType: AfterShipConfiguration.AUTHENTICATION_TYPE_AES);

CreateTrackingOptions options = new CreateTrackingOptions();
options.CreateTrackingRequest = new CreateTrackingRequest();
TrackingCreateTrackingRequest newTracking = new TrackingCreateTrackingRequest();
newTracking.TrackingNumber = "<tracking_number>";
newTracking.Slug = "<slug>";
options.CreateTrackingRequest.Tracking = newTracking;
Tracking.Tracking tracking = client.Tracking.CreateTracking(options);
if (tracking != null)
{
    Console.WriteLine(tracking.Id);
}
```

**DELETE** /trackings/:id

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
DeleteTrackingByIdOptions deleteOptions = new DeleteTrackingByIdOptions();
PartialDeleteTracking resp = client.Tracking.DeleteTrackingById("<tracking_id>");

if (resp != null)
{
    Console.WriteLine(resp.Id);
}
```

**GET** /trackings

```csharp
  AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
  GetTrackingsOptions options = new GetTrackingsOptions();
  options.Keyword = "test";
  GetTrackingsResponseTrackingListData trackingsData = client.Tracking.GetTrackings(options);
  if (trackingsData != null && trackingsData.Trackings != null)
  {
      for (int i = 0; i < trackingsData.Trackings.Length; i++)
      {
          Console.WriteLine(trackingsData.Trackings[i].TrackingNumber);
      }
  }
```

**GET** /trackings/:id

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
Tracking.Tracking t = client.Tracking.GetTrackingById("<tracking_id>");
if (t != null)
{
   Console.WriteLine(tracking.TrackingNumber);
}
```

**PUT** /trackings/:id

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
UpdateTrackingByIdOptions updateOptions = new UpdateTrackingByIdOptions();
updateOptions.UpdateTrackingByIdRequest = new UpdateTrackingByIdRequest();
TrackingUpdateTrackingByIdRequest trackingToUpdate = new TrackingUpdateTrackingByIdRequest();
trackingToUpdate.Title = "this is a test new title";
trackingToUpdate.Note = "some note";
updateOptions.UpdateTrackingByIdRequest.Tracking = trackingToUpdate;
Tracking.Tracking tracking = client.Tracking.UpdateTrackingById("<tracking_id>", updateOptions);

if (tracking != null)
{
    Console.WriteLine(tracking.Title);
    Console.WriteLine(tracking.Note);
}
```

**POST** /trackings/:id/retrack

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
RetrackTrackingByIdOptions options = new RetrackTrackingByIdOptions();
PartialUpdateTracking tracking = client.Tracking.RetrackTrackingById("<tracking_id>");
Console.WriteLine(tracking.TrackingNumber);
```

**POST** /trackings/:id/mark-as-completed

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
MarkTrackingCompletedByIdOptions options = new MarkTrackingCompletedByIdOptions();
PartialUpdateTracking tracking = client.Tracking.RetrackTrackingById("<tracking_id>");
Console.WriteLine(tracking.TrackingNumber);
```

### /couriers

**GET** /couriers

```csharp
GetUserCouriersResponse response = CourierResource.getUserCouriers().fetch();
System.out.println(response.getTotal());
```

**GET** /couriers/all

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
GetAllCouriersOptions options = new GetAllCouriersOptions();
GetAllCouriersResponse resp = client.Courier.GetAllCouriers(options);
Console.WriteLine(resp.Total);
```

**POST** /couriers/detect

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
DetectCourierOptions options = new DetectCourierOptions();
TrackingDetectCourierRequest request = new TrackingDetectCourierRequest();
request.TrackingNumber = "<tracking_number>";
DetectCourierResponse resp = client.Courier.DetectCourier(options);
Console.WriteLine(resp.Total);
```

### /last_checkpoint

**GET** /last_checkpoint/:id

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
GetCheckpointByTrackingIdResponse resp = client.LastCheckpoint.GetCheckpointByTrackingId("<tracking_id>");
Console.WriteLine(resp.Slug);
```

### /notifications

**GET** /notifications/:id

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");
Notification notificaiton =  client.Notification.GetNotificationByTrackingId("<tracking_id>");
Console.WriteLine(notificaiton.Emails);
```

**POST** /notifications/:id/add

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");

AddNotificationByTrackingIdOptions options = new AddNotificationByTrackingIdOptions();
AddNotificationByTrackingIdRequest request = new AddNotificationByTrackingIdRequest();
NotificationRequestV1 notification = new NotificationRequestV1();
request.Notification = notification;
options.AddNotificationByTrackingIdRequest = request;

Notification notificaiton = client.Notification.AddNotificationByTrackingId("<tracking_id>", options);
Console.WriteLine(notificaiton.Emails);
```

**POST** /notifications/:id/remove

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");

DeleteNotificationByTrackingIdOptions options = new DeleteNotificationByTrackingIdOptions();
DeleteNotificationByTrackingIdRequest request = new DeleteNotificationByTrackingIdRequest();
NotificationRequestV1 notification = new NotificationRequestV1();
request.Notification = notification;
options.DeleteNotificationByTrackingIdRequest = request;

Notification notificaiton = client.Notification.DeleteNotificationByTrackingId("<tracking_id>", options);
Console.WriteLine(notificaiton.Emails);
```

### /estimated-delivery-date

**POST** /estimated-delivery-date/predict-batch

```csharp
AfterShipClient client = new AfterShipClient(apiKey: "YOUR_API_KEY");

PredictBatchOptions options = new PredictBatchOptions();
PredictBatchRequest request = new PredictBatchRequest();

EstimatedDeliveryDateRequest estimatedDeliveryDateRequest = new EstimatedDeliveryDateRequest();
estimatedDeliveryDateRequest.Slug = "<slug>";
request.EstimatedDeliveryDates = new EstimatedDeliveryDateRequest[] { estimatedDeliveryDateRequest };

options.PredictBatchRequest = request;

PredictBatchResponse resp = client.EstimatedDeliveryDate.PredictBatch(options);
Console.WriteLine(resp.EstimatedDeliveryDates[0].Slug);
```

## Help

If you get stuck, we're here to help:

- [Issue Tracker](https://github.com/AfterShip/tracking-sdk-net/issues) for questions, feature requests, bug reports and
  general discussion related to this package. Try searching before you create a new issue.
- Contact AfterShip official support via support@aftership.com

## License

Copyright (c) 2024 AfterShip

Licensed under the MIT license.