﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchSuggestionsRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  [ExclusiveTo(typeof (SearchSuggestionsRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1313744551, 17637, 16441, 144, 153, 96, 0, 234, 209, 240, 198)]
  internal interface ISearchSuggestionsRequest
  {
    bool IsCanceled { get; }

    SearchSuggestionCollection SearchSuggestionCollection { get; }

    SearchSuggestionsRequestDeferral GetDeferral();
  }
}
