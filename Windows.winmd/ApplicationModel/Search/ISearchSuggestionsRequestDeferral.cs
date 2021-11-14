// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchSuggestionsRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3071645865, 49253, 17773, 168, 69, 30, 204, 236, 93, 194, 139)]
  [ExclusiveTo(typeof (SearchSuggestionsRequestDeferral))]
  internal interface ISearchSuggestionsRequestDeferral
  {
    void Complete();
  }
}
