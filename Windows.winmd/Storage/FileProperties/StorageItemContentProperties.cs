// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.StorageItemContentProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageItemContentProperties : 
    IStorageItemContentProperties,
    IStorageItemExtraProperties
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MusicProperties> GetMusicPropertiesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VideoProperties> GetVideoPropertiesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageProperties> GetImagePropertiesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DocumentProperties> GetDocumentPropertiesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync(
      IIterable<string> propertiesToRetrieve);

    [Overload("SavePropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync(
      [HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

    [RemoteAsync]
    [Overload("SavePropertiesAsyncOverloadDefault")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync();
  }
}
