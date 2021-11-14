// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDevicePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3128840714, 65369, 20299, 189, 172, 216, 159, 73, 90, 214, 225)]
  [ExclusiveTo(typeof (DialDevicePicker))]
  internal interface IDialDevicePicker
  {
    DialDevicePickerFilter Filter { get; }

    DevicePickerAppearance Appearance { get; }

    event TypedEventHandler<DialDevicePicker, DialDeviceSelectedEventArgs> DialDeviceSelected;

    event TypedEventHandler<DialDevicePicker, DialDisconnectButtonClickedEventArgs> DisconnectButtonClicked;

    event TypedEventHandler<DialDevicePicker, object> DialDevicePickerDismissed;

    [Overload("Show")]
    void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    void Show(Rect selection, Placement preferredPlacement);

    [Overload("PickSingleDialDeviceAsync")]
    IAsyncOperation<DialDevice> PickSingleDialDeviceAsync(Rect selection);

    [Overload("PickSingleDialDeviceAsyncWithPlacement")]
    IAsyncOperation<DialDevice> PickSingleDialDeviceAsync(
      Rect selection,
      Placement preferredPlacement);

    void Hide();

    void SetDisplayStatus(DialDevice device, DialDeviceDisplayStatus status);
  }
}
