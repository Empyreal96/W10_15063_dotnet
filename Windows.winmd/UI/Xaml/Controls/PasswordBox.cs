// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PasswordBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPasswordBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IPasswordBoxStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPasswordBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PasswordBox : Control, IPasswordBox, IPasswordBox2, IPasswordBox3
  {
    [MethodImpl]
    public extern PasswordBox();

    public extern string Password { [MethodImpl] get; [MethodImpl] set; }

    public extern string PasswordChar { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPasswordRevealButtonEnabled { [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern int MaxLength { [MethodImpl] get; [MethodImpl] set; }

    public extern event RoutedEventHandler PasswordChanged;

    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    [MethodImpl]
    public extern void SelectAll();

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    public extern SolidColorBrush SelectionHighlightColor { [MethodImpl] get; [MethodImpl] set; }

    public extern bool PreventKeyboardDisplayOnProgrammaticFocus { [MethodImpl] get; [MethodImpl] set; }

    public extern event TextControlPasteEventHandler Paste;

    public extern PasswordRevealMode PasswordRevealMode { [MethodImpl] get; [MethodImpl] set; }

    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    public extern InputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PasswordRevealModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextReadingOrderProperty { [MethodImpl] get; }

    public static extern DependencyProperty InputScopeProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionHighlightColorProperty { [MethodImpl] get; }

    public static extern DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { [MethodImpl] get; }

    public static extern DependencyProperty PasswordProperty { [MethodImpl] get; }

    public static extern DependencyProperty PasswordCharProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPasswordRevealButtonEnabledProperty { [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern DependencyProperty MaxLengthProperty { [MethodImpl] get; }
  }
}
