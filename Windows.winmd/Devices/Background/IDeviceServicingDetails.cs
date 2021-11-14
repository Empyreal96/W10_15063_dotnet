// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Background.IDeviceServicingDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Background
{
  [Guid(1252781609, 9028, 19140, 133, 39, 74, 142, 246, 144, 86, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceServicingDetails))]
  internal interface IDeviceServicingDetails
  {
    string DeviceId { get; }

    string Arguments { get; }

    TimeSpan ExpectedDuration { get; }
  }
}
