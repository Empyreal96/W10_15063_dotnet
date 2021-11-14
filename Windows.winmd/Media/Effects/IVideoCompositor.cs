// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoCompositor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.MediaProperties;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2232464446, 16908, 16911, 150, 199, 124, 152, 187, 161, 252, 85)]
  public interface IVideoCompositor : IMediaExtension
  {
    bool TimeIndependent { get; }

    void SetEncodingProperties(VideoEncodingProperties backgroundProperties, IDirect3DDevice device);

    void CompositeFrame(CompositeVideoFrameContext context);

    void Close(MediaEffectClosedReason reason);

    void DiscardQueuedFrames();
  }
}
