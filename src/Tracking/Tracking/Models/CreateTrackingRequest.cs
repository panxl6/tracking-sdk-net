/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tracking;

/// <summary>
/// </summary>
public class CreateTrackingRequest
{
    /// <summary>
    ///     Tracking
    /// </summary>
    [JsonProperty("tracking")]
    public TrackingCreateTrackingRequest Tracking { get; set; }
}

/// <summary>
/// </summary>
public class TrackingCreateTrackingRequest
{
    /// <summary>
    ///     TrackingNumber Tracking number of a shipment.Duplicated tracking numbers, tracking numbers with invalid tracking
    ///     number format will not be accepted.We only accept tracking numbers with length from 4 to 100We currently support
    ///     the following characters in a tracking number:- A - Z- 0 - 9- `-` (Hyphen)- . (Period)- _ (Underscore)- / (Slash)
    /// </summary>
    [JsonProperty("tracking_number")]
    public string TrackingNumber { get; set; }

    /// <summary>
    ///     Slug Unique courier code. Get courier codes .
    /// </summary>
    [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
    public string? Slug { get; set; }

    /// <summary>
    ///     Title By default this field shows the `tracking_number`, but you can customize it as you wish with any info (e.g.
    ///     the order number).
    /// </summary>
    [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; }

    /// <summary>
    ///     OrderId A globally-unique identifier for the order.
    /// </summary>
    [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderId { get; set; }

    /// <summary>
    ///     OrderIdPath The URL for the order in your system or store.
    /// </summary>
    [JsonProperty("order_id_path", NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderIdPath { get; set; }

    /// <summary>
    ///     CustomFields Custom fields that accept an object with string field. In order to protect the privacy of your
    ///     customers, do not include any
    /// </summary>
    [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, string>? CustomFields { get; set; }

    /// <summary>
    ///     Language The recipient’s language. If you set up AfterShip notifications in different languages, we use this to
    ///     send the recipient tracking updates in their preferred language. Use an  to specify the language.
    /// </summary>
    [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
    public string? Language { get; set; }

    /// <summary>
    ///     OrderPromisedDeliveryDate The promised delivery date of the order. It uses the format YYYY-MM-DD. This has no
    ///     timezone and uses whatever date you provide. Since other EDDs use the shipment recipient’s timezone, we suggest
    ///     following the same logic here.
    /// </summary>
    [JsonProperty("order_promised_delivery_date", NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderPromisedDeliveryDate { get; set; }

    /// <summary>
    ///     DeliveryType Shipment delivery type- pickup_at_store- pickup_at_courier- door_to_door
    /// </summary>
    [JsonProperty("delivery_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryType { get; set; }

    /// <summary>
    ///     PickupLocation Shipment pickup location for receiver
    /// </summary>
    [JsonProperty("pickup_location", NullValueHandling = NullValueHandling.Ignore)]
    public string? PickupLocation { get; set; }

    /// <summary>
    ///     PickupNote Shipment pickup note for receiver
    /// </summary>
    [JsonProperty("pickup_note", NullValueHandling = NullValueHandling.Ignore)]
    public string? PickupNote { get; set; }

    /// <summary>
    ///     TrackingAccountNumber Additional field required by some carriers to retrieve the tracking info. The shipper’s
    ///     carrier account number. Refer to our article on  for more details.
    /// </summary>
    [JsonProperty("tracking_account_number", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingAccountNumber { get; set; }

    /// <summary>
    ///     TrackingKey Additional field required by some carriers to retrieve the tracking info. A type of tracking credential
    ///     required by some carriers. Refer to our article on  for more details.
    /// </summary>
    [JsonProperty("tracking_key", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingKey { get; set; }

    /// <summary>
    ///     TrackingShipDate Additional field required by some carriers to retrieve the tracking info. The date the shipment
    ///     was sent, using the format YYYYMMDD. Refer to our article on  for more details.
    /// </summary>
    [JsonProperty("tracking_ship_date", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingShipDate { get; set; }

    /// <summary>
    ///     Emails Email address(es) to receive email notifications. Accept either array or comma separated as input. Supports
    ///     up to 3 email addresses.
    /// </summary>
    [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
    public string?[] Emails { get; set; }

    /// <summary>
    ///     Smses The phone number(s) to receive sms notifications.  Enter `+` andarea `code before` phone number. Accept
    ///     either array or comma separated as input. Supports up to 3 phone numbers.
    /// </summary>
    [JsonProperty("smses", NullValueHandling = NullValueHandling.Ignore)]
    public string?[] Smses { get; set; }

    /// <summary>
    ///     CustomerName Customer name of the tracking.
    /// </summary>
    [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerName { get; set; }

    /// <summary>
    ///     OriginCountryIso3 The  for more details.
    /// </summary>
    [JsonProperty("origin_country_iso3", NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginCountryIso3 { get; set; }

    /// <summary>
    ///     OriginState The state of the sender’s address. This can help AfterShip with various functions like tracking,
    ///     carrier auto-detection and auto-correction, calculating an EDD, etc.
    /// </summary>
    [JsonProperty("origin_state", NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginState { get; set; }

    /// <summary>
    ///     OriginCity The city of the sender’s address. This can help AfterShip with various functions like tracking, carrier
    ///     auto-detection and auto-correction, calculating an EDD, etc.
    /// </summary>
    [JsonProperty("origin_city", NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginCity { get; set; }

    /// <summary>
    ///     OriginPostalCode The postal of the sender’s address. This can help AfterShip with various functions like tracking,
    ///     carrier auto-detection and auto-correction, calculating an EDD, etc.
    /// </summary>
    [JsonProperty("origin_postal_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginPostalCode { get; set; }

    /// <summary>
    ///     OriginRawLocation The sender address that the shipment is shipping from. This can help AfterShip with various
    ///     functions like tracking, carrier auto-detection and auto-correction, calculating an EDD, etc.
    /// </summary>
    [JsonProperty("origin_raw_location", NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginRawLocation { get; set; }

    /// <summary>
    ///     DestinationCountryIso3 The  for more details.
    /// </summary>
    [JsonProperty("destination_country_iso3", NullValueHandling = NullValueHandling.Ignore)]
    public string? DestinationCountryIso3 { get; set; }

    /// <summary>
    ///     DestinationState The state of the recipient’s address. This can help AfterShip with various functions like
    ///     tracking, carrier auto-detection and auto-correction, calculating an EDD, etc. Also the additional field required
    ///     by some carriers to retrieve the tracking info. The state/province of the recipient’s address. Refer to our article
    ///     on  for more details.
    /// </summary>
    [JsonProperty("destination_state", NullValueHandling = NullValueHandling.Ignore)]
    public string? DestinationState { get; set; }

    /// <summary>
    ///     DestinationCity The city of the recipient’s address. This can help AfterShip with various functions like tracking,
    ///     carrier auto-detection and auto-correction, calculating an EDD, etc.
    /// </summary>
    [JsonProperty("destination_city", NullValueHandling = NullValueHandling.Ignore)]
    public string? DestinationCity { get; set; }

    /// <summary>
    ///     DestinationPostalCode The postal of the recipient’s address. This can help AfterShip with various functions like
    ///     tracking, carrier auto-detection and auto-correction, calculating an EDD, etc. Also the additional field required
    ///     by some carriers to retrieve the tracking info. The postal code of the recipient’s address. Refer to our article on
    ///     for more details.
    /// </summary>
    [JsonProperty("destination_postal_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? DestinationPostalCode { get; set; }

    /// <summary>
    ///     DestinationRawLocation The shipping address that the shipment is shipping to. This can help AfterShip with various
    ///     functions like tracking, carrier auto-detection and auto-correction, calculating an EDD, etc.
    /// </summary>
    [JsonProperty("destination_raw_location", NullValueHandling = NullValueHandling.Ignore)]
    public string? DestinationRawLocation { get; set; }

    /// <summary>
    ///     Note Text field for the note
    /// </summary>
    [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; }

    /// <summary>
    ///     SlugGroup Slug group is a group of slugs which belong to same courier. For example, when you inpit "fedex-group" as
    ///     slug_group, AfterShip will detect the tracking with "fedex-uk", "fedex-fims", and other slugs which belong to
    ///     "fedex". It cannot be used with slug at the same time. (
    /// </summary>
    [JsonProperty("slug_group", NullValueHandling = NullValueHandling.Ignore)]
    public SlugGroupV1? SlugGroup { get; set; }

    /// <summary>
    ///     OrderDate Order date in YYYY-MM-DDTHH:mm:ssZ format. e.g. 2021-07-26T11:23:51-05:00
    /// </summary>
    [JsonProperty("order_date", NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderDate { get; set; }

    /// <summary>
    ///     OrderNumber A unique, human-readable identifier for the order.
    /// </summary>
    [JsonProperty("order_number", NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderNumber { get; set; }

    /// <summary>
    ///     ShipmentType The carrier service type for the shipment. If you provide info for this field, AfterShip will not
    ///     update it with info from the carrier.
    /// </summary>
    [JsonProperty("shipment_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? ShipmentType { get; set; }

    /// <summary>
    ///     ShipmentTags Used to add tags to your shipments to help categorize and filter them easily.
    /// </summary>
    [JsonProperty("shipment_tags", NullValueHandling = NullValueHandling.Ignore)]
    public string?[] ShipmentTags { get; set; }

    /// <summary>
    ///     CourierConnectionId If you’ve connected multiple accounts for a single carrier on AfterShip, you can now use the
    ///     courier_connection_id field to tell AfterShip which carrier account you’ve used to handle a shipment so we can
    ///     track it. (
    /// </summary>
    [JsonProperty("courier_connection_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? CourierConnectionId { get; set; }

    /// <summary>
    ///     NextCouriers If a shipment has multiple carriers, you can use the next_couriers field to tell AfterShip who the
    ///     second carrier is. This is useful if the first carrier does not send us this information.
    /// </summary>
    [JsonProperty("next_couriers", NullValueHandling = NullValueHandling.Ignore)]
    public NextCouriersTrackingCreateTrackingRequest?[] NextCouriers { get; set; }

    /// <summary>
    ///     TrackingOriginCountry (Legacy) Replaced by `origin_country_iso3`. Additional field required by some carriers to
    ///     retrieve the tracking info. The origin country/region of the shipment. Refer to our article on  for more details.
    /// </summary>
    [JsonProperty("tracking_origin_country", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingOriginCountry { get; set; }

    /// <summary>
    ///     TrackingDestinationCountry (Legacy) Replaced by `destination_country_iso3`. Additional field required by some
    ///     carriers to retrieve the tracking info. The destination country/region of the shipment. Refer to our article on
    ///     for more details.
    /// </summary>
    [JsonProperty("tracking_destination_country", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingDestinationCountry { get; set; }

    /// <summary>
    ///     TrackingPostalCode (Legacy) Replaced by `destination_postal_code`. Additional field required by some carriers to
    ///     retrieve the tracking info. The postal code of the recipient’s address. Refer to our article on  for more details.
    /// </summary>
    [JsonProperty("tracking_postal_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingPostalCode { get; set; }

    /// <summary>
    ///     TrackingState (Legacy) Replaced by `destination_state`. Additional field required by some carriers to retrieve the
    ///     tracking info. The state/province of the recipient’s address. Refer to our article on  for more details.
    /// </summary>
    [JsonProperty("tracking_state", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingState { get; set; }

    /// <summary>
    ///     LocationId The location_id refers to the place where you fulfilled the items.  - If you provide a location_id, the
    ///     system will automatically use it as the tracking's origin address. However, passing both location_id and any origin
    ///     address information simultaneously is not allowed.- Please make sure you add your locations .
    /// </summary>
    [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? LocationId { get; set; }

    /// <summary>
    ///     ShippingMethod The shipping_method string refers to the chosen method for delivering the package. Merchants
    ///     typically offer various shipping methods to consumers during the checkout process, such as, Local Delivery, Free
    ///     Express Worldwide Shipping, etc
    /// </summary>
    [JsonProperty("shipping_method", NullValueHandling = NullValueHandling.Ignore)]
    public string? ShippingMethod { get; set; }
}

/// <summary>
/// </summary>
public class NextCouriersTrackingCreateTrackingRequest
{
    /// <summary>
    ///     Slug
    /// </summary>
    [JsonProperty("slug")]
    public string Slug { get; set; }

    /// <summary>
    ///     TrackingNumber Tracking number of a shipment.Duplicated tracking numbers, tracking numbers with invalid tracking
    ///     number format will not be accepted.We only accept tracking numbers with length from 4 to 100We currently support
    ///     the following characters in a tracking number:- A - Z- 0 - 9- `-` (Hyphen)- . (Period)- _ (Underscore)- / (Slash)
    /// </summary>
    [JsonProperty("tracking_number")]
    public string TrackingNumber { get; set; }
}