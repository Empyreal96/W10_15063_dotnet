// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationItem
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
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISyndicationItemFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SyndicationItem : ISyndicationItem, ISyndicationNode
  {
    [MethodImpl]
    public extern SyndicationItem(string title, SyndicationContent content, Uri uri);

    [MethodImpl]
    public extern SyndicationItem();

    public extern IVector<SyndicationPerson> Authors { [MethodImpl] get; }

    public extern IVector<SyndicationCategory> Categories { [MethodImpl] get; }

    public extern IVector<SyndicationPerson> Contributors { [MethodImpl] get; }

    public extern SyndicationContent Content { [MethodImpl] get; [MethodImpl] set; }

    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime LastUpdatedTime { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<SyndicationLink> Links { [MethodImpl] get; }

    public extern DateTime PublishedDate { [MethodImpl] get; [MethodImpl] set; }

    public extern ISyndicationText Rights { [MethodImpl] get; [MethodImpl] set; }

    public extern SyndicationFeed Source { [MethodImpl] get; [MethodImpl] set; }

    public extern ISyndicationText Summary { [MethodImpl] get; [MethodImpl] set; }

    public extern ISyndicationText Title { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri CommentsUri { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri EditUri { [MethodImpl] get; }

    public extern Uri EditMediaUri { [MethodImpl] get; }

    public extern string ETag { [MethodImpl] get; }

    public extern Uri ItemUri { [MethodImpl] get; }

    [MethodImpl]
    public extern void Load(string item);

    [MethodImpl]
    public extern void LoadFromXml(XmlDocument itemDocument);

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
