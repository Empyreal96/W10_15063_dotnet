// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDTCPMessenger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (INDTCPMessengerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("NDTCPMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class NDTCPMessenger : INDMessenger
  {
    [Deprecated("INDTCPMessengerFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern NDTCPMessenger(string remoteHostName, uint remoteHostPort);

    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<INDSendResult> SendRegistrationRequestAsync(
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);

    [RemoteAsync]
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<INDSendResult> SendProximityDetectionStartAsync(
      NDProximityDetectionType pdType,
      byte[] transmitterChannelBytes,
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);

    [RemoteAsync]
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<INDSendResult> SendProximityDetectionResponseAsync(
      NDProximityDetectionType pdType,
      byte[] transmitterChannelBytes,
      byte[] sessionIDBytes,
      byte[] responseDataBytes);

    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<INDSendResult> SendLicenseFetchRequestAsync(
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);
  }
}
