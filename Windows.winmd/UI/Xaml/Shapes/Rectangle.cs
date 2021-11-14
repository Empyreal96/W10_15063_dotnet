// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Rectangle
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRectangleStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Rectangle : Shape, IRectangle
  {
    [MethodImpl]
    public extern Rectangle();

    public extern double RadiusX { [MethodImpl] get; [MethodImpl] set; }

    public extern double RadiusY { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty RadiusXProperty { [MethodImpl] get; }

    public static extern DependencyProperty RadiusYProperty { [MethodImpl] get; }
  }
}
