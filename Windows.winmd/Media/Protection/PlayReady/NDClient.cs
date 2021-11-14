// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("NDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (INDClientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class NDClient : INDClient
  {
    [Deprecated("INDClientFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern NDClient(
      INDDownloadEngine downloadEngine,
      INDStreamParser streamParser,
      INDMessenger pMessenger);

    public extern event TypedEventHandler<NDClient, INDRegistrationCompletedEventArgs> RegistrationCompleted;

    public extern event TypedEventHandler<NDClient, INDProximityDetectionCompletedEventArgs> ProximityDetectionCompleted;

    public extern event TypedEventHandler<NDClient, INDLicenseFetchCompletedEventArgs> LicenseFetchCompleted;

    public extern event TypedEventHandler<NDClient, object> ReRegistrationNeeded;

    public extern event TypedEventHandler<NDClient, INDClosedCaptionDataReceivedEventArgs> ClosedCaptionDataReceived;

    [RemoteAsync]
    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<INDStartResult> StartAsync(
      Uri contentUrl,
      uint startAsyncOptions,
      INDCustomData registrationCustomData,
      INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<INDLicenseFetchResult> LicenseFetchAsync(
      INDLicenseFetchDescriptor licenseFetchDescriptor);

    [RemoteAsync]
    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction ReRegistrationAsync(INDCustomData registrationCustomData);

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Close();
  }
}
