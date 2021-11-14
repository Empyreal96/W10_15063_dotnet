// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductInfoHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2273179466, 54939, 17656, 173, 79, 69, 58, 249, 196, 46, 208)]
  [ExclusiveTo(typeof (HttpProductInfoHeaderValueCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpProductInfoHeaderValueCollection : 
    IVector<HttpProductInfoHeaderValue>,
    IIterable<HttpProductInfoHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
