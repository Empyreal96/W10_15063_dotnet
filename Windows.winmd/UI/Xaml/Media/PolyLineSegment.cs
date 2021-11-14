// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PolyLineSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  [Static(typeof (IPolyLineSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Points")]
  public sealed class PolyLineSegment : PathSegment, IPolyLineSegment
  {
    [MethodImpl]
    public extern PolyLineSegment();

    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
