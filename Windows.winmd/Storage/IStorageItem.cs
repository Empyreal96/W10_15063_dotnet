// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage
{
  [Guid(1107798422, 51759, 17143, 189, 232, 139, 16, 69, 122, 127, 48)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageItem
  {
    [Overload("RenameAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    IAsyncAction RenameAsync(string desiredName);

    [Overload("RenameAsync")]
    [RemoteAsync]
    IAsyncAction RenameAsync(string desiredName, NameCollisionOption option);

    [RemoteAsync]
    [Overload("DeleteAsyncOverloadDefaultOptions")]
    IAsyncAction DeleteAsync();

    [Overload("DeleteAsync")]
    [RemoteAsync]
    IAsyncAction DeleteAsync(StorageDeleteOption option);

    [RemoteAsync]
    IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();

    string Name { get; }

    string Path { get; }

    FileAttributes Attributes { get; }

    DateTime DateCreated { get; }

    bool IsOfType(StorageItemTypes type);
  }
}
