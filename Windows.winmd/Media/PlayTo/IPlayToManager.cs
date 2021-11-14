// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4117373038, 7031, 17135, 143, 13, 185, 73, 248, 217, 178, 96)]
  [ExclusiveTo(typeof (PlayToManager))]
  internal interface IPlayToManager
  {
    event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> SourceRequested;

    event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> SourceSelected;

    bool DefaultSourceSelection { [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
