// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceConnectionChangeTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (DeviceConnectionChangeTrigger))]
  [Guid(2424790628, 15581, 20219, 171, 28, 91, 59, 106, 96, 206, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceConnectionChangeTrigger : IBackgroundTrigger
  {
    string DeviceId { get; }

    bool CanMaintainConnection { get; }

    bool MaintainConnection { get; set; }
  }
}
