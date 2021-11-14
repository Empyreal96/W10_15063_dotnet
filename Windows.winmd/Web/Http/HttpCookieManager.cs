// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpCookieManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpCookieManager : IHttpCookieManager
  {
    [Overload("SetCookie")]
    [MethodImpl]
    public extern bool SetCookie(HttpCookie cookie);

    [Overload("SetCookieWithThirdParty")]
    [MethodImpl]
    public extern bool SetCookie(HttpCookie cookie, bool thirdParty);

    [MethodImpl]
    public extern void DeleteCookie(HttpCookie cookie);

    [MethodImpl]
    public extern HttpCookieCollection GetCookies(Uri uri);
  }
}
