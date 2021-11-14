// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentDialog
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IContentDialogFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IContentDialogStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IContentDialogStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class ContentDialog : ContentControl, IContentDialog, IContentDialog2
  {
    [MethodImpl]
    public extern ContentDialog();

    public extern object Title { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate TitleTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool FullSizeDesired { [MethodImpl] get; [MethodImpl] set; }

    public extern string PrimaryButtonText { [MethodImpl] get; [MethodImpl] set; }

    public extern string SecondaryButtonText { [MethodImpl] get; [MethodImpl] set; }

    public extern ICommand PrimaryButtonCommand { [MethodImpl] get; [MethodImpl] set; }

    public extern ICommand SecondaryButtonCommand { [MethodImpl] get; [MethodImpl] set; }

    public extern object PrimaryButtonCommandParameter { [MethodImpl] get; [MethodImpl] set; }

    public extern object SecondaryButtonCommandParameter { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPrimaryButtonEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSecondaryButtonEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<ContentDialog, ContentDialogClosingEventArgs> Closing;

    public extern event TypedEventHandler<ContentDialog, ContentDialogClosedEventArgs> Closed;

    public extern event TypedEventHandler<ContentDialog, ContentDialogOpenedEventArgs> Opened;

    public extern event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> PrimaryButtonClick;

    public extern event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> SecondaryButtonClick;

    [MethodImpl]
    public extern void Hide();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContentDialogResult> ShowAsync();

    public extern string CloseButtonText { [MethodImpl] get; [MethodImpl] set; }

    public extern ICommand CloseButtonCommand { [MethodImpl] get; [MethodImpl] set; }

    public extern object CloseButtonCommandParameter { [MethodImpl] get; [MethodImpl] set; }

    public extern Style PrimaryButtonStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern Style SecondaryButtonStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern Style CloseButtonStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern ContentDialogButton DefaultButton { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> CloseButtonClick;

    public static extern DependencyProperty CloseButtonTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty CloseButtonCommandProperty { [MethodImpl] get; }

    public static extern DependencyProperty CloseButtonCommandParameterProperty { [MethodImpl] get; }

    public static extern DependencyProperty PrimaryButtonStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty SecondaryButtonStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty CloseButtonStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty DefaultButtonProperty { [MethodImpl] get; }

    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    public static extern DependencyProperty TitleTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty FullSizeDesiredProperty { [MethodImpl] get; }

    public static extern DependencyProperty PrimaryButtonTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty SecondaryButtonTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty PrimaryButtonCommandProperty { [MethodImpl] get; }

    public static extern DependencyProperty SecondaryButtonCommandProperty { [MethodImpl] get; }

    public static extern DependencyProperty PrimaryButtonCommandParameterProperty { [MethodImpl] get; }

    public static extern DependencyProperty SecondaryButtonCommandParameterProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPrimaryButtonEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSecondaryButtonEnabledProperty { [MethodImpl] get; }
  }
}
