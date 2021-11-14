// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ButtonBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Static(typeof (IButtonBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IButtonBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class ButtonBase : ContentControl, IButtonBase
  {
    [MethodImpl]
    protected extern ButtonBase();

    public extern ClickMode ClickMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPointerOver { [MethodImpl] get; }

    public extern bool IsPressed { [MethodImpl] get; }

    public extern ICommand Command { [MethodImpl] get; [MethodImpl] set; }

    public extern object CommandParameter { [MethodImpl] get; [MethodImpl] set; }

    public extern event RoutedEventHandler Click;

    public static extern DependencyProperty ClickModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPointerOverProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPressedProperty { [MethodImpl] get; }

    public static extern DependencyProperty CommandProperty { [MethodImpl] get; }

    public static extern DependencyProperty CommandParameterProperty { [MethodImpl] get; }
  }
}
