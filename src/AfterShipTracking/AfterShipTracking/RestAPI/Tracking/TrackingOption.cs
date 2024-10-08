/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AfterShipTracking
{
    /// <summary>
    /// Description
    /// </summary>
    public class CreateTrackingOptions : BaseOptions
    {
        public CreateTrackingOptions() { }

        public CreateTrackingRequest CreateTrackingRequest { get; set; }

        public override string GetBody()
        {
            string body = null;

            if (CreateTrackingRequest != null)
            {
                body = BaseResourceService.ToJson(CreateTrackingRequest);
            }
            return body;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class RetrackTrackingByIdOptions : BaseOptions
    {
        public RetrackTrackingByIdOptions() { }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class MarkTrackingCompletedBySlugTrackingNumberOptions : BaseOptions
    {
        public MarkTrackingCompletedBySlugTrackingNumberOptions() { }

        public string TrackingAccountNumber { get; set; }
        public string TrackingOriginCountry { get; set; }
        public string TrackingDestinationCountry { get; set; }
        public string TrackingKey { get; set; }
        public string TrackingPostalCode { get; set; }
        public string TrackingShipDate { get; set; }
        public string TrackingState { get; set; }

        public override List<KeyValuePair<string, string>> GetQueryParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            p.Add(
                new KeyValuePair<string, string>("tracking_account_number", TrackingAccountNumber)
            );
            p.Add(
                new KeyValuePair<string, string>("tracking_origin_country", TrackingOriginCountry)
            );
            p.Add(
                new KeyValuePair<string, string>(
                    "tracking_destination_country",
                    TrackingDestinationCountry
                )
            );
            p.Add(new KeyValuePair<string, string>("tracking_key", TrackingKey));
            p.Add(new KeyValuePair<string, string>("tracking_postal_code", TrackingPostalCode));
            p.Add(new KeyValuePair<string, string>("tracking_ship_date", TrackingShipDate));
            p.Add(new KeyValuePair<string, string>("tracking_state", TrackingState));
            return p;
        }

        public MarkTrackingCompletedBySlugTrackingNumberRequest MarkTrackingCompletedBySlugTrackingNumberRequest { get; set; }

        public override string GetBody()
        {
            string body = null;

            if (MarkTrackingCompletedBySlugTrackingNumberRequest != null)
            {
                body = BaseResourceService.ToJson(MarkTrackingCompletedBySlugTrackingNumberRequest);
            }
            return body;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class GetTrackingsOptions : BaseOptions
    {
        public GetTrackingsOptions() { }

        public string Page { get; set; }
        public string Limit { get; set; }
        public string Keyword { get; set; }
        public string TrackingNumbers { get; set; }
        public string Slug { get; set; }
        public string TransitTime { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Tag { get; set; }
        public string CreatedAtMin { get; set; }
        public string CreatedAtMax { get; set; }
        public string UpdatedAtMin { get; set; }
        public string UpdatedAtMax { get; set; }
        public string Fields { get; set; }
        public string ReturnToSender { get; set; }
        public string CourierDestinationCountryIso3 { get; set; }
        public string ShipmentTags { get; set; }
        public string OrderId { get; set; }

        public override List<KeyValuePair<string, string>> GetQueryParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            p.Add(new KeyValuePair<string, string>("page", Page));
            p.Add(new KeyValuePair<string, string>("limit", Limit));
            p.Add(new KeyValuePair<string, string>("keyword", Keyword));
            p.Add(new KeyValuePair<string, string>("tracking_numbers", TrackingNumbers));
            p.Add(new KeyValuePair<string, string>("slug", Slug));
            p.Add(new KeyValuePair<string, string>("transit_time", TransitTime));
            p.Add(new KeyValuePair<string, string>("origin", Origin));
            p.Add(new KeyValuePair<string, string>("destination", Destination));
            p.Add(new KeyValuePair<string, string>("tag", Tag));
            p.Add(new KeyValuePair<string, string>("created_at_min", CreatedAtMin));
            p.Add(new KeyValuePair<string, string>("created_at_max", CreatedAtMax));
            p.Add(new KeyValuePair<string, string>("updated_at_min", UpdatedAtMin));
            p.Add(new KeyValuePair<string, string>("updated_at_max", UpdatedAtMax));
            p.Add(new KeyValuePair<string, string>("fields", Fields));
            p.Add(new KeyValuePair<string, string>("return_to_sender", ReturnToSender));
            p.Add(
                new KeyValuePair<string, string>(
                    "courier_destination_country_iso3",
                    CourierDestinationCountryIso3
                )
            );
            p.Add(new KeyValuePair<string, string>("shipment_tags", ShipmentTags));
            p.Add(new KeyValuePair<string, string>("order_id", OrderId));
            return p;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class GetTrackingByIdOptions : BaseOptions
    {
        public GetTrackingByIdOptions() { }

        public string Fields { get; set; }
        public string Lang { get; set; }

        public override List<KeyValuePair<string, string>> GetQueryParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            p.Add(new KeyValuePair<string, string>("fields", Fields));
            p.Add(new KeyValuePair<string, string>("lang", Lang));
            return p;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class UpdateTrackingByIdOptions : BaseOptions
    {
        public UpdateTrackingByIdOptions() { }

        public UpdateTrackingByIdRequest UpdateTrackingByIdRequest { get; set; }

        public override string GetBody()
        {
            string body = null;

            if (UpdateTrackingByIdRequest != null)
            {
                body = BaseResourceService.ToJson(UpdateTrackingByIdRequest);
            }
            return body;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class DeleteTrackingByIdOptions : BaseOptions
    {
        public DeleteTrackingByIdOptions() { }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class GetTrackingBySlugTrackingNumberOptions : BaseOptions
    {
        public GetTrackingBySlugTrackingNumberOptions() { }

        public string Fields { get; set; }
        public string Lang { get; set; }
        public string TrackingAccountNumber { get; set; }
        public string TrackingOriginCountry { get; set; }
        public string TrackingDestinationCountry { get; set; }
        public string TrackingKey { get; set; }
        public string TrackingPostalCode { get; set; }
        public string TrackingShipDate { get; set; }
        public string TrackingState { get; set; }

        public override List<KeyValuePair<string, string>> GetQueryParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            p.Add(new KeyValuePair<string, string>("fields", Fields));
            p.Add(new KeyValuePair<string, string>("lang", Lang));
            p.Add(
                new KeyValuePair<string, string>("tracking_account_number", TrackingAccountNumber)
            );
            p.Add(
                new KeyValuePair<string, string>("tracking_origin_country", TrackingOriginCountry)
            );
            p.Add(
                new KeyValuePair<string, string>(
                    "tracking_destination_country",
                    TrackingDestinationCountry
                )
            );
            p.Add(new KeyValuePair<string, string>("tracking_key", TrackingKey));
            p.Add(new KeyValuePair<string, string>("tracking_postal_code", TrackingPostalCode));
            p.Add(new KeyValuePair<string, string>("tracking_ship_date", TrackingShipDate));
            p.Add(new KeyValuePair<string, string>("tracking_state", TrackingState));
            return p;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class UpdateTrackingBySlugTrackingNumberOptions : BaseOptions
    {
        public UpdateTrackingBySlugTrackingNumberOptions() { }

        public string TrackingAccountNumber { get; set; }
        public string TrackingOriginCountry { get; set; }
        public string TrackingDestinationCountry { get; set; }
        public string TrackingKey { get; set; }
        public string TrackingPostalCode { get; set; }
        public string TrackingShipDate { get; set; }
        public string TrackingState { get; set; }

        public override List<KeyValuePair<string, string>> GetQueryParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            p.Add(
                new KeyValuePair<string, string>("tracking_account_number", TrackingAccountNumber)
            );
            p.Add(
                new KeyValuePair<string, string>("tracking_origin_country", TrackingOriginCountry)
            );
            p.Add(
                new KeyValuePair<string, string>(
                    "tracking_destination_country",
                    TrackingDestinationCountry
                )
            );
            p.Add(new KeyValuePair<string, string>("tracking_key", TrackingKey));
            p.Add(new KeyValuePair<string, string>("tracking_postal_code", TrackingPostalCode));
            p.Add(new KeyValuePair<string, string>("tracking_ship_date", TrackingShipDate));
            p.Add(new KeyValuePair<string, string>("tracking_state", TrackingState));
            return p;
        }

        public UpdateTrackingBySlugTrackingNumberRequest UpdateTrackingBySlugTrackingNumberRequest { get; set; }

        public override string GetBody()
        {
            string body = null;

            if (UpdateTrackingBySlugTrackingNumberRequest != null)
            {
                body = BaseResourceService.ToJson(UpdateTrackingBySlugTrackingNumberRequest);
            }
            return body;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class MarkTrackingCompletedByIdOptions : BaseOptions
    {
        public MarkTrackingCompletedByIdOptions() { }

        public MarkTrackingCompletedByIdRequest MarkTrackingCompletedByIdRequest { get; set; }

        public override string GetBody()
        {
            string body = null;

            if (MarkTrackingCompletedByIdRequest != null)
            {
                body = BaseResourceService.ToJson(MarkTrackingCompletedByIdRequest);
            }
            return body;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class DeleteTrackingBySlugTrackingNumberOptions : BaseOptions
    {
        public DeleteTrackingBySlugTrackingNumberOptions() { }

        public string TrackingAccountNumber { get; set; }
        public string TrackingOriginCountry { get; set; }
        public string TrackingDestinationCountry { get; set; }
        public string TrackingKey { get; set; }
        public string TrackingPostalCode { get; set; }
        public string TrackingShipDate { get; set; }
        public string TrackingState { get; set; }

        public override List<KeyValuePair<string, string>> GetQueryParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            p.Add(
                new KeyValuePair<string, string>("tracking_account_number", TrackingAccountNumber)
            );
            p.Add(
                new KeyValuePair<string, string>("tracking_origin_country", TrackingOriginCountry)
            );
            p.Add(
                new KeyValuePair<string, string>(
                    "tracking_destination_country",
                    TrackingDestinationCountry
                )
            );
            p.Add(new KeyValuePair<string, string>("tracking_key", TrackingKey));
            p.Add(new KeyValuePair<string, string>("tracking_postal_code", TrackingPostalCode));
            p.Add(new KeyValuePair<string, string>("tracking_ship_date", TrackingShipDate));
            p.Add(new KeyValuePair<string, string>("tracking_state", TrackingState));
            return p;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    public class RetrackTrackingBySlugTrackingNumberOptions : BaseOptions
    {
        public RetrackTrackingBySlugTrackingNumberOptions() { }

        public string TrackingAccountNumber { get; set; }
        public string TrackingOriginCountry { get; set; }
        public string TrackingDestinationCountry { get; set; }
        public string TrackingKey { get; set; }
        public string TrackingPostalCode { get; set; }
        public string TrackingShipDate { get; set; }
        public string TrackingState { get; set; }

        public override List<KeyValuePair<string, string>> GetQueryParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            p.Add(
                new KeyValuePair<string, string>("tracking_account_number", TrackingAccountNumber)
            );
            p.Add(
                new KeyValuePair<string, string>("tracking_origin_country", TrackingOriginCountry)
            );
            p.Add(
                new KeyValuePair<string, string>(
                    "tracking_destination_country",
                    TrackingDestinationCountry
                )
            );
            p.Add(new KeyValuePair<string, string>("tracking_key", TrackingKey));
            p.Add(new KeyValuePair<string, string>("tracking_postal_code", TrackingPostalCode));
            p.Add(new KeyValuePair<string, string>("tracking_ship_date", TrackingShipDate));
            p.Add(new KeyValuePair<string, string>("tracking_state", TrackingState));
            return p;
        }
    }
}
