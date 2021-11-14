// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpCacheControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [Guid(3346930868, 15594, 20149, 172, 133, 4, 225, 134, 230, 58, 183)]
  [ExclusiveTo(typeof (HttpCacheControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpCacheControl
  {
    HttpCacheReadBehavior ReadBehavior { get; set; }

    HttpCacheWriteBehavior WriteBehavior { get; set; }
  }
}
