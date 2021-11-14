// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewScalingStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (ViewManagementViewScalingContract), 65536)]
  [Guid(2962222320, 47430, 17864, 165, 227, 113, 245, 170, 120, 248, 97)]
  [ExclusiveTo(typeof (ApplicationViewScaling))]
  internal interface IApplicationViewScalingStatics
  {
    bool DisableLayoutScaling { get; }

    bool TrySetDisableLayoutScaling(bool disableLayoutScaling);
  }
}
