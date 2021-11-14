// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.CachedFileUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [Static(typeof (ICachedFileUpdaterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CachedFileUpdater
  {
    [MethodImpl]
    public static extern void SetUpdateInformation(
      IStorageFile file,
      string contentId,
      ReadActivationMode readMode,
      WriteActivationMode writeMode,
      CachedFileOptions options);
  }
}
