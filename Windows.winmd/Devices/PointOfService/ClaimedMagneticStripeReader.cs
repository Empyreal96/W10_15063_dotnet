// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedMagneticStripeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ClaimedMagneticStripeReader : IClaimedMagneticStripeReader, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; }

    public extern bool IsDisabledOnDataReceived { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsDecodeDataEnabled { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsDeviceAuthenticated { [MethodImpl] get; }

    public extern uint DataEncryptionAlgorithm { [MethodImpl] set; [MethodImpl] get; }

    public extern MagneticStripeReaderTrackIds TracksToRead { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsTransmitSentinelsEnabled { [MethodImpl] set; [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction EnableAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DisableAsync();

    [MethodImpl]
    public extern void RetainDevice();

    [MethodImpl]
    public extern void SetErrorReportingType(MagneticStripeReaderErrorReportingType value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> RetrieveDeviceAuthenticationDataAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AuthenticateDeviceAsync(byte[] responseToken);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeAuthenticateDeviceAsync(byte[] responseToken);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateKeyAsync(string key, string keyName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResetStatisticsAsync(
      IIterable<string> statisticsCategories);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    public extern event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderBankCardDataReceivedEventArgs> BankCardDataReceived;

    public extern event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderAamvaCardDataReceivedEventArgs> AamvaCardDataReceived;

    public extern event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs> VendorSpecificDataReceived;

    public extern event EventHandler<ClaimedMagneticStripeReader> ReleaseDeviceRequested;

    public extern event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderErrorOccurredEventArgs> ErrorOccurred;

    [MethodImpl]
    public extern void Close();
  }
}
