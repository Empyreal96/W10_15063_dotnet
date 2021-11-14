// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.MediaDeviceControlCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaDeviceControlCapabilities : IMediaDeviceControlCapabilities
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern double Min { [MethodImpl] get; }

    public extern double Max { [MethodImpl] get; }

    public extern double Step { [MethodImpl] get; }

    public extern double Default { [MethodImpl] get; }

    public extern bool AutoModeSupported { [MethodImpl] get; }
  }
}
