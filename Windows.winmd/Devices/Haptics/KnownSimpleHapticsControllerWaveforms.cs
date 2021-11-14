// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.KnownSimpleHapticsControllerWaveforms
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [Static(typeof (IKnownSimpleHapticsControllerWaveformsStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public static class KnownSimpleHapticsControllerWaveforms
  {
    public static extern ushort Click { [MethodImpl] get; }

    public static extern ushort BuzzContinuous { [MethodImpl] get; }

    public static extern ushort RumbleContinuous { [MethodImpl] get; }

    public static extern ushort Press { [MethodImpl] get; }

    public static extern ushort Release { [MethodImpl] get; }
  }
}
