// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (KnownFolders))]
  [Guid(3306767169, 38722, 20181, 130, 61, 252, 20, 1, 20, 135, 100)]
  internal interface IKnownFoldersStatics3
  {
    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetFolderForUserAsync(
      User user,
      KnownFolderId folderId);
  }
}
