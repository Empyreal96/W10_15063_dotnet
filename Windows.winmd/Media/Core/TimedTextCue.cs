// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TimedTextCue : ITimedTextCue, IMediaCue
  {
    [MethodImpl]
    public extern TimedTextCue();

    public extern TimedTextRegion CueRegion { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextStyle CueStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<TimedTextLine> Lines { [MethodImpl] get; }

    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
