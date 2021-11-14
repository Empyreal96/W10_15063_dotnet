// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.ICachedFileUpdaterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [Guid(2680752416, 31695, 18568, 168, 30, 16, 45, 112, 52, 215, 206)]
  [ExclusiveTo(typeof (CachedFileUpdater))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICachedFileUpdaterStatics
  {
    void SetUpdateInformation(
      IStorageFile file,
      string contentId,
      ReadActivationMode readMode,
      WriteActivationMode writeMode,
      CachedFileOptions options);
  }
}
