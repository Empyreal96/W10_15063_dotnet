// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4171156570, 39354, 19412, 150, 108, 241, 31, 164, 67, 209, 60)]
  [ExclusiveTo(typeof (SearchBox))]
  internal interface ISearchBox
  {
    bool SearchHistoryEnabled { get; set; }

    string SearchHistoryContext { get; set; }

    string PlaceholderText { get; set; }

    string QueryText { get; set; }

    bool FocusOnKeyboardInput { get; set; }

    bool ChooseSuggestionOnEnter { get; set; }

    event TypedEventHandler<SearchBox, SearchBoxQueryChangedEventArgs> QueryChanged;

    event TypedEventHandler<SearchBox, SearchBoxSuggestionsRequestedEventArgs> SuggestionsRequested;

    event TypedEventHandler<SearchBox, SearchBoxQuerySubmittedEventArgs> QuerySubmitted;

    event TypedEventHandler<SearchBox, SearchBoxResultSuggestionChosenEventArgs> ResultSuggestionChosen;

    event TypedEventHandler<SearchBox, RoutedEventArgs> PrepareForFocusOnKeyboardInput;

    void SetLocalContentSuggestionSettings(LocalContentSuggestionSettings settings);
  }
}
