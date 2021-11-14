// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.ILocalLocationFinderResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [ContractVersion(typeof (LocalSearchContract), 65536)]
  [ExclusiveTo(typeof (LocalLocationFinderResult))]
  [Guid(3499846854, 62264, 16785, 159, 216, 84, 64, 185, 166, 143, 82)]
  [WebHostHidden]
  internal interface ILocalLocationFinderResult
  {
    IVectorView<LocalLocation> LocalLocations { get; }

    LocalLocationFinderStatus Status { get; }
  }
}
