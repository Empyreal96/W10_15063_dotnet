// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Xsl.IXsltProcessor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Xsl
{
  [ExclusiveTo(typeof (XsltProcessor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2070179903, 21772, 18630, 169, 15, 147, 165, 185, 100, 81, 143)]
  internal interface IXsltProcessor
  {
    string TransformToString(IXmlNode inputNode);
  }
}
