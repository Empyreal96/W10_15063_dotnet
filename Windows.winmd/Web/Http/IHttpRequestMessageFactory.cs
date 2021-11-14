// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpRequestMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1538038094, 14470, 16686, 174, 195, 82, 236, 127, 37, 97, 111)]
  [ExclusiveTo(typeof (HttpRequestMessage))]
  internal interface IHttpRequestMessageFactory
  {
    HttpRequestMessage Create(HttpMethod method, Uri uri);
  }
}
