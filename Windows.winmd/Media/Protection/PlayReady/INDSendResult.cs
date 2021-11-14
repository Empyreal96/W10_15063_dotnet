// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDSendResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("INDSendResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(3815265559, 42372, 18333, 144, 183, 214, 137, 199, 191, 124, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDSendResult
  {
    byte[] Response { [Deprecated("INDSendResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
