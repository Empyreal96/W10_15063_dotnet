// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  [Guid(2682481871, 10627, 18579, 148, 31, 235, 81, 140, 168, 206, 249)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IHttpBaseProtocolFilter4 : IHttpFilter, IClosable
  {
    event TypedEventHandler<HttpBaseProtocolFilter, HttpServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;

    void ClearAuthenticationCache();
  }
}
