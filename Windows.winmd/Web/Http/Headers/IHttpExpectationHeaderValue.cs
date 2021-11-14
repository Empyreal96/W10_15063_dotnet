// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpExpectationHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1290110413, 15001, 17327, 162, 230, 236, 35, 47, 234, 150, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpExpectationHeaderValue))]
  internal interface IHttpExpectationHeaderValue
  {
    string Name { get; }

    string Value { get; set; }

    IVector<HttpNameValueHeaderValue> Parameters { get; }
  }
}
