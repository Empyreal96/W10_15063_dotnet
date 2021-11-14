// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceAccessChangedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(2186424930, 37707, 19248, 161, 120, 173, 195, 159, 47, 43, 227)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (DeviceAccessChangedEventArgs))]
  internal interface IDeviceAccessChangedEventArgs2 : IDeviceAccessChangedEventArgs
  {
    string Id { get; }
  }
}
