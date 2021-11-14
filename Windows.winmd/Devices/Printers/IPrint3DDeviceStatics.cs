// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IPrint3DDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ExclusiveTo(typeof (Print3DDevice))]
  [Guid(4259537418, 26573, 16823, 163, 68, 81, 80, 161, 253, 117, 181)]
  [ContractVersion(typeof (PrintersContract), 65536)]
  internal interface IPrint3DDeviceStatics
  {
    [RemoteAsync]
    IAsyncOperation<Print3DDevice> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
