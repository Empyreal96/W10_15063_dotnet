// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDevicePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CastingDevicePicker))]
  [Guid(3704854820, 1425, 18878, 170, 203, 75, 130, 238, 117, 106, 149)]
  internal interface ICastingDevicePicker
  {
    CastingDevicePickerFilter Filter { get; }

    DevicePickerAppearance Appearance { get; }

    event TypedEventHandler<CastingDevicePicker, CastingDeviceSelectedEventArgs> CastingDeviceSelected;

    event TypedEventHandler<CastingDevicePicker, object> CastingDevicePickerDismissed;

    [Overload("Show")]
    void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    void Show(Rect selection, Placement preferredPlacement);

    void Hide();
  }
}
