// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpLanguageRangeWithQualityHeaderValueCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2287819453, 19279, 18442, 137, 206, 138, 237, 206, 230, 227, 160)]
  internal interface IHttpLanguageRangeWithQualityHeaderValueCollection : 
    IVector<HttpLanguageRangeWithQualityHeaderValue>,
    IIterable<HttpLanguageRangeWithQualityHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
