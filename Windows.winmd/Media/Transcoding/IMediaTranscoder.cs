// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.IMediaTranscoder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Transcoding
{
  [Guid(420256210, 41130, 19764, 134, 188, 238, 209, 177, 44, 47, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaTranscoder))]
  internal interface IMediaTranscoder
  {
    TimeSpan TrimStartTime { set; get; }

    TimeSpan TrimStopTime { set; get; }

    bool AlwaysReencode { set; get; }

    bool HardwareAccelerationEnabled { set; get; }

    [Overload("AddAudioEffect")]
    void AddAudioEffect(string activatableClassId);

    [Overload("AddAudioEffectWithSettings")]
    void AddAudioEffect(string activatableClassId, bool effectRequired, IPropertySet configuration);

    [Overload("AddVideoEffect")]
    void AddVideoEffect(string activatableClassId);

    [Overload("AddVideoEffectWithSettings")]
    void AddVideoEffect(string activatableClassId, bool effectRequired, IPropertySet configuration);

    void ClearEffects();

    IAsyncOperation<PrepareTranscodeResult> PrepareFileTranscodeAsync(
      IStorageFile source,
      IStorageFile destination,
      MediaEncodingProfile profile);

    IAsyncOperation<PrepareTranscodeResult> PrepareStreamTranscodeAsync(
      IRandomAccessStream source,
      IRandomAccessStream destination,
      MediaEncodingProfile profile);
  }
}
