// Decompiled with JetBrains decompiler
// Type: Windows.System.FolderLauncherOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.UI.ViewManagement;

namespace Windows.System
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FolderLauncherOptions : IFolderLauncherOptions, ILauncherViewOptions
  {
    [MethodImpl]
    public extern FolderLauncherOptions();

    public extern IVector<IStorageItem> ItemsToSelect { [MethodImpl] get; }

    public extern ViewSizePreference DesiredRemainingView { [MethodImpl] get; [MethodImpl] set; }
  }
}
