﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Threading(ThreadingModel.Both)]
  [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlayToConnectionTransferredEventArgs : IPlayToConnectionTransferredEventArgs
  {
    public extern PlayToSource PreviousSource { [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern PlayToSource CurrentSource { [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
