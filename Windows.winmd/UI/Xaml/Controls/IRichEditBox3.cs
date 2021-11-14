// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1796711522, 64438, 20479, 153, 145, 147, 153, 203, 156, 11, 144)]
  [ExclusiveTo(typeof (RichEditBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IRichEditBox3
  {
    event TypedEventHandler<RichEditBox, TextCompositionStartedEventArgs> TextCompositionStarted;

    event TypedEventHandler<RichEditBox, TextCompositionChangedEventArgs> TextCompositionChanged;

    event TypedEventHandler<RichEditBox, TextCompositionEndedEventArgs> TextCompositionEnded;

    TextReadingOrder TextReadingOrder { get; set; }

    CandidateWindowAlignment DesiredCandidateWindowAlignment { get; set; }

    event TypedEventHandler<RichEditBox, CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged;

    event TypedEventHandler<RichEditBox, RichEditBoxTextChangingEventArgs> TextChanging;
  }
}
