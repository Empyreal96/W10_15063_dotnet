// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationFeed
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(2147368146, 23398, 19810, 132, 3, 27, 193, 13, 145, 13, 107)]
  [ExclusiveTo(typeof (SyndicationFeed))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationFeed : ISyndicationNode
  {
    IVector<SyndicationPerson> Authors { get; }

    IVector<SyndicationCategory> Categories { get; }

    IVector<SyndicationPerson> Contributors { get; }

    SyndicationGenerator Generator { get; set; }

    Uri IconUri { get; set; }

    string Id { get; set; }

    IVector<SyndicationItem> Items { get; }

    DateTime LastUpdatedTime { get; set; }

    IVector<SyndicationLink> Links { get; }

    Uri ImageUri { get; set; }

    ISyndicationText Rights { get; set; }

    ISyndicationText Subtitle { get; set; }

    ISyndicationText Title { get; set; }

    Uri FirstUri { get; }

    Uri LastUri { get; }

    Uri NextUri { get; }

    Uri PreviousUri { get; }

    SyndicationFormat SourceFormat { get; }

    void Load(string feed);

    void LoadFromXml(XmlDocument feedDocument);
  }
}
