// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNodeList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XmlNodeList))]
  [Guid(2355146103, 33700, 20161, 156, 84, 123, 164, 41, 225, 61, 166)]
  internal interface IXmlNodeList : IVectorView<IXmlNode>, IIterable<IXmlNode>
  {
    uint Length { get; }

    IXmlNode Item(uint index);
  }
}
