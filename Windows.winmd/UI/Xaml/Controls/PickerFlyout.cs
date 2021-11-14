// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PickerFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Static(typeof (IPickerFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PickerFlyout : PickerFlyoutBase, IPickerFlyout
  {
    [MethodImpl]
    public extern PickerFlyout();

    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ConfirmationButtonsVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<PickerFlyout, PickerConfirmedEventArgs> Confirmed;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowAtAsync(FrameworkElement target);

    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    public static extern DependencyProperty ConfirmationButtonsVisibleProperty { [MethodImpl] get; }
  }
}
