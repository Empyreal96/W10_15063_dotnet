// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.UserProfilePersonalizationSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System.UserProfile
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserProfilePersonalizationSettingsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class UserProfilePersonalizationSettings : IUserProfilePersonalizationSettings
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetLockScreenImageAsync(
      StorageFile imageFile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetWallpaperImageAsync(
      StorageFile imageFile);

    public static extern UserProfilePersonalizationSettings Current { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool IsSupported();
  }
}
