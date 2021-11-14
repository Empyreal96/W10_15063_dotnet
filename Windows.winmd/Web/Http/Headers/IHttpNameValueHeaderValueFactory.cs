// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpNameValueHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1997415015, 52216, 18230, 169, 37, 147, 251, 225, 12, 124, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpNameValueHeaderValue))]
  internal interface IHttpNameValueHeaderValueFactory
  {
    HttpNameValueHeaderValue CreateFromName(string name);

    HttpNameValueHeaderValue CreateFromNameWithValue(
      string name,
      string value);
  }
}
