// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpDateOrDeltaHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2082888104, 26226, 20112, 154, 154, 243, 151, 102, 247, 245, 118)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpDateOrDeltaHeaderValue))]
  internal interface IHttpDateOrDeltaHeaderValueStatics
  {
    HttpDateOrDeltaHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpDateOrDeltaHeaderValue dateOrDeltaHeaderValue);
  }
}
