// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakSeekedOverEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaBreakSeekedOverEventArgs : IMediaBreakSeekedOverEventArgs
  {
    public extern IVectorView<MediaBreak> SeekedOverBreaks { [MethodImpl] get; }

    public extern TimeSpan OldPosition { [MethodImpl] get; }

    public extern TimeSpan NewPosition { [MethodImpl] get; }
  }
}
