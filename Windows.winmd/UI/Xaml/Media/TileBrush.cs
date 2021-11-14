// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TileBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Static(typeof (ITileBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (ITileBrushFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class TileBrush : Brush, ITileBrush
  {
    [MethodImpl]
    protected extern TileBrush();

    public extern AlignmentX AlignmentX { [MethodImpl] get; [MethodImpl] set; }

    public extern AlignmentY AlignmentY { [MethodImpl] get; [MethodImpl] set; }

    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty AlignmentXProperty { [MethodImpl] get; }

    public static extern DependencyProperty AlignmentYProperty { [MethodImpl] get; }

    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }
  }
}
