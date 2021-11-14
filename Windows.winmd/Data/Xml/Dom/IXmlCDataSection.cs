// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlCDataSection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlCDataSection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1292153967, 51389, 17844, 136, 153, 4, 0, 215, 194, 198, 15)]
  internal interface IXmlCDataSection : 
    IXmlText,
    IXmlCharacterData,
    IXmlNode,
    IXmlNodeSelector,
    IXmlNodeSerializer
  {
  }
}
