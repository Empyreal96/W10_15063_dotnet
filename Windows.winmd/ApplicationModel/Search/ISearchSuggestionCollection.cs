// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchSuggestionCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Search
{
  [Guid(842697291, 64490, 17478, 171, 188, 61, 167, 145, 95, 221, 58)]
  [ExclusiveTo(typeof (SearchSuggestionCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISearchSuggestionCollection
  {
    uint Size { get; }

    void AppendQuerySuggestion(string text);

    void AppendQuerySuggestions(IIterable<string> suggestions);

    void AppendResultSuggestion(
      string text,
      string detailText,
      string tag,
      IRandomAccessStreamReference image,
      string imageAlternateText);

    void AppendSearchSeparator(string label);
  }
}
