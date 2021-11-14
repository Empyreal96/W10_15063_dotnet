// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.SearchSuggestionCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100794368)]
  public sealed class SearchSuggestionCollection : ISearchSuggestionCollection
  {
    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern void AppendQuerySuggestion(string text);

    [MethodImpl]
    public extern void AppendQuerySuggestions(IIterable<string> suggestions);

    [MethodImpl]
    public extern void AppendResultSuggestion(
      string text,
      string detailText,
      string tag,
      IRandomAccessStreamReference image,
      string imageAlternateText);

    [MethodImpl]
    public extern void AppendSearchSeparator(string label);
  }
}
