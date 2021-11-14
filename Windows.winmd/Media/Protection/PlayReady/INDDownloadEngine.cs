// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDDownloadEngine
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(757218661, 50358, 17464, 141, 70, 185, 110, 109, 15, 178, 31)]
  public interface INDDownloadEngine
  {
    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Open(Uri uri, byte[] sessionIDBytes);

    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Pause();

    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Resume();

    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Close();

    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Seek(TimeSpan startPosition);

    bool CanSeek { [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    uint BufferFullMinThresholdInSamples { [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    uint BufferFullMaxThresholdInSamples { [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    NDDownloadEngineNotifier Notifier { [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
