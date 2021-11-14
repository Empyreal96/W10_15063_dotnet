// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpCookieFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpCookie))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1778746793, 37660, 19665, 169, 109, 194, 23, 1, 120, 92, 95)]
  internal interface IHttpCookieFactory
  {
    HttpCookie Create(string name, string domain, string path);
  }
}
