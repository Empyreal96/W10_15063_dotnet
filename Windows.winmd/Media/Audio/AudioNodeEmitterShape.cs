// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterShape
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAudioNodeEmitterShapeStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AudioNodeEmitterShape : IAudioNodeEmitterShape
  {
    public extern AudioNodeEmitterShapeKind Kind { [MethodImpl] get; }

    public extern AudioNodeEmitterConeProperties ConeProperties { [MethodImpl] get; }

    [MethodImpl]
    public static extern AudioNodeEmitterShape CreateCone(
      double innerAngle,
      double outerAngle,
      double outerAngleGain);

    [MethodImpl]
    public static extern AudioNodeEmitterShape CreateOmnidirectional();
  }
}
