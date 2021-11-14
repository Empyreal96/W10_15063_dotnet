// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.MediaDeviceControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaDeviceControl : IMediaDeviceControl
  {
    public extern MediaDeviceControlCapabilities Capabilities { [MethodImpl] get; }

    [MethodImpl]
    public extern bool TryGetValue(out double value);

    [MethodImpl]
    public extern bool TrySetValue(double value);

    [MethodImpl]
    public extern bool TryGetAuto(out bool value);

    [MethodImpl]
    public extern bool TrySetAuto(bool value);
  }
}
