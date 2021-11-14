// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.ServiceDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class ServiceDocument : IServiceDocument, ISyndicationNode
  {
    public extern IVectorView<Workspace> Workspaces { [MethodImpl] get; }

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
