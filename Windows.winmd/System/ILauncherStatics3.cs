// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [Guid(591552936, 40371, 18051, 170, 66, 220, 111, 81, 211, 56, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Launcher))]
  internal interface ILauncherStatics3
  {
    [Overload("LaunchFolderAsync")]
    IAsyncOperation<bool> LaunchFolderAsync(IStorageFolder folder);

    [Overload("LaunchFolderWithOptionsAsync")]
    IAsyncOperation<bool> LaunchFolderAsync(
      IStorageFolder folder,
      FolderLauncherOptions options);
  }
}
