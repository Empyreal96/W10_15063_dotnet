// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SearchBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ISearchBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISearchBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class SearchBox : Control, ISearchBox
  {
    [MethodImpl]
    public extern SearchBox();

    public extern bool SearchHistoryEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string SearchHistoryContext { [MethodImpl] get; [MethodImpl] set; }

    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    public extern string QueryText { [MethodImpl] get; [MethodImpl] set; }

    public extern bool FocusOnKeyboardInput { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ChooseSuggestionOnEnter { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<SearchBox, SearchBoxQueryChangedEventArgs> QueryChanged;

    public extern event TypedEventHandler<SearchBox, SearchBoxSuggestionsRequestedEventArgs> SuggestionsRequested;

    public extern event TypedEventHandler<SearchBox, SearchBoxQuerySubmittedEventArgs> QuerySubmitted;

    public extern event TypedEventHandler<SearchBox, SearchBoxResultSuggestionChosenEventArgs> ResultSuggestionChosen;

    public extern event TypedEventHandler<SearchBox, RoutedEventArgs> PrepareForFocusOnKeyboardInput;

    [MethodImpl]
    public extern void SetLocalContentSuggestionSettings(LocalContentSuggestionSettings settings);

    public static extern DependencyProperty SearchHistoryEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty SearchHistoryContextProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty QueryTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusOnKeyboardInputProperty { [MethodImpl] get; }

    public static extern DependencyProperty ChooseSuggestionOnEnterProperty { [MethodImpl] get; }
  }
}
