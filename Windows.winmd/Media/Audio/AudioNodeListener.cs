// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeListener
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Audio
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AudioNodeListener : IAudioNodeListener
  {
    [MethodImpl]
    public extern AudioNodeListener();

    public extern Vector3 Position { [MethodImpl] get; [MethodImpl] set; }

    public extern Quaternion Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern double SpeedOfSound { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 DopplerVelocity { [MethodImpl] get; [MethodImpl] set; }
  }
}
