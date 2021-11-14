// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlText
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Guid(4180780235, 12429, 18272, 161, 213, 67, 182, 116, 80, 172, 126)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IXmlText : IXmlCharacterData, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    IXmlText SplitText(uint offset);
  }
}
