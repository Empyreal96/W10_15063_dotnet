// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextStyle
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.Core
{
  [Guid(464664653, 43045, 16578, 167, 245, 40, 30, 174, 223, 59, 85)]
  [ExclusiveTo(typeof (TimedTextStyle))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedTextStyle
  {
    string Name { get; set; }

    string FontFamily { get; set; }

    TimedTextDouble FontSize { get; set; }

    TimedTextWeight FontWeight { get; set; }

    Color Foreground { get; set; }

    Color Background { get; set; }

    bool IsBackgroundAlwaysShown { get; set; }

    TimedTextFlowDirection FlowDirection { get; set; }

    TimedTextLineAlignment LineAlignment { get; set; }

    Color OutlineColor { get; set; }

    TimedTextDouble OutlineThickness { get; set; }

    TimedTextDouble OutlineRadius { get; set; }
  }
}
