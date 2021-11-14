// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNamedNodeMap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XmlNamedNodeMap))]
  [Guid(3014041264, 43696, 19330, 166, 250, 177, 69, 63, 124, 2, 27)]
  internal interface IXmlNamedNodeMap : IVectorView<IXmlNode>, IIterable<IXmlNode>
  {
    uint Length { get; }

    IXmlNode Item(uint index);

    IXmlNode GetNamedItem(string name);

    IXmlNode SetNamedItem(IXmlNode node);

    IXmlNode RemoveNamedItem(string name);

    IXmlNode GetNamedItemNS([Variant] object namespaceUri, string name);

    IXmlNode RemoveNamedItemNS([Variant] object namespaceUri, string name);

    IXmlNode SetNamedItemNS(IXmlNode node);
  }
}
