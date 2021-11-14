// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2224650914, 842, 17472, 136, 19, 125, 11, 212, 121, 191, 90)]
  [ExclusiveTo(typeof (DevicePicker))]
  internal interface IDevicePicker
  {
    DevicePickerFilter Filter { get; }

    DevicePickerAppearance Appearance { get; }

    IVector<string> RequestedProperties { get; }

    event TypedEventHandler<DevicePicker, DeviceSelectedEventArgs> DeviceSelected;

    event TypedEventHandler<DevicePicker, DeviceDisconnectButtonClickedEventArgs> DisconnectButtonClicked;

    event TypedEventHandler<DevicePicker, object> DevicePickerDismissed;

    [Overload("Show")]
    void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    void Show(Rect selection, Placement placement);

    [Overload("PickSingleDeviceAsync")]
    IAsyncOperation<DeviceInformation> PickSingleDeviceAsync(
      Rect selection);

    [Overload("PickSingleDeviceAsyncWithPlacement")]
    IAsyncOperation<DeviceInformation> PickSingleDeviceAsync(
      Rect selection,
      Placement placement);

    void Hide();

    void SetDisplayStatus(
      DeviceInformation device,
      string status,
      DevicePickerDisplayStatusOptions options);
  }
}
