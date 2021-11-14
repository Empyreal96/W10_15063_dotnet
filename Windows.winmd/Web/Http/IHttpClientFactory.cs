// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpClientFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Filters;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpClient))]
  [Guid(3272363722, 58362, 20377, 175, 180, 99, 204, 101, 0, 148, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpClientFactory
  {
    HttpClient Create(IHttpFilter filter);
  }
}
