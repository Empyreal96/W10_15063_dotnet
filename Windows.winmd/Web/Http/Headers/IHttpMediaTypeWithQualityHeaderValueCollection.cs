// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpMediaTypeWithQualityHeaderValueCollection))]
  [Guid(1007446899, 4930, 17799, 160, 86, 24, 208, 47, 246, 113, 101)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMediaTypeWithQualityHeaderValueCollection : 
    IVector<HttpMediaTypeWithQualityHeaderValue>,
    IIterable<HttpMediaTypeWithQualityHeaderValue>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
