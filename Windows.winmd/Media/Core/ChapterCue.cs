// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ChapterCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChapterCue : IChapterCue, IMediaCue
  {
    [MethodImpl]
    public extern ChapterCue();

    public extern string Title { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
