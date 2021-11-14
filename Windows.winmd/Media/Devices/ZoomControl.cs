// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ZoomControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ZoomControl : IZoomControl, IZoomControl2
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern float Min { [MethodImpl] get; }

    public extern float Max { [MethodImpl] get; }

    public extern float Step { [MethodImpl] get; }

    public extern float Value { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<ZoomTransitionMode> SupportedModes { [MethodImpl] get; }

    public extern ZoomTransitionMode Mode { [MethodImpl] get; }

    [MethodImpl]
    public extern void Configure(ZoomSettings settings);
  }
}
