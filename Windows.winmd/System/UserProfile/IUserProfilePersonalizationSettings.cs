// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IUserProfilePersonalizationSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (UserProfilePersonalizationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2364398260, 31128, 18133, 141, 211, 24, 79, 28, 95, 154, 185)]
  internal interface IUserProfilePersonalizationSettings
  {
    [RemoteAsync]
    IAsyncOperation<bool> TrySetLockScreenImageAsync(StorageFile imageFile);

    [RemoteAsync]
    IAsyncOperation<bool> TrySetWallpaperImageAsync(StorageFile imageFile);
  }
}
