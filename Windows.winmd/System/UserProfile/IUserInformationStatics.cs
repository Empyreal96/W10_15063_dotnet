// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IUserInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UserProfileContract), 65536)]
  [Guid(2012457232, 18682, 18588, 147, 78, 42, 232, 91, 168, 247, 114)]
  [ExclusiveTo(typeof (UserInformation))]
  internal interface IUserInformationStatics
  {
    bool AccountPictureChangeEnabled { get; }

    bool NameAccessAllowed { get; }

    IStorageFile GetAccountPicture(AccountPictureKind kind);

    IAsyncOperation<SetAccountPictureResult> SetAccountPictureAsync(
      IStorageFile image);

    IAsyncOperation<SetAccountPictureResult> SetAccountPicturesAsync(
      IStorageFile smallImage,
      IStorageFile largeImage,
      IStorageFile video);

    IAsyncOperation<SetAccountPictureResult> SetAccountPictureFromStreamAsync(
      IRandomAccessStream image);

    IAsyncOperation<SetAccountPictureResult> SetAccountPicturesFromStreamsAsync(
      IRandomAccessStream smallImage,
      IRandomAccessStream largeImage,
      IRandomAccessStream video);

    event EventHandler<object> AccountPictureChanged;

    [RemoteAsync]
    IAsyncOperation<string> GetDisplayNameAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetFirstNameAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetLastNameAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetPrincipalNameAsync();

    [RemoteAsync]
    IAsyncOperation<Uri> GetSessionInitiationProtocolUriAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetDomainNameAsync();
  }
}
