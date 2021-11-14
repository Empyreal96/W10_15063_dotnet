// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchQueryLinguisticDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  [ExclusiveTo(typeof (SearchQueryLinguisticDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1184964699, 27081, 18245, 183, 47, 168, 164, 252, 143, 36, 174)]
  internal interface ISearchQueryLinguisticDetails
  {
    IVectorView<string> QueryTextAlternatives { get; }

    uint QueryTextCompositionStart { get; }

    uint QueryTextCompositionLength { get; }
  }
}
