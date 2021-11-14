// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductInfoHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpProductInfoHeaderValue))]
  [Guid(606212030, 60094, 17508, 180, 96, 236, 1, 11, 124, 65, 226)]
  internal interface IHttpProductInfoHeaderValueFactory
  {
    HttpProductInfoHeaderValue CreateFromComment(string productComment);

    HttpProductInfoHeaderValue CreateFromNameWithVersion(
      string productName,
      string productVersion);
  }
}
