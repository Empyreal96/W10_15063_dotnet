// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3763176415, 7489, 19852, 162, 222, 111, 210, 237, 135, 57, 155)]
  [ExclusiveTo(typeof (HttpMediaTypeHeaderValue))]
  internal interface IHttpMediaTypeHeaderValueStatics
  {
    HttpMediaTypeHeaderValue Parse(string input);

    bool TryParse(string input, out HttpMediaTypeHeaderValue mediaTypeHeaderValue);
  }
}
