// Decompiled with JetBrains decompiler
// Type: Windows.Data.Html.IHtmlUtilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Html
{
  [WebHostHidden]
  [ExclusiveTo(typeof (HtmlUtilities))]
  [Guid(4273998557, 9113, 20396, 181, 167, 5, 233, 172, 215, 24, 29)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHtmlUtilities
  {
    string ConvertToText(string html);
  }
}
