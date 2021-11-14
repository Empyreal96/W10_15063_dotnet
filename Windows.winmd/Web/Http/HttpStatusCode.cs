﻿// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpStatusCode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpStatusCode
  {
    None = 0,
    Continue = 100, // 0x00000064
    SwitchingProtocols = 101, // 0x00000065
    Processing = 102, // 0x00000066
    Ok = 200, // 0x000000C8
    Created = 201, // 0x000000C9
    Accepted = 202, // 0x000000CA
    NonAuthoritativeInformation = 203, // 0x000000CB
    NoContent = 204, // 0x000000CC
    ResetContent = 205, // 0x000000CD
    PartialContent = 206, // 0x000000CE
    MultiStatus = 207, // 0x000000CF
    AlreadyReported = 208, // 0x000000D0
    IMUsed = 226, // 0x000000E2
    MultipleChoices = 300, // 0x0000012C
    MovedPermanently = 301, // 0x0000012D
    Found = 302, // 0x0000012E
    SeeOther = 303, // 0x0000012F
    NotModified = 304, // 0x00000130
    UseProxy = 305, // 0x00000131
    TemporaryRedirect = 307, // 0x00000133
    PermanentRedirect = 308, // 0x00000134
    BadRequest = 400, // 0x00000190
    Unauthorized = 401, // 0x00000191
    PaymentRequired = 402, // 0x00000192
    Forbidden = 403, // 0x00000193
    NotFound = 404, // 0x00000194
    MethodNotAllowed = 405, // 0x00000195
    NotAcceptable = 406, // 0x00000196
    ProxyAuthenticationRequired = 407, // 0x00000197
    RequestTimeout = 408, // 0x00000198
    Conflict = 409, // 0x00000199
    Gone = 410, // 0x0000019A
    LengthRequired = 411, // 0x0000019B
    PreconditionFailed = 412, // 0x0000019C
    RequestEntityTooLarge = 413, // 0x0000019D
    RequestUriTooLong = 414, // 0x0000019E
    UnsupportedMediaType = 415, // 0x0000019F
    RequestedRangeNotSatisfiable = 416, // 0x000001A0
    ExpectationFailed = 417, // 0x000001A1
    UnprocessableEntity = 422, // 0x000001A6
    Locked = 423, // 0x000001A7
    FailedDependency = 424, // 0x000001A8
    UpgradeRequired = 426, // 0x000001AA
    PreconditionRequired = 428, // 0x000001AC
    TooManyRequests = 429, // 0x000001AD
    RequestHeaderFieldsTooLarge = 431, // 0x000001AF
    InternalServerError = 500, // 0x000001F4
    NotImplemented = 501, // 0x000001F5
    BadGateway = 502, // 0x000001F6
    ServiceUnavailable = 503, // 0x000001F7
    GatewayTimeout = 504, // 0x000001F8
    HttpVersionNotSupported = 505, // 0x000001F9
    VariantAlsoNegotiates = 506, // 0x000001FA
    InsufficientStorage = 507, // 0x000001FB
    LoopDetected = 508, // 0x000001FC
    NotExtended = 510, // 0x000001FE
    NetworkAuthenticationRequired = 511, // 0x000001FF
  }
}
