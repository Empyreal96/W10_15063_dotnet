// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Xsl.IXsltProcessorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Xsl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(658589376, 39505, 18019, 191, 48, 14, 247, 66, 20, 111, 32)]
  [ExclusiveTo(typeof (XsltProcessor))]
  internal interface IXsltProcessorFactory
  {
    XsltProcessor CreateInstance(XmlDocument document);
  }
}
