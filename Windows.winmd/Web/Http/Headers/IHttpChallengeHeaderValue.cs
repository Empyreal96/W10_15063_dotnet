// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpChallengeHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(959668655, 3965, 18464, 159, 221, 162, 185, 86, 238, 174, 171)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpChallengeHeaderValue))]
  internal interface IHttpChallengeHeaderValue
  {
    IVector<HttpNameValueHeaderValue> Parameters { get; }

    string Scheme { get; }

    string Token { get; }
  }
}
