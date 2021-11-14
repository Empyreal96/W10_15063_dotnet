// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpContentCodingHeaderValue))]
  [Guid(3309120471, 13099, 17232, 133, 16, 46, 103, 162, 40, 154, 90)]
  internal interface IHttpContentCodingHeaderValueFactory
  {
    HttpContentCodingHeaderValue Create(string contentCoding);
  }
}
