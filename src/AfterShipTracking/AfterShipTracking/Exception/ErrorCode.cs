/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */
using System.Collections.Generic;

namespace AfterShipTracking
{
    public class ErrorCode
    {
        public const string REQUEST_ERROR = "REQUEST_ERROR";

        // Common AfterShipError
        public const string INVALID_API_KEY = "INVALID_API_KEY";
        public const string INVALID_OPTION = "INVALID_OPTION";
        public const string RATE_LIMIT_EXCEEDED = "RATE_LIMIT_EXCEEDED";
        public const string TIMED_OUT = "TIMED_OUT";

        // API error
        public const string INVALID_REQUEST = "INVALID_REQUEST";
        public const string INVALID_JSON = "INVALID_JSON";
        public const string TRACKING_ALREADY_EXIST = "TRACKING_ALREADY_EXIST";
        public const string TRACKING_DOES_NOT_EXIST = "TRACKING_DOES_NOT_EXIST";
        public const string TRACKING_NUMBER_INVALID = "TRACKING_NUMBER_INVALID";
        public const string TRACKING_REQUIRED = "TRACKING_REQUIRED";
        public const string TRACKING_NUMBER_REQUIRED = "TRACKING_NUMBER_REQUIRED";
        public const string VALUE_INVALID = "VALUE_INVALID";
        public const string VALUE_REQUIRED = "VALUE_REQUIRED";
        public const string SLUG_INVALID = "SLUG_INVALID";
        public const string MISSING_OR_INVALID_REQUIRED_FIELD = "MISSING_OR_INVALID_REQUIRED_FIELD";
        public const string BAD_COURIER = "BAD_COURIER";
        public const string INACTIVE_RETRACK_NOT_ALLOWED = "INACTIVE_RETRACK_NOT_ALLOWED";
        public const string NOTIFICATION_REUQIRED = "NOTIFICATION_REUQIRED";
        public const string ID_INVALID = "ID_INVALID";
        public const string RETRACK_ONCE_ALLOWED = "RETRACK_ONCE_ALLOWED";
        public const string TRACKING_NUMBER_FORMAT_INVALID = "TRACKING_NUMBER_FORMAT_INVALID";
        public const string API_KEY_INVALID = "API_KEY_INVALID";
        public const string REQUEST_NOT_ALLOWED = "REQUEST_NOT_ALLOWED";
        public const string NOT_FOUND = "NOT_FOUND";
        public const string TOO_MANY_REQUEST = "TOO_MANY_REQUEST";
        public const string INTERNAL_ERROR = "INTERNAL_ERROR";

        private static Dictionary<int, string> errorMap = new Dictionary<int, string>
        {
            { 400, INVALID_REQUEST },
            { 4001, INVALID_JSON },
            { 4003, TRACKING_ALREADY_EXIST },
            { 4004, TRACKING_DOES_NOT_EXIST },
            { 4005, TRACKING_NUMBER_INVALID },
            { 4006, TRACKING_REQUIRED },
            { 4007, TRACKING_NUMBER_REQUIRED },
            { 4008, VALUE_INVALID },
            { 4009, VALUE_REQUIRED },
            { 4010, SLUG_INVALID },
            { 4011, MISSING_OR_INVALID_REQUIRED_FIELD },
            { 4012, BAD_COURIER },
            { 4013, INACTIVE_RETRACK_NOT_ALLOWED },
            { 4014, NOTIFICATION_REUQIRED },
            { 4015, ID_INVALID },
            { 4016, RETRACK_ONCE_ALLOWED },
            { 4017, TRACKING_NUMBER_FORMAT_INVALID },
            { 401, API_KEY_INVALID },
            { 403, REQUEST_NOT_ALLOWED },
            { 404, NOT_FOUND },
            { 429, TOO_MANY_REQUEST },
            { 500, INTERNAL_ERROR },
            { 502, INTERNAL_ERROR },
            { 503, INTERNAL_ERROR },
            { 504, INTERNAL_ERROR },
        };

