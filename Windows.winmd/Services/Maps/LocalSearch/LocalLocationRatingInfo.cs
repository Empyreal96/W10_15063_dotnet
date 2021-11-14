// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.LocalLocationRatingInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LocalLocationRatingInfo : ILocalLocationRatingInfo
  {
    public extern IReference<double> AggregateRating { [MethodImpl] get; }

    public extern IReference<int> RatingCount { [MethodImpl] get; }

    public extern string ProviderIdentifier { [MethodImpl] get; }
  }
}
