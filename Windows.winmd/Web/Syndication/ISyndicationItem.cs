// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1418573955, 50052, 17857, 138, 232, 163, 120, 196, 236, 72, 108)]
  [ExclusiveTo(typeof (SyndicationItem))]
  internal interface ISyndicationItem : ISyndicationNode
  {
    IVector<SyndicationPerson> Authors { get; }

    IVector<SyndicationCategory> Categories { get; }

    IVector<SyndicationPerson> Contributors { get; }

    SyndicationContent Content { get; set; }

    string Id { get; set; }

    DateTime LastUpdatedTime { get; set; }

    IVector<SyndicationLink> Links { get; }

    DateTime PublishedDate { get; set; }

    ISyndicationText Rights { get; set; }

    SyndicationFeed Source { get; set; }

    ISyndicationText Summary { get; set; }

    ISyndicationText Title { get; set; }

    Uri CommentsUri { get; set; }

    Uri EditUri { get; }

    Uri EditMediaUri { get; }

    string ETag { get; }

    Uri ItemUri { get; }

    void Load(string item);

    void LoadFromXml(XmlDocument itemDocument);
  }
}
