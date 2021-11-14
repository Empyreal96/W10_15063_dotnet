// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingDevicePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CastingDevicePicker : ICastingDevicePicker
  {
    [MethodImpl]
    public extern CastingDevicePicker();

    public extern CastingDevicePickerFilter Filter { [MethodImpl] get; }

    public extern DevicePickerAppearance Appearance { [MethodImpl] get; }

    public extern event TypedEventHandler<CastingDevicePicker, CastingDeviceSelectedEventArgs> CastingDeviceSelected;

    public extern event TypedEventHandler<CastingDevicePicker, object> CastingDevicePickerDismissed;

    [Overload("Show")]
    [MethodImpl]
    public extern void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    [MethodImpl]
    public extern void Show(Rect selection, Placement preferredPlacement);

    [MethodImpl]
    public extern void Hide();
  }
}
