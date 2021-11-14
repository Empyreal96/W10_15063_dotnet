// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextRegion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.Core
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimedTextRegion : ITimedTextRegion
  {
    [MethodImpl]
    public extern TimedTextRegion();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextPoint Position { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextSize Extent { [MethodImpl] get; [MethodImpl] set; }

    public extern Color Background { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextWritingMode WritingMode { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextDisplayAlignment DisplayAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextDouble LineHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOverflowClipped { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextPadding Padding { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextScrollMode ScrollMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
