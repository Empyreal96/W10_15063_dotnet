// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ToggleButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IToggleButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IToggleButtonFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ToggleButton : ButtonBase, IToggleButton, IToggleButtonOverrides
  {
    [MethodImpl]
    public extern ToggleButton();

    public extern IReference<bool> IsChecked { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsThreeState { [MethodImpl] get; [MethodImpl] set; }

    public extern event RoutedEventHandler Checked;

    public extern event RoutedEventHandler Unchecked;

    public extern event RoutedEventHandler Indeterminate;

    [MethodImpl]
    extern void IToggleButtonOverrides.OnToggle();

    public static extern DependencyProperty IsCheckedProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsThreeStateProperty { [MethodImpl] get; }
  }
}
