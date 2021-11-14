// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxQueryChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SearchBoxQueryChangedEventArgs))]
  [WebHostHidden]
  [Guid(2846297999, 3248, 19410, 153, 152, 47, 181, 122, 213, 231, 49)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISearchBoxQueryChangedEventArgs
  {
    string QueryText { get; }

    string Language { get; }

    SearchQueryLinguisticDetails LinguisticDetails { get; }
  }
}
