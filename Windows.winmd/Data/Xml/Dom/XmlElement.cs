// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class XmlElement : IXmlElement, IXmlNode, IXmlNodeSerializer, IXmlNodeSelector
  {
    public extern string TagName { [MethodImpl] get; }

    [MethodImpl]
    public extern string GetAttribute(string attributeName);

    [MethodImpl]
    public extern void SetAttribute(string attributeName, string attributeValue);

    [MethodImpl]
    public extern void RemoveAttribute(string attributeName);

    [MethodImpl]
    public extern XmlAttribute GetAttributeNode(string attributeName);

    [MethodImpl]
    public extern XmlAttribute SetAttributeNode(XmlAttribute newAttribute);

    [MethodImpl]
    public extern XmlAttribute RemoveAttributeNode(XmlAttribute attributeNode);

    [MethodImpl]
    public extern XmlNodeList GetElementsByTagName(string tagName);

    [MethodImpl]
    public extern void SetAttributeNS([Variant] object namespaceUri, string qualifiedName, string value);

    [MethodImpl]
    public extern string GetAttributeNS([Variant] object namespaceUri, string localName);

    [MethodImpl]
    public extern void RemoveAttributeNS([Variant] object namespaceUri, string localName);

    [MethodImpl]
    public extern XmlAttribute SetAttributeNodeNS(XmlAttribute newAttribute);

    [MethodImpl]
    public extern XmlAttribute GetAttributeNodeNS([Variant] object namespaceUri, string localName);

    public extern object NodeValue { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }

    public extern NodeType NodeType { [MethodImpl] get; }

    public extern string NodeName { [MethodImpl] get; }

    public extern IXmlNode ParentNode { [MethodImpl] get; }

    public extern XmlNodeList ChildNodes { [MethodImpl] get; }

    public extern IXmlNode FirstChild { [MethodImpl] get; }

    public extern IXmlNode LastChild { [MethodImpl] get; }

    public extern IXmlNode PreviousSibling { [MethodImpl] get; }

    public extern IXmlNode NextSibling { [MethodImpl] get; }

    public extern XmlNamedNodeMap Attributes { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasChildNodes();

    public extern XmlDocument OwnerDocument { [MethodImpl] get; }

    [MethodImpl]
    public extern IXmlNode InsertBefore(IXmlNode newChild, IXmlNode referenceChild);

    [MethodImpl]
    public extern IXmlNode ReplaceChild(IXmlNode newChild, IXmlNode referenceChild);

    [MethodImpl]
    public extern IXmlNode RemoveChild(IXmlNode childNode);

    [MethodImpl]
    public extern IXmlNode AppendChild(IXmlNode newChild);

    [MethodImpl]
    public extern IXmlNode CloneNode(bool deep);

    public extern object NamespaceUri { [MethodImpl] [return: Variant] get; }

    public extern object LocalName { [MethodImpl] [return: Variant] get; }

    public extern object Prefix { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }

    [MethodImpl]
    public extern void Normalize();

    [MethodImpl]
    public extern IXmlNode SelectSingleNode(string xpath);

    [MethodImpl]
    public extern XmlNodeList SelectNodes(string xpath);

    [MethodImpl]
    public extern IXmlNode SelectSingleNodeNS(string xpath, [Variant] object namespaces);

    [MethodImpl]
    public extern XmlNodeList SelectNodesNS(string xpath, [Variant] object namespaces);

    [MethodImpl]
    public extern string GetXml();

    public extern string InnerText { [MethodImpl] get; [MethodImpl] set; }
  }
}
