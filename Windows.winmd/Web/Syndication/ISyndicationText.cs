// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationText
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3117178496, 12602, 16529, 162, 166, 36, 62, 14, 233, 35, 249)]
  public interface ISyndicationText : ISyndicationNode
  {
    string Text { get; set; }

    string Type { get; set; }

    XmlDocument Xml { get; set; }
  }
}
