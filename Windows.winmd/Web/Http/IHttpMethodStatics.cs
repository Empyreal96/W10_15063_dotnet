// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMethodStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpMethod))]
  [Guid(1691447792, 55706, 16723, 141, 198, 214, 140, 196, 204, 227, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMethodStatics
  {
    HttpMethod Delete { get; }

    HttpMethod Get { get; }

    HttpMethod Head { get; }

    HttpMethod Options { get; }

    HttpMethod Patch { get; }

    HttpMethod Post { get; }

    HttpMethod Put { get; }
  }
}
