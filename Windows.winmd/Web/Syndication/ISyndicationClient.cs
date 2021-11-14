// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2652416439, 29257, 19269, 178, 41, 125, 248, 149, 165, 161, 245)]
  public interface ISyndicationClient
  {
    PasswordCredential ServerCredential { get; set; }

    PasswordCredential ProxyCredential { get; set; }

    uint MaxResponseBufferSize { get; set; }

    uint Timeout { get; set; }

    bool BypassCacheOnRetrieve { get; set; }

    void SetRequestHeader(string name, string value);

    [RemoteAsync]
    IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync(
      Uri uri);
  }
}
