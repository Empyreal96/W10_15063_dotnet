// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDClientFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(1045683554, 65256, 17695, 176, 212, 247, 6, 204, 163, 224, 55)]
  [Deprecated("INDClientFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NDClient))]
  internal interface INDClientFactory
  {
    [Deprecated("INDClientFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    NDClient CreateInstance(
      INDDownloadEngine downloadEngine,
      INDStreamParser streamParser,
      INDMessenger pMessenger);
  }
}
