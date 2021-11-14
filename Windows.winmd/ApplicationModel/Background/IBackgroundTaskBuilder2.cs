// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskBuilder2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1793576881, 4175, 16493, 141, 182, 132, 74, 87, 15, 66, 187)]
  [ExclusiveTo(typeof (BackgroundTaskBuilder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundTaskBuilder2 : IBackgroundTaskBuilder
  {
    bool CancelOnConditionLoss { set; get; }
  }
}
