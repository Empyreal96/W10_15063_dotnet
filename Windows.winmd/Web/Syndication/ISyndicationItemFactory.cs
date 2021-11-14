// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(622674767, 32184, 18554, 133, 228, 16, 209, 145, 230, 110, 187)]
  [ExclusiveTo(typeof (SyndicationItem))]
  internal interface ISyndicationItemFactory
  {
    SyndicationItem CreateSyndicationItem(
      string title,
      SyndicationContent content,
      Uri uri);
  }
}
