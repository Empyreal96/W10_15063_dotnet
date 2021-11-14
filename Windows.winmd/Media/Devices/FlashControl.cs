// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.FlashControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class FlashControl : IFlashControl, IFlashControl2
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern bool PowerSupported { [MethodImpl] get; }

    public extern bool RedEyeReductionSupported { [MethodImpl] get; }

    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Auto { [MethodImpl] get; [MethodImpl] set; }

    public extern bool RedEyeReduction { [MethodImpl] get; [MethodImpl] set; }

    public extern float PowerPercent { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AssistantLightSupported { [MethodImpl] get; }

    public extern bool AssistantLightEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
