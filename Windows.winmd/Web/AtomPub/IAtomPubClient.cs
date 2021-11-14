// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IAtomPubClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [Guid(892939320, 52717, 19788, 150, 55, 5, 241, 92, 28, 148, 6)]
  [ExclusiveTo(typeof (AtomPubClient))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAtomPubClient : ISyndicationClient
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<ServiceDocument, RetrievalProgress> RetrieveServiceDocumentAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<IInputStream, RetrievalProgress> RetrieveMediaResourceAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<SyndicationItem, RetrievalProgress> RetrieveResourceAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateResourceAsync(
      Uri uri,
      string description,
      SyndicationItem item);

    [RemoteAsync]
    IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateMediaResourceAsync(
      Uri uri,
      string mediaType,
      string description,
      IInputStream mediaStream);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> UpdateMediaResourceAsync(
      Uri uri,
      string mediaType,
      IInputStream mediaStream);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> UpdateResourceAsync(
      Uri uri,
      SyndicationItem item);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> UpdateResourceItemAsync(
      SyndicationItem item);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> DeleteResourceAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> DeleteResourceItemAsync(
      SyndicationItem item);

    void CancelAsyncOperations();
  }
}
