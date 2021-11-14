// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.AtomPubClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage.Streams;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IAtomPubClientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AtomPubClient : IAtomPubClient, ISyndicationClient
  {
    [MethodImpl]
    public extern AtomPubClient(PasswordCredential serverCredential);

    [MethodImpl]
    public extern AtomPubClient();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ServiceDocument, RetrievalProgress> RetrieveServiceDocumentAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, RetrievalProgress> RetrieveMediaResourceAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<SyndicationItem, RetrievalProgress> RetrieveResourceAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateResourceAsync(
      Uri uri,
      string description,
      SyndicationItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateMediaResourceAsync(
      Uri uri,
      string mediaType,
      string description,
      IInputStream mediaStream);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> UpdateMediaResourceAsync(
      Uri uri,
      string mediaType,
      IInputStream mediaStream);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> UpdateResourceAsync(
      Uri uri,
      SyndicationItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> UpdateResourceItemAsync(
      SyndicationItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> DeleteResourceAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> DeleteResourceItemAsync(
      SyndicationItem item);

    [MethodImpl]
    public extern void CancelAsyncOperations();

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
