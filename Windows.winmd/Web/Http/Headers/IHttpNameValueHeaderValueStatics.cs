// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpNameValueHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpNameValueHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4292084495, 4400, 16722, 134, 89, 37, 105, 9, 169, 209, 21)]
  internal interface IHttpNameValueHeaderValueStatics
  {
    HttpNameValueHeaderValue Parse(string input);

    bool TryParse(string input, out HttpNameValueHeaderValue nameValueHeaderValue);
  }
}
