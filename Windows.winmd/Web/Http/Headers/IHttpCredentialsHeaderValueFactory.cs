// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCredentialsHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(4062027409, 19740, 16770, 191, 209, 52, 71, 10, 98, 249, 80)]
  [ExclusiveTo(typeof (HttpCredentialsHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpCredentialsHeaderValueFactory
  {
    HttpCredentialsHeaderValue CreateFromScheme(string scheme);

    HttpCredentialsHeaderValue CreateFromSchemeWithToken(
      string scheme,
      string token);
  }
}
