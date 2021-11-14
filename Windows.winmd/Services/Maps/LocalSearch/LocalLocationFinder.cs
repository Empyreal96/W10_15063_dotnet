// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.LocalLocationFinder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 65536)]
  [Static(typeof (ILocalLocationFinderStatics), 65536, "Windows.Services.Maps.LocalSearchContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public static class LocalLocationFinder
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LocalLocationFinderResult> FindLocalLocationsAsync(
      string searchTerm,
      Geocircle searchArea,
      string localCategory,
      uint maxResults);
  }
}
