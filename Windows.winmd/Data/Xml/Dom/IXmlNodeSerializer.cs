// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNodeSerializer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Guid(1556460418, 59101, 18833, 171, 239, 6, 216, 210, 231, 189, 12)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IXmlNodeSerializer
  {
    string GetXml();

    string InnerText { get; set; }
  }
}
