// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlElement))]
  [Guid(771459615, 27408, 20216, 159, 131, 239, 204, 232, 250, 236, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlElement : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string TagName { get; }

    string GetAttribute(string attributeName);

    void SetAttribute(string attributeName, string attributeValue);

    void RemoveAttribute(string attributeName);

    XmlAttribute GetAttributeNode(string attributeName);

    XmlAttribute SetAttributeNode(XmlAttribute newAttribute);

    XmlAttribute RemoveAttributeNode(XmlAttribute attributeNode);

    XmlNodeList GetElementsByTagName(string tagName);

    void SetAttributeNS([Variant] object namespaceUri, string qualifiedName, string value);

    string GetAttributeNS([Variant] object namespaceUri, string localName);

    void RemoveAttributeNS([Variant] object namespaceUri, string localName);

    XmlAttribute SetAttributeNodeNS(XmlAttribute newAttribute);

    XmlAttribute GetAttributeNodeNS([Variant] object namespaceUri, string localName);
  }
}
