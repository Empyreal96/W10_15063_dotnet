// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4147389477, 38785, 18788, 142, 148, 155, 28, 109, 252, 155, 199)]
  [ExclusiveTo(typeof (XmlDocumentType))]
  internal interface IXmlDocumentType : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string Name { get; }

    XmlNamedNodeMap Entities { get; }

    XmlNamedNodeMap Notations { get; }
  }
}
