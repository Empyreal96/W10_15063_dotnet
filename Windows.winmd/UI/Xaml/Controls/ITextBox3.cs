// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2112982076, 10278, 16990, 154, 148, 0, 183, 247, 63, 55, 86)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextBox))]
  [WebHostHidden]
  internal interface ITextBox3
  {
    event TypedEventHandler<TextBox, TextCompositionStartedEventArgs> TextCompositionStarted;

    event TypedEventHandler<TextBox, TextCompositionChangedEventArgs> TextCompositionChanged;

    event TypedEventHandler<TextBox, TextCompositionEndedEventArgs> TextCompositionEnded;

    TextReadingOrder TextReadingOrder { get; set; }

    CandidateWindowAlignment DesiredCandidateWindowAlignment { get; set; }

    event TypedEventHandler<TextBox, CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged;

    event TypedEventHandler<TextBox, TextBoxTextChangingEventArgs> TextChanging;
  }
}
