// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextRegion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedTextRegion))]
  [Guid(516982815, 35334, 16930, 159, 89, 178, 27, 244, 1, 36, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedTextRegion
  {
    string Name { get; set; }

    TimedTextPoint Position { get; set; }

    TimedTextSize Extent { get; set; }

    Color Background { get; set; }

    TimedTextWritingMode WritingMode { get; set; }

    TimedTextDisplayAlignment DisplayAlignment { get; set; }

    TimedTextDouble LineHeight { get; set; }

    bool IsOverflowClipped { get; set; }

    TimedTextPadding Padding { get; set; }

    TimedTextWrapping TextWrapping { get; set; }

    int ZIndex { get; set; }

    TimedTextScrollMode ScrollMode { get; set; }
  }
}
