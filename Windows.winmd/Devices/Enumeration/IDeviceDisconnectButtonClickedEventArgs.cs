// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceDisconnectButtonClickedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(2386867565, 63746, 18944, 181, 54, 243, 121, 146, 230, 162, 167)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceDisconnectButtonClickedEventArgs))]
  internal interface IDeviceDisconnectButtonClickedEventArgs
  {
    DeviceInformation Device { get; }
  }
}
