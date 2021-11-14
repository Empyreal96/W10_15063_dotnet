// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialog2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ContentDialog))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(798223173, 60995, 17155, 155, 56, 63, 225, 161, 17, 236, 191)]
  internal interface IContentDialog2
  {
    string CloseButtonText { get; set; }

    ICommand CloseButtonCommand { get; set; }

    object CloseButtonCommandParameter { get; set; }

    Style PrimaryButtonStyle { get; set; }

    Style SecondaryButtonStyle { get; set; }

    Style CloseButtonStyle { get; set; }

    ContentDialogButton DefaultButton { get; set; }

    event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> CloseButtonClick;
  }
}
