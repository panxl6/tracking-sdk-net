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
    public class RetrackTrackingByIdResponse
    {
        /// <summary>
        ///  Tracking Partial tracking
        /// </summary>
        [JsonProperty("tracking")]
        public PartialUpdateTracking? Tracking { get; set; }

        public RetrackTrackingByIdResponse() { }
    }
}
