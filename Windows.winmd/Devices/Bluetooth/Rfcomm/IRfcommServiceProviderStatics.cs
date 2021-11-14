// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceProviderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RfcommServiceProvider))]
  [Guid(2559083267, 27082, 16698, 132, 247, 67, 68, 199, 41, 41, 151)]
  internal interface IRfcommServiceProviderStatics
  {
    [RemoteAsync]
    IAsyncOperation<RfcommServiceProvider> CreateAsync(
      RfcommServiceId serviceId);
  }
}
