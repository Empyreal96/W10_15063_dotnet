// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(1995190578, 57689, 19127, 168, 42, 23, 190, 180, 179, 30, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioGraph))]
  internal interface IAudioGraphStatics
  {
    [RemoteAsync]
    IAsyncOperation<CreateAudioGraphResult> CreateAsync(
      AudioGraphSettings settings);
  }
}
