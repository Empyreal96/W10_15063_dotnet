// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationLink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(659897021, 41230, 16821, 134, 189, 151, 89, 8, 110, 176, 197)]
  [ExclusiveTo(typeof (SyndicationLink))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationLink : ISyndicationNode
  {
    uint Length { get; set; }

    string MediaType { get; set; }

    string Relationship { get; set; }

    string Title { get; set; }

    Uri Uri { get; set; }

    string ResourceLanguage { get; set; }
  }
}
