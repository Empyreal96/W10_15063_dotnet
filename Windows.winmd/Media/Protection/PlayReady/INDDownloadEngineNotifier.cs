// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDDownloadEngineNotifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(3609244884, 62648, 17712, 168, 9, 145, 147, 165, 113, 231, 252)]
  public interface INDDownloadEngineNotifier
  {
    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnStreamOpened();

    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnPlayReadyObjectReceived(byte[] dataBytes);

    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnContentIDReceived(INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnDataReceived(byte[] dataBytes, uint bytesReceived);

    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnEndOfStream();

    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnNetworkError();
  }
}
