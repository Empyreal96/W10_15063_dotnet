// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductInfoHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3682588759, 12922, 20083, 129, 229, 112, 89, 163, 2, 176, 66)]
  [ExclusiveTo(typeof (HttpProductInfoHeaderValue))]
  internal interface IHttpProductInfoHeaderValueStatics
  {
    HttpProductInfoHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpProductInfoHeaderValue productInfoHeaderValue);
  }
}
