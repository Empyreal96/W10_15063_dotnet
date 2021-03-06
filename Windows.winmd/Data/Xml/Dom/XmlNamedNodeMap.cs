// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlNamedNodeMap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class XmlNamedNodeMap : IXmlNamedNodeMap, IVectorView<IXmlNode>, IIterable<IXmlNode>
  {
    public extern uint Length { [MethodImpl] get; }

    [MethodImpl]
    public extern IXmlNode Item(uint index);

    [MethodImpl]
    public extern IXmlNode GetNamedItem(string name);

    [MethodImpl]
    public extern IXmlNode SetNamedItem(IXmlNode node);

    [MethodImpl]
    public extern IXmlNode RemoveNamedItem(string name);

    [MethodImpl]
    public extern IXmlNode GetNamedItemNS([Variant] object namespaceUri, string name);

    [MethodImpl]
    public extern IXmlNode RemoveNamedItemNS([Variant] object namespaceUri, string name);

    [MethodImpl]
    public extern IXmlNode SetNamedItemNS(IXmlNode node);

    [MethodImpl]
    public extern IXmlNode GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(IXmlNode value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] IXmlNode[] items);

    [MethodImpl]
    public extern IIterator<IXmlNode> First();
  }
}
