// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDLicenseFetchResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("INDLicenseFetchResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(567514776, 43618, 17919, 165, 255, 128, 55, 229, 67, 56, 37)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDLicenseFetchResult
  {
    INDCustomData ResponseCustomData { [Deprecated("INDLicenseFetchResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
