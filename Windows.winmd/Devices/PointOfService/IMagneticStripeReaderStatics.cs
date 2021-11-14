// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (MagneticStripeReader))]
  [Guid(3294604106, 61399, 18272, 165, 206, 21, 176, 228, 126, 148, 235)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagneticStripeReaderStatics
  {
    [RemoteAsync]
    IAsyncOperation<MagneticStripeReader> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<MagneticStripeReader> FromIdAsync(
      string deviceId);

    string GetDeviceSelector();
  }
}
