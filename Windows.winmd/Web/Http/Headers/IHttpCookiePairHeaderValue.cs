// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCookiePairHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3419693591, 19241, 16683, 189, 144, 179, 216, 20, 171, 142, 27)]
  [ExclusiveTo(typeof (HttpCookiePairHeaderValue))]
  internal interface IHttpCookiePairHeaderValue
  {
    string Name { get; }

    string Value { get; set; }
  }
}
