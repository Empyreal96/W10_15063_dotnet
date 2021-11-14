// Decompiled with JetBrains decompiler
// Type: Windows.Web.WebErrorStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebErrorStatus
  {
    Unknown = 0,
    CertificateCommonNameIsIncorrect = 1,
    CertificateExpired = 2,
    CertificateContainsErrors = 3,
    CertificateRevoked = 4,
    CertificateIsInvalid = 5,
    ServerUnreachable = 6,
    Timeout = 7,
    ErrorHttpInvalidServerResponse = 8,
    ConnectionAborted = 9,
    ConnectionReset = 10, // 0x0000000A
    Disconnected = 11, // 0x0000000B
    HttpToHttpsOnRedirection = 12, // 0x0000000C
    HttpsToHttpOnRedirection = 13, // 0x0000000D
    CannotConnect = 14, // 0x0000000E
    HostNameNotResolved = 15, // 0x0000000F
    OperationCanceled = 16, // 0x00000010
    RedirectFailed = 17, // 0x00000011
    UnexpectedStatusCode = 18, // 0x00000012
    UnexpectedRedirection = 19, // 0x00000013
    UnexpectedClientError = 20, // 0x00000014
    UnexpectedServerError = 21, // 0x00000015
    MultipleChoices = 300, // 0x0000012C
    MovedPermanently = 301, // 0x0000012D
    Found = 302, // 0x0000012E
    SeeOther = 303, // 0x0000012F
    NotModified = 304, // 0x00000130
    UseProxy = 305, // 0x00000131
    TemporaryRedirect = 307, // 0x00000133
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
    InternalServerError = 500, // 0x000001F4
    NotImplemented = 501, // 0x000001F5
    BadGateway = 502, // 0x000001F6
    ServiceUnavailable = 503, // 0x000001F7
    GatewayTimeout = 504, // 0x000001F8
    HttpVersionNotSupported = 505, // 0x000001F9
  }
}
