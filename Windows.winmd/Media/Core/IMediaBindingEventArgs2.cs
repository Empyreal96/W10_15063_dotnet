// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaBindingEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaBindingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(73714923, 47962, 18479, 184, 186, 240, 40, 76, 105, 101, 103)]
  internal interface IMediaBindingEventArgs2
  {
    void SetAdaptiveMediaSource(AdaptiveMediaSource mediaSource);

    void SetStorageFile(IStorageFile file);
  }
}
