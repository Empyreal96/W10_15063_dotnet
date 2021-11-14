// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.ILocalLocation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [WebHostHidden]
  [Guid(1855860860, 60597, 20476, 187, 140, 186, 80, 186, 140, 45, 198)]
  [ExclusiveTo(typeof (LocalLocation))]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  internal interface ILocalLocation2
  {
    string Category { get; }

    LocalLocationRatingInfo RatingInfo { get; }

    IVectorView<LocalLocationHoursOfOperationItem> HoursOfOperation { get; }
  }
}
