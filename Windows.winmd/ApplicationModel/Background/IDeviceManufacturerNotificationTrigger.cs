// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceManufacturerNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2166852277, 16811, 5850, 134, 194, 127, 123, 240, 145, 47, 91)]
  [ExclusiveTo(typeof (DeviceManufacturerNotificationTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceManufacturerNotificationTrigger : IBackgroundTrigger
  {
    string TriggerQualifier { get; }

    bool OneShot { get; }
  }
}
