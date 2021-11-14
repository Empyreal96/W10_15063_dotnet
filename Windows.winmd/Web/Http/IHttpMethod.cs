// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMethod
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpMethod))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1921859618, 28685, 20448, 175, 165, 64, 41, 156, 88, 219, 253)]
  internal interface IHttpMethod
  {
    string Method { get; }
  }
}
