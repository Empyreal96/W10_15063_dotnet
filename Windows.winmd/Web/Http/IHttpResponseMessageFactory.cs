// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpResponseMessageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpResponseMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1386786713, 61589, 17370, 182, 15, 124, 252, 43, 199, 234, 47)]
  internal interface IHttpResponseMessageFactory
  {
    HttpResponseMessage Create(HttpStatusCode statusCode);
  }
}
