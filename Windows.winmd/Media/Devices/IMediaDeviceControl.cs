// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IMediaDeviceControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(4020821929, 28533, 18531, 186, 11, 88, 63, 48, 54, 180, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaDeviceControl))]
  internal interface IMediaDeviceControl
  {
    MediaDeviceControlCapabilities Capabilities { get; }

    bool TryGetValue(out double value);

    bool TrySetValue(double value);

    bool TryGetAuto(out bool value);

    bool TrySetAuto(bool value);
  }
}
