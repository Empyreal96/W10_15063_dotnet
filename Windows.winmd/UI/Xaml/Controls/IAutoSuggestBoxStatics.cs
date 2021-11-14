// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAutoSuggestBoxStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3995256820, 49501, 20467, 138, 148, 245, 13, 253, 251, 232, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutoSuggestBox))]
  [WebHostHidden]
  internal interface IAutoSuggestBoxStatics
  {
    DependencyProperty MaxSuggestionListHeightProperty { get; }

    DependencyProperty IsSuggestionListOpenProperty { get; }

    DependencyProperty TextMemberPathProperty { get; }

    DependencyProperty TextProperty { get; }

    DependencyProperty UpdateTextOnSelectProperty { get; }

    DependencyProperty PlaceholderTextProperty { get; }

    DependencyProperty HeaderProperty { get; }

    DependencyProperty AutoMaximizeSuggestionAreaProperty { get; }

    DependencyProperty TextBoxStyleProperty { get; }
  }
}
