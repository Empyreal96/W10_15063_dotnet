// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.ILocalLocationRatingInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [ExclusiveTo(typeof (LocalLocationRatingInfo))]
  [Guid(3407719254, 13140, 17169, 139, 192, 162, 212, 213, 235, 128, 110)]
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  internal interface ILocalLocationRatingInfo
  {
    IReference<double> AggregateRating { get; }

    IReference<int> RatingCount { get; }

    string ProviderIdentifier { get; }
  }
}
