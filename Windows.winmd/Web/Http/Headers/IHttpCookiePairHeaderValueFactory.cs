// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCookiePairHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpCookiePairHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1667117679, 5231, 20310, 170, 33, 44, 183, 214, 213, 139, 30)]
  internal interface IHttpCookiePairHeaderValueFactory
  {
    HttpCookiePairHeaderValue CreateFromName(string name);

    HttpCookiePairHeaderValue CreateFromNameWithValue(
      string name,
      string value);
  }
}
