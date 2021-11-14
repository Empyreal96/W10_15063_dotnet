// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentIO
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XmlDocument))]
  [Guid(1825630030, 61029, 17545, 158, 191, 202, 67, 232, 123, 166, 55)]
  internal interface IXmlDocumentIO
  {
    [Overload("LoadXml")]
    void LoadXml(string xml);

    [Overload("LoadXmlWithSettings")]
    void LoadXml(string xml, XmlLoadSettings loadSettings);

    [RemoteAsync]
    IAsyncAction SaveToFileAsync(IStorageFile file);
  }
}
