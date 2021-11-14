// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Data.Xml.Dom
{
  [Muse(Version = 100794368)]
  [Static(typeof (IXmlDocumentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class XmlDocument : 
    IXmlDocument,
    IXmlNode,
    IXmlNodeSerializer,
    IXmlNodeSelector,
    IXmlDocumentIO,
    IXmlDocumentIO2
  {
    [MethodImpl]
    public extern XmlDocument();

    public extern XmlDocumentType Doctype { [MethodImpl] get; }

    public extern XmlDomImplementation Implementation { [MethodImpl] get; }

    public extern XmlElement DocumentElement { [MethodImpl] get; }

    [MethodImpl]
    public extern XmlElement CreateElement(string tagName);

    [MethodImpl]
    public extern XmlDocumentFragment CreateDocumentFragment();

    [MethodImpl]
    public extern XmlText CreateTextNode(string data);

    [MethodImpl]
    public extern XmlComment CreateComment(string data);

    [MethodImpl]
    public extern XmlProcessingInstruction CreateProcessingInstruction(
      string target,
      string data);

    [MethodImpl]
    public extern XmlAttribute CreateAttribute(string name);

    [MethodImpl]
    public extern XmlEntityReference CreateEntityReference(string name);

    [MethodImpl]
    public extern XmlNodeList GetElementsByTagName(string tagName);

    [MethodImpl]
    public extern XmlCDataSection CreateCDataSection(string data);

    public extern string DocumentUri { [MethodImpl] get; }

    [MethodImpl]
    public extern XmlAttribute CreateAttributeNS(
      [Variant] object namespaceUri,
      string qualifiedName);

    [MethodImpl]
    public extern XmlElement CreateElementNS([Variant] object namespaceUri, string qualifiedName);

    [MethodImpl]
    public extern XmlElement GetElementById(string elementId);

    [MethodImpl]
    public extern IXmlNode ImportNode(IXmlNode node, bool deep);

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

    [Overload("LoadXml")]
    [MethodImpl]
    public extern void LoadXml(string xml);

    [Overload("LoadXmlWithSettings")]
    [MethodImpl]
    public extern void LoadXml(string xml, XmlLoadSettings loadSettings);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveToFileAsync(IStorageFile file);

    [Overload("LoadXmlFromBuffer")]
    [MethodImpl]
    public extern void LoadXmlFromBuffer(IBuffer buffer);

    [Overload("LoadXmlFromBufferWithSettings")]
    [MethodImpl]
    public extern void LoadXmlFromBuffer(IBuffer buffer, XmlLoadSettings loadSettings);

    [Overload("LoadFromUriAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<XmlDocument> LoadFromUriAsync(
      Uri uri);

    [Overload("LoadFromUriWithSettingsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<XmlDocument> LoadFromUriAsync(
      Uri uri,
      XmlLoadSettings loadSettings);

    [RemoteAsync]
    [Overload("LoadFromFileAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<XmlDocument> LoadFromFileAsync(
      IStorageFile file);

    [RemoteAsync]
    [Overload("LoadFromFileWithSettingsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<XmlDocument> LoadFromFileAsync(
      IStorageFile file,
      XmlLoadSettings loadSettings);
  }
}
