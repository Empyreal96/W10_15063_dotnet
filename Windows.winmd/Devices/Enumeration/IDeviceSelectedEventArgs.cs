// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceSelectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(647944926, 7471, 18752, 132, 2, 65, 86, 184, 29, 60, 119)]
  [ExclusiveTo(typeof (DeviceSelectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceSelectedEventArgs
  {
    DeviceInformation SelectedDevice { get; }
  }
}
