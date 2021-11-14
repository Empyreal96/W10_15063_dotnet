// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IVirtualSurfaceImageSourceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class VirtualSurfaceImageSource : SurfaceImageSource, IVirtualSurfaceImageSource
  {
    [MethodImpl]
    public extern VirtualSurfaceImageSource(int pixelWidth, int pixelHeight);

    [MethodImpl]
    public extern VirtualSurfaceImageSource(int pixelWidth, int pixelHeight, bool isOpaque);
  }
}
