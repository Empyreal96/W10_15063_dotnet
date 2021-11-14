// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpResponseMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpResponseMessage))]
  [Guid(4276224251, 34404, 17632, 149, 217, 66, 105, 97, 153, 191, 252)]
  internal interface IHttpResponseMessage : IClosable
  {
    IHttpContent Content { get; set; }

    HttpResponseHeaderCollection Headers { get; }

    bool IsSuccessStatusCode { get; }

    string ReasonPhrase { get; set; }

    HttpRequestMessage RequestMessage { get; set; }

    HttpResponseMessageSource Source { get; set; }

    HttpStatusCode StatusCode { get; set; }

    HttpVersion Version { get; set; }

    HttpResponseMessage EnsureSuccessStatusCode();
  }
}
