// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewFullscreenStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(3162058429, 25854, 19301, 160, 192, 144, 28, 226, 182, 134, 54)]
  [Deprecated("IApplicationViewFullscreenStatics is deprecated after Windows 8. Please use other resize APIs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationViewFullscreenStatics
  {
    [Deprecated("IApplicationViewFullscreenStatics is deprecated after Windows 8. Please use other resize APIs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    bool TryUnsnapToFullscreen();
  }
}
