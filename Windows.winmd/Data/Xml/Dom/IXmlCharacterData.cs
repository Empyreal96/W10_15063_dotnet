// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlCharacterData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Guid(321798827, 20022, 19958, 177, 200, 12, 230, 47, 216, 139, 38)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IXmlCharacterData : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string Data { get; set; }

    uint Length { get; }

    string SubstringData(uint offset, uint count);

    void AppendData(string data);

    void InsertData(uint offset, string data);

    void DeleteData(uint offset, uint count);

    void ReplaceData(uint offset, uint count, string data);
  }
}
