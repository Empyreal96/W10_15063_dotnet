// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpCacheReadBehavior
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpCacheReadBehavior
  {
    Default,
    MostRecent,
    OnlyFromCache,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] NoCache,
  }
}
