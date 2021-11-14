// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAutoSuggestBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AutoSuggestBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(272538387, 13312, 18966, 144, 185, 105, 18, 191, 6, 151, 79)]
  internal interface IAutoSuggestBox
  {
    double MaxSuggestionListHeight { get; set; }

    bool IsSuggestionListOpen { get; set; }

    string TextMemberPath { get; set; }

    string Text { get; set; }

    bool UpdateTextOnSelect { get; set; }

    string PlaceholderText { get; set; }

    object Header { get; set; }

    bool AutoMaximizeSuggestionArea { get; set; }

    Style TextBoxStyle { get; set; }

    event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxSuggestionChosenEventArgs> SuggestionChosen;

    event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxTextChangedEventArgs> TextChanged;
  }
}
