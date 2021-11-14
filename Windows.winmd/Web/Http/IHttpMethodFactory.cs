// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMethodFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMethod))]
  [Guid(1011994893, 14039, 16632, 168, 109, 231, 89, 202, 242, 248, 63)]
  internal interface IHttpMethodFactory
  {
    HttpMethod Create(string method);
  }
}
