// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SettingsFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Composable(typeof (ISettingsFlyoutFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISettingsFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class SettingsFlyout : ContentControl, ISettingsFlyout
  {
    [MethodImpl]
    public extern SettingsFlyout();

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush HeaderBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush HeaderForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern ImageSource IconSource { [MethodImpl] get; [MethodImpl] set; }

    public extern SettingsFlyoutTemplateSettings TemplateSettings { [MethodImpl] get; }

    public extern event BackClickEventHandler BackClick;

    [MethodImpl]
    public extern void Show();

    [MethodImpl]
    public extern void ShowIndependent();

    [MethodImpl]
    public extern void Hide();

    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty IconSourceProperty { [MethodImpl] get; }
  }
}
