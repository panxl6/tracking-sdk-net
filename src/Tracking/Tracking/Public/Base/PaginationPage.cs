/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */

using Newtonsoft.Json;

namespace Tracking;

public class PaginationPage
{
    public PaginationPage(int? page, int? limit, int? total, bool hasNextPage = false)
    {
        Page = page;
        Limit = limit;
        Total = total;
        HasNextPage = page * limit < total;
    }

    /// <summary>
    ///     Page index
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    ///     Page size
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    ///     Total count
    /// </summary>
    [JsonProperty("total")]
    public int? Total { get; set; }


    /// <summary>
    ///     Total count
    /// </summary>
    [JsonProperty("has_next_page")]
    public bool? HasNextPage { get; set; }
}