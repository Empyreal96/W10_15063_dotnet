// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameExposureCompensationCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class FrameExposureCompensationCapabilities : IFrameExposureCompensationCapabilities
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern float Min { [MethodImpl] get; }

    public extern float Max { [MethodImpl] get; }

    public extern float Step { [MethodImpl] get; }
  }
}
