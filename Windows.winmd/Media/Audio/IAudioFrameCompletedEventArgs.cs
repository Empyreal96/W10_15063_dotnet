// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFrameCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioFrameCompletedEventArgs))]
  [Guid(3699147422, 520, 17668, 165, 168, 240, 242, 104, 146, 10, 101)]
  internal interface IAudioFrameCompletedEventArgs
  {
    AudioFrame Frame { get; }
  }
}
