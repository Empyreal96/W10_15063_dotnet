// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpNameValueHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(3636098147, 23450, 19739, 147, 249, 170, 91, 68, 236, 253, 223)]
  [ExclusiveTo(typeof (HttpNameValueHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpNameValueHeaderValue
  {
    string Name { get; }

    string Value { get; set; }
  }
}
