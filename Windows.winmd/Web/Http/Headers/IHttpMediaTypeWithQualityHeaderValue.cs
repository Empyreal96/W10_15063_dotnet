// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(411917874, 30398, 17568, 177, 205, 32, 116, 189, 237, 45, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMediaTypeWithQualityHeaderValue))]
  internal interface IHttpMediaTypeWithQualityHeaderValue
  {
    string CharSet { get; set; }

    string MediaType { get; set; }

    IVector<HttpNameValueHeaderValue> Parameters { get; }

    IReference<double> Quality { get; set; }
  }
}
