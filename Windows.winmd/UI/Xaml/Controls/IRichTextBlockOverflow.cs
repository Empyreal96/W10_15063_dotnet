// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockOverflow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RichTextBlockOverflow))]
  [WebHostHidden]
  [Guid(1335063707, 56003, 19010, 156, 187, 153, 240, 222, 55, 192, 113)]
  internal interface IRichTextBlockOverflow
  {
    RichTextBlockOverflow OverflowContentTarget { get; set; }

    Thickness Padding { get; set; }

    RichTextBlock ContentSource { get; }

    bool HasOverflowContent { get; }

    TextPointer ContentStart { get; }

    TextPointer ContentEnd { get; }

    double BaselineOffset { get; }

    TextPointer GetPositionFromPoint(Point point);

    bool Focus(FocusState value);
  }
}
