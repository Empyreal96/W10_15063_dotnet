// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationNode
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
  [Guid(1966927736, 20984, 17856, 169, 245, 241, 113, 157, 236, 63, 178)]
  public interface ISyndicationNode
  {
    string NodeName { get; set; }

    string NodeNamespace { get; set; }

    string NodeValue { get; set; }

    string Language { get; set; }

    Uri BaseUri { get; set; }

    IVector<SyndicationAttribute> AttributeExtensions { get; }

    IVector<ISyndicationNode> ElementExtensions { get; }

    XmlDocument GetXmlDocument(SyndicationFormat format);
  }
}
