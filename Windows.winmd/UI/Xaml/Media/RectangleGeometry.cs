// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.RectangleGeometry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRectangleGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RectangleGeometry : Geometry, IRectangleGeometry
  {
    [MethodImpl]
    public extern RectangleGeometry();

    public extern Rect Rect { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty RectProperty { [MethodImpl] get; }
  }
}
