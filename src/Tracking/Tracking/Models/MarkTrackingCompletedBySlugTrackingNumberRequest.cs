/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */

using Newtonsoft.Json;

namespace Tracking;

/// <summary>
/// </summary>
public class MarkTrackingCompletedBySlugTrackingNumberRequest
{
    /// <summary>
    ///     Reason One of `DELIVERED`, `LOST` or `RETURNED_TO_SENDER`.- Mark the tracking as completed with `DELIVERED`. The
    ///     tag of the tracking will be updated to `Delivered` and the subtag will be updated to `Delivered_001`.- Mark the
    ///     tracking as completed with `LOST`. The tag of the tracking will be updated to `Exception` and the subtag will be
    ///     updated to `Exception_013`.- Mark the tracking as completed with `RETURNED_TO_SENDER`. The tag of the tracking will
    ///     be updated to `Exception` and the subtag will be updated to `Exception_011`.
    /// </summary>
    [JsonProperty("reason")]
    public string Reason { get; set; }
}