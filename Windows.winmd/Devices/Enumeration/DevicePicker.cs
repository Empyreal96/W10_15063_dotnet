// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Devices.Enumeration
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DevicePicker : IDevicePicker
  {
    [MethodImpl]
    public extern DevicePicker();

    public extern DevicePickerFilter Filter { [MethodImpl] get; }

    public extern DevicePickerAppearance Appearance { [MethodImpl] get; }

    public extern IVector<string> RequestedProperties { [MethodImpl] get; }

    public extern event TypedEventHandler<DevicePicker, DeviceSelectedEventArgs> DeviceSelected;

    public extern event TypedEventHandler<DevicePicker, DeviceDisconnectButtonClickedEventArgs> DisconnectButtonClicked;

    public extern event TypedEventHandler<DevicePicker, object> DevicePickerDismissed;

    [Overload("Show")]
    [MethodImpl]
    public extern void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    [MethodImpl]
    public extern void Show(Rect selection, Placement placement);

    [Overload("PickSingleDeviceAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DeviceInformation> PickSingleDeviceAsync(
      Rect selection);

    [Overload("PickSingleDeviceAsyncWithPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<DeviceInformation> PickSingleDeviceAsync(
      Rect selection,
      Placement placement);

    [MethodImpl]
    public extern void Hide();

    [MethodImpl]
    public extern void SetDisplayStatus(
      DeviceInformation device,
      string status,
      DevicePickerDisplayStatusOptions options);
  }
}
