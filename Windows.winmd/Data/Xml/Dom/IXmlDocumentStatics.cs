// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Data.Xml.Dom
{
  [Guid(1430508116, 55127, 19321, 149, 57, 35, 43, 24, 245, 11, 241)]
  [ExclusiveTo(typeof (XmlDocument))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlDocumentStatics
  {
    [Overload("LoadFromUriAsync")]
    [RemoteAsync]
    IAsyncOperation<XmlDocument> LoadFromUriAsync(Uri uri);

    [Overload("LoadFromUriWithSettingsAsync")]
    [RemoteAsync]
    IAsyncOperation<XmlDocument> LoadFromUriAsync(
      Uri uri,
      XmlLoadSettings loadSettings);

    [Overload("LoadFromFileAsync")]
    [RemoteAsync]
    IAsyncOperation<XmlDocument> LoadFromFileAsync(IStorageFile file);

    [RemoteAsync]
    [Overload("LoadFromFileWithSettingsAsync")]
    IAsyncOperation<XmlDocument> LoadFromFileAsync(
      IStorageFile file,
      XmlLoadSettings loadSettings);
  }
}
