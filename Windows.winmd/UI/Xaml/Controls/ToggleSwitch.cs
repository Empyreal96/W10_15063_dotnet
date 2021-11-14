// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToggleSwitch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Header")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IToggleSwitchStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ToggleSwitch : Control, IToggleSwitch, IToggleSwitchOverrides
  {
    [MethodImpl]
    public extern ToggleSwitch();

    public extern bool IsOn { [MethodImpl] get; [MethodImpl] set; }

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern object OnContent { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate OnContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern object OffContent { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate OffContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern ToggleSwitchTemplateSettings TemplateSettings { [MethodImpl] get; }

    public extern event RoutedEventHandler Toggled;

    [MethodImpl]
    extern void IToggleSwitchOverrides.OnToggled();

    [MethodImpl]
    extern void IToggleSwitchOverrides.OnOnContentChanged(
      object oldContent,
      object newContent);

    [MethodImpl]
    extern void IToggleSwitchOverrides.OnOffContentChanged(
      object oldContent,
      object newContent);

    [MethodImpl]
    extern void IToggleSwitchOverrides.OnHeaderChanged(
      object oldContent,
      object newContent);

    public static extern DependencyProperty IsOnProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty OnContentProperty { [MethodImpl] get; }

    public static extern DependencyProperty OnContentTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty OffContentProperty { [MethodImpl] get; }

    public static extern DependencyProperty OffContentTemplateProperty { [MethodImpl] get; }
  }
}
