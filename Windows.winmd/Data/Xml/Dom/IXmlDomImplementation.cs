// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDomImplementation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlDomImplementation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1843757362, 61725, 20411, 140, 198, 88, 60, 186, 147, 17, 47)]
  internal interface IXmlDomImplementation
  {
    bool HasFeature(string feature, [Variant] object version);
  }
}
