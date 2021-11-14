// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNodeSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Guid(1675344523, 53467, 20449, 183, 69, 249, 67, 58, 253, 194, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IXmlNodeSelector
  {
    IXmlNode SelectSingleNode(string xpath);

    XmlNodeList SelectNodes(string xpath);

    IXmlNode SelectSingleNodeNS(string xpath, [Variant] object namespaces);

    XmlNodeList SelectNodesNS(string xpath, [Variant] object namespaces);
  }
}
