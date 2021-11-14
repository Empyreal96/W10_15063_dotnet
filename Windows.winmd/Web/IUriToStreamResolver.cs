// Decompiled with JetBrains decompiler
// Type: Windows.Web.IUriToStreamResolver
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web
{
  [Guid(2964039786, 39659, 19770, 149, 144, 0, 62, 60, 167, 226, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IUriToStreamResolver
  {
    [RemoteAsync]
    IAsyncOperation<IInputStream> UriToStreamAsync(Uri uri);
  }
}
