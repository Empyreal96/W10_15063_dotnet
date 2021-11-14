// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpConnectionOptionHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2863095095, 43334, 19231, 133, 175, 72, 182, 139, 60, 80, 189)]
  [ExclusiveTo(typeof (HttpConnectionOptionHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpConnectionOptionHeaderValueStatics
  {
    HttpConnectionOptionHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpConnectionOptionHeaderValue connectionOptionHeaderValue);
  }
}
