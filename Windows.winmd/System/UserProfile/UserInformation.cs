// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.UserInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.System.UserProfile
{
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IUserInformationStatics), 65536, "Windows.System.UserProfile.UserProfileContract")]
  [ContractVersion(typeof (UserProfileContract), 65536)]
  public static class UserInformation
  {
    public static extern bool AccountPictureChangeEnabled { [MethodImpl] get; }

    public static extern bool NameAccessAllowed { [MethodImpl] get; }

    [MethodImpl]
    public static extern IStorageFile GetAccountPicture(AccountPictureKind kind);

    [MethodImpl]
    public static extern IAsyncOperation<SetAccountPictureResult> SetAccountPictureAsync(
      IStorageFile image);

    [MethodImpl]
    public static extern IAsyncOperation<SetAccountPictureResult> SetAccountPicturesAsync(
      IStorageFile smallImage,
      IStorageFile largeImage,
      IStorageFile video);

    [MethodImpl]
    public static extern IAsyncOperation<SetAccountPictureResult> SetAccountPictureFromStreamAsync(
      IRandomAccessStream image);

    [MethodImpl]
    public static extern IAsyncOperation<SetAccountPictureResult> SetAccountPicturesFromStreamsAsync(
      IRandomAccessStream smallImage,
      IRandomAccessStream largeImage,
      IRandomAccessStream video);

    public static extern event EventHandler<object> AccountPictureChanged;

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetDisplayNameAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetFirstNameAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetLastNameAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetPrincipalNameAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Uri> GetSessionInitiationProtocolUriAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetDomainNameAsync();
  }
}
