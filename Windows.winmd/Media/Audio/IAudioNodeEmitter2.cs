// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1253502667, 60457, 18424, 129, 140, 182, 182, 96, 165, 174, 177)]
  [ExclusiveTo(typeof (AudioNodeEmitter))]
  internal interface IAudioNodeEmitter2
  {
    SpatialAudioModel SpatialAudioModel { get; set; }
  }
}
