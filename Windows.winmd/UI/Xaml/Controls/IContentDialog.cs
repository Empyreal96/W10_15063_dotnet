// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialog
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [Guid(953959428, 53838, 16600, 148, 21, 52, 148, 100, 193, 175, 220)]
  [ExclusiveTo(typeof (ContentDialog))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentDialog
  {
    object Title { get; set; }

    DataTemplate TitleTemplate { get; set; }

    bool FullSizeDesired { get; set; }

    string PrimaryButtonText { get; set; }

    string SecondaryButtonText { get; set; }

    ICommand PrimaryButtonCommand { get; set; }

    ICommand SecondaryButtonCommand { get; set; }

    object PrimaryButtonCommandParameter { get; set; }

    object SecondaryButtonCommandParameter { get; set; }

    bool IsPrimaryButtonEnabled { get; set; }

    bool IsSecondaryButtonEnabled { get; set; }

    event TypedEventHandler<ContentDialog, ContentDialogClosingEventArgs> Closing;

    event TypedEventHandler<ContentDialog, ContentDialogClosedEventArgs> Closed;

    event TypedEventHandler<ContentDialog, ContentDialogOpenedEventArgs> Opened;

    event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> PrimaryButtonClick;

    event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> SecondaryButtonClick;

    void Hide();

    [RemoteAsync]
    IAsyncOperation<ContentDialogResult> ShowAsync();
  }
}
