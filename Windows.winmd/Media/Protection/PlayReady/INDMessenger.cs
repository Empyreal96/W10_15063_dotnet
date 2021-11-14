// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDMessenger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(3559782749, 42843, 18367, 130, 73, 188, 131, 130, 13, 163, 138)]
  [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDMessenger
  {
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<INDSendResult> SendRegistrationRequestAsync(
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);

    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<INDSendResult> SendProximityDetectionStartAsync(
      NDProximityDetectionType pdType,
      byte[] transmitterChannelBytes,
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);

    [RemoteAsync]
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<INDSendResult> SendProximityDetectionResponseAsync(
      NDProximityDetectionType pdType,
      byte[] transmitterChannelBytes,
      byte[] sessionIDBytes,
      byte[] responseDataBytes);

    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<INDSendResult> SendLicenseFetchRequestAsync(
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);
  }
}
