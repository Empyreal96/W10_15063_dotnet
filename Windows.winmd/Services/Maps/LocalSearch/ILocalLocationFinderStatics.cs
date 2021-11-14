// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.ILocalLocationFinderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [WebHostHidden]
  [Guid(3538907972, 41182, 18634, 129, 168, 7, 199, 220, 253, 55, 171)]
  [ContractVersion(typeof (LocalSearchContract), 65536)]
  [ExclusiveTo(typeof (LocalLocationFinder))]
  internal interface ILocalLocationFinderStatics
  {
    [RemoteAsync]
    IAsyncOperation<LocalLocationFinderResult> FindLocalLocationsAsync(
      string searchTerm,
      Geocircle searchArea,
      string localCategory,
      uint maxResults);
  }
}
