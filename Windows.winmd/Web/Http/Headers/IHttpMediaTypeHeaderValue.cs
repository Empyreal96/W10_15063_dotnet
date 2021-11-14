// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMediaTypeHeaderValue))]
  [Guid(380798259, 59176, 20427, 189, 176, 8, 164, 49, 161, 72, 68)]
  internal interface IHttpMediaTypeHeaderValue
  {
    string CharSet { get; set; }

    string MediaType { get; set; }

    IVector<HttpNameValueHeaderValue> Parameters { get; }
  }
}
