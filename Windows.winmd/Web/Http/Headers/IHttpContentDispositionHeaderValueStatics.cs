// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentDispositionHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(700801127, 23095, 18148, 176, 116, 197, 23, 125, 105, 202, 102)]
  [ExclusiveTo(typeof (HttpContentDispositionHeaderValue))]
  internal interface IHttpContentDispositionHeaderValueStatics
  {
    HttpContentDispositionHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpContentDispositionHeaderValue contentDispositionHeaderValue);
  }
}
