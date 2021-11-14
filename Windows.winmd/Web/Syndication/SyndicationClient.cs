// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Web.Syndication
{
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISyndicationClientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SyndicationClient : ISyndicationClient
  {
    [MethodImpl]
    public extern SyndicationClient(PasswordCredential serverCredential);

    [MethodImpl]
    public extern SyndicationClient();

    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern uint MaxResponseBufferSize { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Timeout { [MethodImpl] get; [MethodImpl] set; }

    public extern bool BypassCacheOnRetrieve { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void SetRequestHeader(string name, string value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync(
      Uri uri);
  }
}
