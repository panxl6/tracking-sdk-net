/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */

using Newtonsoft.Json;

namespace Tracking;

/// <summary>
/// </summary>
public class DeleteNotificationBySlugTrackingNumberRequest
{
    /// <summary>
    ///     Notification Notification request object
    /// </summary>
    [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
    public NotificationRequestV1? Notification { get; set; }
}