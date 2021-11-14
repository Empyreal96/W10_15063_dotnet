// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IBasicAudioEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2349214803, 27584, 18616, 169, 154, 75, 65, 85, 15, 19, 89)]
  public interface IBasicAudioEffect : IMediaExtension
  {
    bool UseInputFrameForOutput { get; }

    IVectorView<AudioEncodingProperties> SupportedEncodingProperties { get; }

    void SetEncodingProperties(AudioEncodingProperties encodingProperties);

    void ProcessFrame(ProcessAudioFrameContext context);

    void Close(MediaEffectClosedReason reason);

    void DiscardQueuedFrames();
  }
}
