// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Line
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ILineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Line : Shape, ILine
  {
    [MethodImpl]
    public extern Line();

    public extern double X1 { [MethodImpl] get; [MethodImpl] set; }

    public extern double Y1 { [MethodImpl] get; [MethodImpl] set; }

    public extern double X2 { [MethodImpl] get; [MethodImpl] set; }

    public extern double Y2 { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty X1Property { [MethodImpl] get; }

    public static extern DependencyProperty Y1Property { [MethodImpl] get; }

    public static extern DependencyProperty X2Property { [MethodImpl] get; }

    public static extern DependencyProperty Y2Property { [MethodImpl] get; }
  }
}
