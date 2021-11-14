// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlProcessingInstruction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlProcessingInstruction))]
  [Guid(654834974, 7826, 20174, 182, 244, 38, 240, 105, 7, 141, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlProcessingInstruction : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string Target { get; }

    string Data { get; set; }
  }
}
