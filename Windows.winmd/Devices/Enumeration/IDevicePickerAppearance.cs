// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePickerAppearance
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Enumeration
{
  [Guid(3868857030, 58919, 20184, 155, 108, 70, 10, 244, 69, 229, 109)]
  [ExclusiveTo(typeof (DevicePickerAppearance))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDevicePickerAppearance
  {
    string Title { get; set; }

    Color ForegroundColor { get; set; }

    Color BackgroundColor { get; set; }

    Color AccentColor { get; set; }

    Color SelectedForegroundColor { get; set; }

    Color SelectedBackgroundColor { get; set; }

    Color SelectedAccentColor { get; set; }
  }
}
