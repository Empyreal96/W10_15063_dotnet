// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpTransferCodingHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3143819260, 58209, 20232, 142, 79, 201, 231, 35, 222, 112, 59)]
  [ExclusiveTo(typeof (HttpTransferCodingHeaderValue))]
  internal interface IHttpTransferCodingHeaderValueFactory
  {
    HttpTransferCodingHeaderValue Create(string input);
  }
}
