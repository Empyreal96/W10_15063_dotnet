// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AutoSuggestBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IAutoSuggestBoxStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAutoSuggestBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutoSuggestBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AutoSuggestBox : 
    ItemsControl,
    IAutoSuggestBox,
    IAutoSuggestBox2,
    IAutoSuggestBox3
  {
    [MethodImpl]
    public extern AutoSuggestBox();

    public extern double MaxSuggestionListHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSuggestionListOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern string TextMemberPath { [MethodImpl] get; [MethodImpl] set; }

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern bool UpdateTextOnSelect { [MethodImpl] get; [MethodImpl] set; }

    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutoMaximizeSuggestionArea { [MethodImpl] get; [MethodImpl] set; }

    public extern Style TextBoxStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxSuggestionChosenEventArgs> SuggestionChosen;

    public extern event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxTextChangedEventArgs> TextChanged;

    public extern IconElement QueryIcon { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxQuerySubmittedEventArgs> QuerySubmitted;

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty QueryIconProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxSuggestionListHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSuggestionListOpenProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextMemberPathProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    public static extern DependencyProperty UpdateTextOnSelectProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty AutoMaximizeSuggestionAreaProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextBoxStyleProperty { [MethodImpl] get; }
  }
}
