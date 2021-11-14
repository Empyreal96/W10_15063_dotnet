// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpConnectionOptionHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpConnectionOptionHeaderValueCollection))]
  [Guid(3841289245, 20802, 19968, 142, 15, 1, 149, 9, 51, 118, 41)]
  internal interface IHttpConnectionOptionHeaderValueCollection : 
    IVector<HttpConnectionOptionHeaderValue>,
    IIterable<HttpConnectionOptionHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
