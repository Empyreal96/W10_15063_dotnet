// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2971886415, 26737, 18637, 146, 223, 76, 255, 34, 69, 144, 130)]
  [ExclusiveTo(typeof (SearchBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISearchBoxStatics
  {
    DependencyProperty SearchHistoryEnabledProperty { get; }

    DependencyProperty SearchHistoryContextProperty { get; }

    DependencyProperty PlaceholderTextProperty { get; }

    DependencyProperty QueryTextProperty { get; }

    DependencyProperty FocusOnKeyboardInputProperty { get; }

    DependencyProperty ChooseSuggestionOnEnterProperty { get; }
  }
}
