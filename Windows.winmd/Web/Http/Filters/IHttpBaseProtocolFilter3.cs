// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  [Guid(3560918348, 48450, 17326, 135, 23, 173, 44, 143, 75, 41, 55)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IHttpBaseProtocolFilter3 : IHttpFilter, IClosable
  {
    HttpCookieUsageBehavior CookieUsageBehavior { get; set; }
  }
}
