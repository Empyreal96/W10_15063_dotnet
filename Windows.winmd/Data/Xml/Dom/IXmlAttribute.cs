// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlAttribute))]
  [Guid(2887010980, 46321, 19894, 178, 6, 138, 34, 195, 8, 219, 10)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlAttribute : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string Name { get; }

    bool Specified { get; }

    string Value { get; set; }
  }
}
