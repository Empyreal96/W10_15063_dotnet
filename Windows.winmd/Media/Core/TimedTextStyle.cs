// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextStyle
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
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimedTextStyle : ITimedTextStyle, ITimedTextStyle2
  {
    [MethodImpl]
    public extern TimedTextStyle();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string FontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextDouble FontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern Color Foreground { [MethodImpl] get; [MethodImpl] set; }

    public extern Color Background { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsBackgroundAlwaysShown { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextFlowDirection FlowDirection { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextLineAlignment LineAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern Color OutlineColor { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextDouble OutlineThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextDouble OutlineRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextFontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsUnderlineEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsLineThroughEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOverlineEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
