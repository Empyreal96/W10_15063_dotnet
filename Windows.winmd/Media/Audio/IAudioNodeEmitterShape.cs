// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterShape
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(3926069701, 59197, 17596, 133, 156, 69, 85, 59, 188, 72, 40)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AudioNodeEmitterShape))]
  internal interface IAudioNodeEmitterShape
  {
    AudioNodeEmitterShapeKind Kind { get; }

    AudioNodeEmitterConeProperties ConeProperties { get; }
  }
}
