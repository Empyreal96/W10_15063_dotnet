// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingWithQualityHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentCodingWithQualityHeaderValueCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2081256766, 59545, 17272, 181, 200, 65, 45, 130, 7, 17, 204)]
  internal interface IHttpContentCodingWithQualityHeaderValueCollection : 
    IVector<HttpContentCodingWithQualityHeaderValue>,
    IIterable<HttpContentCodingWithQualityHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
