// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Guid(4166534757, 25844, 17568, 172, 13, 70, 141, 43, 143, 218, 131)]
  [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayToSourceRequest))]
  internal interface IPlayToSourceRequest
  {
    DateTime Deadline { [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void DisplayErrorString(string errorString);

    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    PlayToSourceDeferral GetDeferral();

    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void SetSource(PlayToSource value);
  }
}
