// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpTransferCodingHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpTransferCodingHeaderValue))]
  [Guid(1131361017, 15853, 17085, 179, 138, 84, 150, 162, 81, 28, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpTransferCodingHeaderValue
  {
    IVector<HttpNameValueHeaderValue> Parameters { get; }

    string Value { get; }
  }
}
