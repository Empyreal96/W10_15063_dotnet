// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaClipStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Editing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1528682419, 34126, 19867, 135, 125, 71, 116, 165, 86, 205, 18)]
  [ExclusiveTo(typeof (MediaClip))]
  internal interface IMediaClipStatics2
  {
    MediaClip CreateFromSurface(IDirect3DSurface surface, TimeSpan originalDuration);
  }
}
