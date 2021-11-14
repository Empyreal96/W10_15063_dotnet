// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AppBarToggleButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAppBarToggleButtonStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IAppBarToggleButtonFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAppBarToggleButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class AppBarToggleButton : 
    ToggleButton,
    IAppBarToggleButton,
    ICommandBarElement,
    IAppBarToggleButton3,
    ICommandBarElement2
  {
    [MethodImpl]
    public extern AppBarToggleButton();

    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    public extern IconElement Icon { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCompact { [MethodImpl] get; [MethodImpl] set; }

    public extern CommandBarLabelPosition LabelPosition { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsInOverflow { [MethodImpl] get; }

    public extern int DynamicOverflowOrder { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LabelPositionProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsInOverflowProperty { [MethodImpl] get; }

    public static extern DependencyProperty DynamicOverflowOrderProperty { [MethodImpl] get; }

    public static extern DependencyProperty LabelProperty { [MethodImpl] get; }

    public static extern DependencyProperty IconProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsCompactProperty { [MethodImpl] get; }
  }
}
