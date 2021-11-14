// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceWatcherEvent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DeviceWatcherEvent : IDeviceWatcherEvent
  {
    public extern DeviceWatcherEventKind Kind { [MethodImpl] get; }

    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    public extern DeviceInformationUpdate DeviceInformationUpdate { [MethodImpl] get; }
  }
}
