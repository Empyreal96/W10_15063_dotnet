// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedMetadataTrackError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class TimedMetadataTrackError : ITimedMetadataTrackError
  {
    public extern TimedMetadataTrackErrorCode ErrorCode { [MethodImpl] get; }

    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
