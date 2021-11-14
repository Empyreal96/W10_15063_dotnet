// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.SearchQueryLinguisticDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISearchQueryLinguisticDetailsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SearchQueryLinguisticDetails : ISearchQueryLinguisticDetails
  {
    [MethodImpl]
    public extern SearchQueryLinguisticDetails(
      IIterable<string> queryTextAlternatives,
      uint queryTextCompositionStart,
      uint queryTextCompositionLength);

    public extern IVectorView<string> QueryTextAlternatives { [MethodImpl] get; }

    public extern uint QueryTextCompositionStart { [MethodImpl] get; }

    public extern uint QueryTextCompositionLength { [MethodImpl] get; }
  }
}
