// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMultipartFormDataContentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2689430289, 20503, 17954, 147, 168, 73, 178, 74, 79, 203, 252)]
  [ExclusiveTo(typeof (HttpMultipartFormDataContent))]
  internal interface IHttpMultipartFormDataContentFactory
  {
    HttpMultipartFormDataContent CreateWithBoundary(string boundary);
  }
}
