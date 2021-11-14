// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpRequestMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpRequestMessage))]
  [Guid(4118162236, 29908, 18449, 181, 220, 159, 139, 78, 47, 154, 191)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpRequestMessage : IClosable
  {
    IHttpContent Content { get; set; }

    HttpRequestHeaderCollection Headers { get; }

    HttpMethod Method { get; set; }

    IMap<string, object> Properties { get; }

    Uri RequestUri { get; set; }

    HttpTransportInformation TransportInformation { get; }
  }
}
