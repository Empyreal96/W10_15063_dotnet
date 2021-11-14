// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(477371737, 8482, 18389, 168, 86, 131, 243, 212, 33, 72, 117)]
  public interface IXmlNode : IXmlNodeSelector, IXmlNodeSerializer
  {
    object NodeValue { [return: Variant] get; [param: Variant] set; }

    NodeType NodeType { get; }

    string NodeName { get; }

    IXmlNode ParentNode { get; }

    XmlNodeList ChildNodes { get; }

    IXmlNode FirstChild { get; }

    IXmlNode LastChild { get; }

    IXmlNode PreviousSibling { get; }

    IXmlNode NextSibling { get; }

    XmlNamedNodeMap Attributes { get; }

    bool HasChildNodes();

    XmlDocument OwnerDocument { get; }

    IXmlNode InsertBefore(IXmlNode newChild, IXmlNode referenceChild);

    IXmlNode ReplaceChild(IXmlNode newChild, IXmlNode referenceChild);

    IXmlNode RemoveChild(IXmlNode childNode);

    IXmlNode AppendChild(IXmlNode newChild);

    IXmlNode CloneNode(bool deep);

    object NamespaceUri { [return: Variant] get; }

    object LocalName { [return: Variant] get; }

    object Prefix { [return: Variant] get; [param: Variant] set; }

    void Normalize();
  }
}
