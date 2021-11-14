// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceAccessChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(3738831820, 20381, 20312, 157, 186, 169, 188, 128, 4, 8, 213)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceAccessChangedEventArgs))]
  internal interface IDeviceAccessChangedEventArgs
  {
    DeviceAccessStatus Status { get; }
  }
}
