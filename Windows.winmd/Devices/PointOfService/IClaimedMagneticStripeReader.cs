// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedMagneticStripeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedMagneticStripeReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1197254899, 37911, 18620, 185, 215, 65, 99, 167, 132, 76, 2)]
  internal interface IClaimedMagneticStripeReader : IClosable
  {
    string DeviceId { get; }

    bool IsEnabled { get; }

    bool IsDisabledOnDataReceived { set; get; }

    bool IsDecodeDataEnabled { set; get; }

    bool IsDeviceAuthenticated { get; }

    uint DataEncryptionAlgorithm { set; get; }

    MagneticStripeReaderTrackIds TracksToRead { set; get; }

    bool IsTransmitSentinelsEnabled { set; get; }

    [RemoteAsync]
    IAsyncAction EnableAsync();

    [RemoteAsync]
    IAsyncAction DisableAsync();

    void RetainDevice();

    void SetErrorReportingType(MagneticStripeReaderErrorReportingType value);

    [RemoteAsync]
    IAsyncOperation<IBuffer> RetrieveDeviceAuthenticationDataAsync();

    [RemoteAsync]
    IAsyncAction AuthenticateDeviceAsync(byte[] responseToken);

    [RemoteAsync]
    IAsyncAction DeAuthenticateDeviceAsync(byte[] responseToken);

    [RemoteAsync]
    IAsyncAction UpdateKeyAsync(string key, string keyName);

    [RemoteAsync]
    IAsyncAction ResetStatisticsAsync(IIterable<string> statisticsCategories);

    [RemoteAsync]
    IAsyncAction UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderBankCardDataReceivedEventArgs> BankCardDataReceived;

    event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderAamvaCardDataReceivedEventArgs> AamvaCardDataReceived;

    event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs> VendorSpecificDataReceived;

    event EventHandler<ClaimedMagneticStripeReader> ReleaseDeviceRequested;

    event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderErrorOccurredEventArgs> ErrorOccurred;
  }
}
