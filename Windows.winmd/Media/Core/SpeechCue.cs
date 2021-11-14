// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.SpeechCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class SpeechCue : ISpeechCue, IMediaCue
  {
    [MethodImpl]
    public extern SpeechCue();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> StartPositionInInput { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> EndPositionInInput { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
