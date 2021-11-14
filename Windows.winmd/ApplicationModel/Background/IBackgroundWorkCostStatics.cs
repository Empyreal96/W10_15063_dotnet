// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundWorkCostStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundWorkCost))]
  [Guid(3342902882, 49936, 19330, 179, 227, 59, 207, 185, 228, 199, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundWorkCostStatics
  {
    BackgroundWorkCostValue CurrentBackgroundWorkCost { get; }
  }
}
