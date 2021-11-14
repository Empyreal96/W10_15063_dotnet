// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IFeedMediaThumbnail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.SocialInformation
{
  [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (FeedMediaThumbnail))]
  [Guid(891363585, 34129, 14265, 145, 51, 4, 109, 102, 4, 245, 50)]
  internal interface IFeedMediaThumbnail
  {
    string Target { [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] set; }

    string ImageUrl { [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] set; }

    ImageResolution Resolution { [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] set; }

    [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<IRandomAccessStream> GetImageAsync();

    [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction SetImageAsync(IInputStream stream);

    IRandomAccessStreamReference Image { [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
