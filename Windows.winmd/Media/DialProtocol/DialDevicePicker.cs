// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialDevicePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Media.DialProtocol
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DialDevicePicker : IDialDevicePicker
  {
    [MethodImpl]
    public extern DialDevicePicker();

    public extern DialDevicePickerFilter Filter { [MethodImpl] get; }

    public extern DevicePickerAppearance Appearance { [MethodImpl] get; }

    public extern event TypedEventHandler<DialDevicePicker, DialDeviceSelectedEventArgs> DialDeviceSelected;

    public extern event TypedEventHandler<DialDevicePicker, DialDisconnectButtonClickedEventArgs> DisconnectButtonClicked;

    public extern event TypedEventHandler<DialDevicePicker, object> DialDevicePickerDismissed;

    [Overload("Show")]
    [MethodImpl]
    public extern void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    [MethodImpl]
    public extern void Show(Rect selection, Placement preferredPlacement);

    [Overload("PickSingleDialDeviceAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DialDevice> PickSingleDialDeviceAsync(
      Rect selection);

    [Overload("PickSingleDialDeviceAsyncWithPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<DialDevice> PickSingleDialDeviceAsync(
      Rect selection,
      Placement preferredPlacement);

    [MethodImpl]
    public extern void Hide();

    [MethodImpl]
    public extern void SetDisplayStatus(DialDevice device, DialDeviceDisplayStatus status);
  }
}
