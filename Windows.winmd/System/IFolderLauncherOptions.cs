// Decompiled with JetBrains decompiler
// Type: Windows.System.IFolderLauncherOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [ExclusiveTo(typeof (FolderLauncherOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3146891901, 27527, 17194, 189, 4, 119, 108, 111, 95, 178, 171)]
  internal interface IFolderLauncherOptions
  {
    IVector<IStorageItem> ItemsToSelect { get; }
  }
}
