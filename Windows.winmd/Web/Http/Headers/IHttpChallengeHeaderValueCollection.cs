// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpChallengeHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(3399376769, 44768, 17235, 161, 11, 230, 37, 186, 189, 100, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpChallengeHeaderValueCollection))]
  internal interface IHttpChallengeHeaderValueCollection : 
    IVector<HttpChallengeHeaderValue>,
    IIterable<HttpChallengeHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
