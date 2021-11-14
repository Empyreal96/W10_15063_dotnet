// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Xsl.IXsltProcessor2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Xsl
{
  [Guid(2376358998, 38821, 17611, 168, 190, 39, 216, 98, 128, 199, 10)]
  [ExclusiveTo(typeof (XsltProcessor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXsltProcessor2
  {
    XmlDocument TransformToDocument(IXmlNode inputNode);
  }
}
