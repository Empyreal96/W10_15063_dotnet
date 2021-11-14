// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibraryChange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StorageLibraryChange : IStorageLibraryChange
  {
    public extern StorageLibraryChangeType ChangeType { [MethodImpl] get; }

    public extern string Path { [MethodImpl] get; }

    public extern string PreviousPath { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IsOfType(StorageItemTypes type);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetStorageItemAsync();
  }
}
