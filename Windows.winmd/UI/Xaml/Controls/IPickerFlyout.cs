// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPickerFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PickerFlyout))]
  [WebHostHidden]
  [Guid(2738290651, 2265, 17382, 148, 78, 242, 229, 199, 206, 230, 48)]
  internal interface IPickerFlyout
  {
    UIElement Content { get; set; }

    bool ConfirmationButtonsVisible { get; set; }

    event TypedEventHandler<PickerFlyout, PickerConfirmedEventArgs> Confirmed;

    [RemoteAsync]
    IAsyncOperation<bool> ShowAtAsync(FrameworkElement target);
  }
}
