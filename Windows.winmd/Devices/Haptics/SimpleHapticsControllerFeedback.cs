// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.SimpleHapticsControllerFeedback
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  public sealed class SimpleHapticsControllerFeedback : ISimpleHapticsControllerFeedback
  {
    public extern ushort Waveform { [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] get; }
  }
}
