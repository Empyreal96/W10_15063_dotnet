// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePickerFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DevicePickerFilter))]
  [Guid(2447086242, 22475, 18673, 155, 89, 165, 155, 122, 31, 2, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDevicePickerFilter
  {
    IVector<DeviceClass> SupportedDeviceClasses { get; }

    IVector<string> SupportedDeviceSelectors { get; }
  }
}
