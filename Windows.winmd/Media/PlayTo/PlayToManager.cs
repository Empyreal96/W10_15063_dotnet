// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlayToManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayToManager : IPlayToManager
  {
    public extern event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> SourceRequested;

    public extern event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> SourceSelected;

    public extern bool DefaultSourceSelection { [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern PlayToManager GetForCurrentView();

    [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void ShowPlayToUI();
  }
}
