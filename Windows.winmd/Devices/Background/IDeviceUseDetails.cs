// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Background.IDeviceUseDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Background
{
  [Guid(2102808897, 21886, 16724, 185, 148, 228, 247, 161, 31, 179, 35)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceUseDetails))]
  internal interface IDeviceUseDetails
  {
    string DeviceId { get; }

    string Arguments { get; }
  }
}
