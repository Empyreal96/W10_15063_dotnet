// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchPaneQueryLinguisticDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  [Guid(2197505550, 2368, 19309, 184, 208, 100, 43, 48, 152, 158, 21)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SearchPaneQueryLinguisticDetails))]
  internal interface ISearchPaneQueryLinguisticDetails
  {
    IVectorView<string> QueryTextAlternatives { get; }

    uint QueryTextCompositionStart { get; }

    uint QueryTextCompositionLength { get; }
  }
}
