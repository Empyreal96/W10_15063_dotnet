// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PathFigure
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Segments")]
  [Static(typeof (IPathFigureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PathFigure : DependencyObject, IPathFigure
  {
    [MethodImpl]
    public extern PathFigure();

    public extern PathSegmentCollection Segments { [MethodImpl] get; [MethodImpl] set; }

    public extern Point StartPoint { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsClosed { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFilled { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SegmentsProperty { [MethodImpl] get; }

    public static extern DependencyProperty StartPointProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsClosedProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFilledProperty { [MethodImpl] get; }
  }
}
