// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlDocument))]
  [Guid(4159939846, 7815, 17110, 188, 251, 184, 200, 9, 250, 84, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlDocument : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    XmlDocumentType Doctype { get; }

    XmlDomImplementation Implementation { get; }

    XmlElement DocumentElement { get; }

    XmlElement CreateElement(string tagName);

    XmlDocumentFragment CreateDocumentFragment();

    XmlText CreateTextNode(string data);

    XmlComment CreateComment(string data);

    XmlProcessingInstruction CreateProcessingInstruction(
      string target,
      string data);

    XmlAttribute CreateAttribute(string name);

    XmlEntityReference CreateEntityReference(string name);

    XmlNodeList GetElementsByTagName(string tagName);

    XmlCDataSection CreateCDataSection(string data);

    string DocumentUri { get; }

    XmlAttribute CreateAttributeNS([Variant] object namespaceUri, string qualifiedName);

    XmlElement CreateElementNS([Variant] object namespaceUri, string qualifiedName);

    XmlElement GetElementById(string elementId);

    IXmlNode ImportNode(IXmlNode node, bool deep);
  }
}
