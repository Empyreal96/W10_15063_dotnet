// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PlayToSourceDeferral may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PlayToSourceDeferral))]
  [Guid(1090554141, 10126, 20265, 133, 155, 169, 229, 1, 5, 62, 125)]
  internal interface IPlayToSourceDeferral
  {
    [Deprecated("PlayToSourceDeferral may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void Complete();
  }
}
