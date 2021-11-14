// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationCategoryFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(2873262127, 18912, 17701, 138, 178, 171, 69, 192, 37, 40, 255)]
  [ExclusiveTo(typeof (SyndicationCategory))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationCategoryFactory
  {
    SyndicationCategory CreateSyndicationCategory(string term);

    SyndicationCategory CreateSyndicationCategoryEx(
      string term,
      string scheme,
      string label);
  }
}
