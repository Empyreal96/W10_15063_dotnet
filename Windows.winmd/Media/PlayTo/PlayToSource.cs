// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Muse(Version = 100794368)]
  [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlayToSource : IPlayToSource, IPlayToSourceWithPreferredSourceUri
  {
    public extern PlayToConnection Connection { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern PlayToSource Next { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PlayNext();

    public extern Uri PreferredSourceUri { [Deprecated("PlayToSourceWithPreferredSourceUri may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PlayToSourceWithPreferredSourceUri may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }
  }
}
