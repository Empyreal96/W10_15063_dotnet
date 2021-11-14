// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpChallengeHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3293758545, 55708, 16554, 147, 153, 144, 238, 185, 143, 198, 19)]
  [ExclusiveTo(typeof (HttpChallengeHeaderValue))]
  internal interface IHttpChallengeHeaderValueFactory
  {
    HttpChallengeHeaderValue CreateFromScheme(string scheme);

    HttpChallengeHeaderValue CreateFromSchemeWithToken(
      string scheme,
      string token);
  }
}
