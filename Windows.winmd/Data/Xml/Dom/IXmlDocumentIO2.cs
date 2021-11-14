// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentIO2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlDocument))]
  [Guid(1560495713, 31704, 19157, 158, 191, 129, 230, 52, 114, 99, 177)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlDocumentIO2
  {
    [Overload("LoadXmlFromBuffer")]
    void LoadXmlFromBuffer(IBuffer buffer);

    [Overload("LoadXmlFromBufferWithSettings")]
    void LoadXmlFromBuffer(IBuffer buffer, XmlLoadSettings loadSettings);
  }
}
