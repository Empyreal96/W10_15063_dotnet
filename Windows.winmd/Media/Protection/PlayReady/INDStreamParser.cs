// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDStreamParser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3770327448, 38806, 16841, 134, 149, 89, 67, 126, 103, 230, 106)]
  public interface INDStreamParser
  {
    [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void ParseData(byte[] dataBytes);

    [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    uint GetStreamInformation(IMediaStreamDescriptor descriptor, out NDMediaStreamType streamType);

    [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void BeginOfStream();

    [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void EndOfStream();

    NDStreamParserNotifier Notifier { [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
