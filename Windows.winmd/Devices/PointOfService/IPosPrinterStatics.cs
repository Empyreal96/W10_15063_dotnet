// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (PosPrinter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2363544810, 4911, 19679, 166, 74, 45, 13, 124, 150, 168, 91)]
  internal interface IPosPrinterStatics
  {
    [RemoteAsync]
    IAsyncOperation<PosPrinter> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<PosPrinter> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
