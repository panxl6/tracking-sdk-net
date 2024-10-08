/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AfterShipTracking
{
    /// <summary>
    ///
    /// </summary>
    public class GetCheckpointByTrackingIdResponse
    {
        /// <summary>
        ///  Id Tracking id
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        ///  TrackingNumber Tracking number.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string? TrackingNumber { get; set; }

        /// <summary>
        ///  Slug Unique code of courier.
        /// </summary>
        [JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        ///  Tag Current status of tracking. (
        /// </summary>
        [JsonProperty("tag")]
        public TagV1? Tag { get; set; }

        /// <summary>
        ///  Subtag Current subtag of tracking. (
        /// </summary>
        [JsonProperty("subtag")]
        public string? Subtag { get; set; }

        /// <summary>
        ///  SubtagMessage Normalized tracking message. (
        /// </summary>
        [JsonProperty("subtag_message")]
        public string? SubtagMessage { get; set; }

        /// <summary>
        ///  Checkpoint Object describes checkpoint information.
        /// </summary>
        [JsonProperty("checkpoint")]
        public Checkpoint? Checkpoint { get; set; }

        public GetCheckpointByTrackingIdResponse() { }
    }
}
