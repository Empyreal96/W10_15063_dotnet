// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentDispositionHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentDispositionHeaderValue))]
  [Guid(2568338372, 17772, 20097, 130, 149, 178, 171, 60, 188, 245, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentDispositionHeaderValueFactory
  {
    HttpContentDispositionHeaderValue Create(string dispositionType);
  }
}
