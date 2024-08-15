/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Tracking;

/// <summary>
///     Request object
/// </summary>
public class Request
{
    private readonly BaseOptions options;

    public Request(
        HttpMethod method,
        string path,
        List<KeyValuePair<string, string>> queryParams = null,
        List<KeyValuePair<string, string>> headerParams = null,
        string body = null
    )
    {
        Method = method;
        Path = path;
        QueryParams = queryParams ?? new List<KeyValuePair<string, string>>();
        HeaderParams = headerParams ?? new List<KeyValuePair<string, string>>();
        Body = body;
    }

    public Request(
        HttpMethod method,
        string path,
        BaseOptions? options
    )
    {
        Method = method;
        Path = path;
        QueryParams = options?.GetQueryParams() ?? new List<KeyValuePair<string, string>>();
        HeaderParams = options?.GetHeaderParams() ?? new List<KeyValuePair<string, string>>();
        Body = options?.GetBody();
    }

    public Uri Uri { get; }

    public string Path { get; private set; }

    /// <summary>
    ///     HTTP Method
    /// </summary>
    public HttpMethod Method { get; }

    /// <summary>
    ///     Query params
    /// </summary>
    public List<KeyValuePair<string, string>> QueryParams { get; private set; }

    /// <summary>
    ///     Post params
    /// </summary>
    public List<KeyValuePair<string, string>> PostParams { get; }

    /// <summary>
    ///     Header params
    /// </summary>
    public List<KeyValuePair<string, string>> HeaderParams { get; private set; }

    /// <summary>
    ///     Body
    /// </summary>
    public string? Body { get; set; }
}