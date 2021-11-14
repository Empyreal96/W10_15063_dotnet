// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2764795349, 2306, 17310, 191, 215, 225, 37, 82, 177, 101, 206)]
  public interface IHttpFilter : IClosable
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request);
  }
}
