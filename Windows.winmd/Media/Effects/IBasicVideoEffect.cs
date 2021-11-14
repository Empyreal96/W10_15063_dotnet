// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IBasicVideoEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.MediaProperties;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2187511791, 45920, 16574, 148, 155, 47, 244, 47, 243, 86, 147)]
  public interface IBasicVideoEffect : IMediaExtension
  {
    bool IsReadOnly { get; }

    MediaMemoryTypes SupportedMemoryTypes { get; }

    bool TimeIndependent { get; }

    IVectorView<VideoEncodingProperties> SupportedEncodingProperties { get; }

    void SetEncodingProperties(VideoEncodingProperties encodingProperties, IDirect3DDevice device);

    void ProcessFrame(ProcessVideoFrameContext context);

    void Close(MediaEffectClosedReason reason);

    void DiscardQueuedFrames();
  }
}
