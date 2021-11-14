// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationFeed
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISyndicationFeedFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SyndicationFeed : ISyndicationFeed, ISyndicationNode
  {
    [MethodImpl]
    public extern SyndicationFeed(string title, string subtitle, Uri uri);

    [MethodImpl]
    public extern SyndicationFeed();

    public extern IVector<SyndicationPerson> Authors { [MethodImpl] get; }

    public extern IVector<SyndicationCategory> Categories { [MethodImpl] get; }

    public extern IVector<SyndicationPerson> Contributors { [MethodImpl] get; }

    public extern SyndicationGenerator Generator { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri IconUri { [MethodImpl] get; [MethodImpl] set; }

    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<SyndicationItem> Items { [MethodImpl] get; }

    public extern DateTime LastUpdatedTime { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<SyndicationLink> Links { [MethodImpl] get; }

    public extern Uri ImageUri { [MethodImpl] get; [MethodImpl] set; }

    public extern ISyndicationText Rights { [MethodImpl] get; [MethodImpl] set; }

    public extern ISyndicationText Subtitle { [MethodImpl] get; [MethodImpl] set; }

    public extern ISyndicationText Title { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri FirstUri { [MethodImpl] get; }

    public extern Uri LastUri { [MethodImpl] get; }

    public extern Uri NextUri { [MethodImpl] get; }

    public extern Uri PreviousUri { [MethodImpl] get; }

    public extern SyndicationFormat SourceFormat { [MethodImpl] get; }

    [MethodImpl]
    public extern void Load(string feed);

    [MethodImpl]
    public extern void LoadFromXml(XmlDocument feedDocument);

    public extern string NodeName { [MethodImpl] get; [MethodImpl] set; }

    public extern string NodeNamespace { [MethodImpl] get; [MethodImpl] set; }

    public extern string NodeValue { [MethodImpl] get; [MethodImpl] set; }

    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri BaseUri { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<SyndicationAttribute> AttributeExtensions { [MethodImpl] get; }

    public extern IVector<ISyndicationNode> ElementExtensions { [MethodImpl] get; }

    [MethodImpl]
    public extern XmlDocument GetXmlDocument(SyndicationFormat format);
  }
}
