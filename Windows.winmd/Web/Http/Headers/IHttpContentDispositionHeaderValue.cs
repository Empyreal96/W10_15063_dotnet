// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentDispositionHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpContentDispositionHeaderValue))]
  [Guid(4070764252, 9769, 19273, 153, 8, 150, 161, 104, 233, 54, 94)]
  internal interface IHttpContentDispositionHeaderValue
  {
    string DispositionType { get; set; }

    string FileName { get; set; }

    string FileNameStar { get; set; }

    string Name { get; set; }

    IVector<HttpNameValueHeaderValue> Parameters { get; }

    IReference<ulong> Size { get; set; }
  }
}
