// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPerspectiveTransform3DStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class PerspectiveTransform3D : Transform3D, IPerspectiveTransform3D
  {
    [MethodImpl]
    public extern PerspectiveTransform3D();

    public extern double Depth { [MethodImpl] get; [MethodImpl] set; }

    public extern double OffsetX { [MethodImpl] get; [MethodImpl] set; }

    public extern double OffsetY { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty DepthProperty { [MethodImpl] get; }

    public static extern DependencyProperty OffsetXProperty { [MethodImpl] get; }

    public static extern DependencyProperty OffsetYProperty { [MethodImpl] get; }
  }
}
