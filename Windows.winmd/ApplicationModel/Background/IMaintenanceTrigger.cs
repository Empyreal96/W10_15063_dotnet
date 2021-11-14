// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IMaintenanceTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (MaintenanceTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1746422915, 64546, 19685, 132, 26, 114, 57, 169, 129, 0, 71)]
  internal interface IMaintenanceTrigger : IBackgroundTrigger
  {
    uint FreshnessTime { get; }

    bool OneShot { get; }
  }
}