        private static Dictionary<string, string> errorMessageMap = new Dictionary<string, string>
        {
            { INVALID_API_KEY, "Invalid API key" },
            { INVALID_OPTION, "Invalid option" },
            {
                RATE_LIMIT_EXCEEDED,
                "You have exceeded the API call rate limit. The default limit is 10 requests per second."
            },
            { TIMED_OUT, "Request timed out" },
            { INVALID_REQUEST, "The request was invalid or cannot be otherwise served." },
            { INVALID_JSON, "Invalid JSON data." },
            { TRACKING_ALREADY_EXIST, "Tracking already exists." },
            { TRACKING_DOES_NOT_EXIST, "Tracking does not exist." },
            { TRACKING_NUMBER_INVALID, "The value of tracking_number is invalid." },
            { TRACKING_REQUIRED, "tracking object is required." },
            { TRACKING_NUMBER_REQUIRED, "tracking_number is required." },
            { VALUE_INVALID, "The value of [field_name] is invalid." },
            { VALUE_REQUIRED, "[field_name] is required." },
            { SLUG_INVALID, "The value of slug is invalid." },
            {
                MISSING_OR_INVALID_REQUIRED_FIELD,
                "Missing or invalid value of the required fields for this courier. Besides tracking_number, also required: [field_name]"
            },
            {
                BAD_COURIER,
                "The error message will be one of the following:1. Unable to import shipment as the carrier is not on your approved list for carrier auto-detection. Add the carrier here: https://admin.aftership.com/settings/couriers2. Unable to import shipment as we don’t recognize the carrier from this tracking number.3. Unable to import shipment as the tracking number has an invalid format.4. Unable to import shipment as this carrier is no longer supported.5. Unable to import shipment as the tracking number does not belong to a carrier in that group."
            },
            {
                INACTIVE_RETRACK_NOT_ALLOWED,
                "Retrack is not allowed. You can only retrack an inactive tracking."
            },
            { NOTIFICATION_REUQIRED, "notification object is required." },
            { ID_INVALID, "The value of id is invalid." },
            {
                RETRACK_ONCE_ALLOWED,
                "Retrack is not allowed. You can only retrack each shipment once."
            },
            { TRACKING_NUMBER_FORMAT_INVALID, "The format of tracking_number is invalid." },
            { API_KEY_INVALID, "The API Key is invalid." },
            {
                REQUEST_NOT_ALLOWED,
                "The request is understood, but it has been refused or access is not allowed."
            },
            { NOT_FOUND, "The URI requested is invalid or the resource requested does not exist." },
            {
                TOO_MANY_REQUEST,
                "You have exceeded the API call rate limit. The default limit is 10 requests per second."
            },
            { INTERNAL_ERROR, "Something went wrong on AfterShip's end." },
        };

        public static AfterShipError GenAPIError(
            int statusCode,
            int metaCode,
            string responseBody = null,
            string message = null
        )
        {
            string errorCode = LocateErrorCode(metaCode);
            return GenError(errorCode, statusCode, metaCode, responseBody, message);
        }

        public static AfterShipError GenSDKError(string errorCode, string message = null)
        {
            return GenError(errorCode, null, null, null, message);
        }

        public static AfterShipError GenError(
            string errorCode,
            int? statusCode,
            int? metaCode,
            string responseBody = null,
            string message = null
        )
        {
            if (string.IsNullOrEmpty(message))
            {
                message = errorMessageMap.GetValueOrDefault(errorCode) ?? "Unknown error";
            }
            return new AfterShipError(message, errorCode, statusCode, metaCode, responseBody);
        }

        private static string LocateErrorCode(int metaCode)
        {
            if (errorMap.ContainsKey(metaCode))
            {
                return errorMap[metaCode];
            }
            return INVALID_REQUEST;
        }
    }
}
