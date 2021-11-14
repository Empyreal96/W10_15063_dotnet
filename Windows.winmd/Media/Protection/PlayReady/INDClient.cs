// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(1003911195, 25016, 18146, 153, 165, 138, 188, 182, 185, 247, 214)]
  [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NDClient))]
  internal interface INDClient
  {
    event TypedEventHandler<NDClient, INDRegistrationCompletedEventArgs> RegistrationCompleted;

    event TypedEventHandler<NDClient, INDProximityDetectionCompletedEventArgs> ProximityDetectionCompleted;

    event TypedEventHandler<NDClient, INDLicenseFetchCompletedEventArgs> LicenseFetchCompleted;

    event TypedEventHandler<NDClient, object> ReRegistrationNeeded;

    event TypedEventHandler<NDClient, INDClosedCaptionDataReceivedEventArgs> ClosedCaptionDataReceived;

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<INDStartResult> StartAsync(
      Uri contentUrl,
      uint startAsyncOptions,
      INDCustomData registrationCustomData,
      INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<INDLicenseFetchResult> LicenseFetchAsync(
      INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncAction ReRegistrationAsync(INDCustomData registrationCustomData);

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Close();
  }
}
