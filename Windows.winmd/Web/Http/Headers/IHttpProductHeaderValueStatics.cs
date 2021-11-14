// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2428714537, 48892, 17207, 190, 98, 73, 240, 151, 151, 95, 83)]
  [ExclusiveTo(typeof (HttpProductHeaderValue))]
  internal interface IHttpProductHeaderValueStatics
  {
    HttpProductHeaderValue Parse(string input);

    bool TryParse(string input, out HttpProductHeaderValue productHeaderValue);
  }
}
