// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterConeProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AudioNodeEmitterConeProperties : IAudioNodeEmitterConeProperties
  {
    public extern double InnerAngle { [MethodImpl] get; }

    public extern double OuterAngle { [MethodImpl] get; }

    public extern double OuterAngleGain { [MethodImpl] get; }
  }
}
