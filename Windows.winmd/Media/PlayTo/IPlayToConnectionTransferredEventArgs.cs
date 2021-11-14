// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToConnectionTransferredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Guid(4209187130, 1667, 18393, 141, 240, 24, 203, 180, 137, 132, 216)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayToConnectionTransferredEventArgs))]
  [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IPlayToConnectionTransferredEventArgs
  {
    PlayToSource PreviousSource { [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    PlayToSource CurrentSource { [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
