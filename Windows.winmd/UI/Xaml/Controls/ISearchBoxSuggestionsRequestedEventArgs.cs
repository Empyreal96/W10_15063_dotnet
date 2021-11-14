// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxSuggestionsRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SearchBoxSuggestionsRequestedEventArgs))]
  [Guid(3658815246, 58726, 18635, 189, 17, 254, 75, 15, 48, 164, 77)]
  internal interface ISearchBoxSuggestionsRequestedEventArgs
  {
    string QueryText { get; }

    string Language { get; }

    SearchQueryLinguisticDetails LinguisticDetails { get; }

    SearchSuggestionsRequest Request { get; }
  }
}
