// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.StorageLibraryContentChangedTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Background
{
  [Static(typeof (IStorageLibraryContentChangedTriggerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageLibraryContentChangedTrigger : 
    IStorageLibraryContentChangedTrigger,
    IBackgroundTrigger
  {
    [MethodImpl]
    public static extern StorageLibraryContentChangedTrigger Create(
      StorageLibrary storageLibrary);

    [MethodImpl]
    public static extern StorageLibraryContentChangedTrigger CreateFromLibraries(
      IIterable<StorageLibrary> storageLibraries);
  }
}
