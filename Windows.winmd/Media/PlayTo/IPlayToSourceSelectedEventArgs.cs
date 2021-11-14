// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceSelectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.PlayTo
{
  [Guid(211649809, 20994, 19915, 140, 103, 171, 218, 18, 187, 60, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayToSourceSelectedEventArgs))]
  [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IPlayToSourceSelectedEventArgs
  {
    string FriendlyName { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    IRandomAccessStreamWithContentType Icon { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    bool SupportsImage { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    bool SupportsAudio { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    bool SupportsVideo { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
