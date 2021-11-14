// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpChallengeHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpChallengeHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4090727026, 64513, 19713, 160, 8, 252, 183, 196, 89, 214, 53)]
  internal interface IHttpChallengeHeaderValueStatics
  {
    HttpChallengeHeaderValue Parse(string input);

    bool TryParse(string input, out HttpChallengeHeaderValue challengeHeaderValue);
  }
}
