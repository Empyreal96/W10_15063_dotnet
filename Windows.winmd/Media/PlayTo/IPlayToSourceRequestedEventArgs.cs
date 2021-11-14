// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayToSourceRequestedEventArgs))]
  [Deprecated("PlayToSourceRequestedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(3318596400, 10719, 20166, 157, 169, 159, 189, 252, 252, 27, 62)]
  internal interface IPlayToSourceRequestedEventArgs
  {
    PlayToSourceRequest SourceRequest { [Deprecated("PlayToSourceRequestedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
