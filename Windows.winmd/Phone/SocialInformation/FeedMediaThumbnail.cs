// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.FeedMediaThumbnail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.SocialInformation
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [Deprecated("FeedMediaThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  public sealed class FeedMediaThumbnail : IFeedMediaThumbnail
  {
    [MethodImpl]
    public extern FeedMediaThumbnail();

    public extern string Target { [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; }

    public extern string ImageUrl { [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; }

    public extern ImageResolution Resolution { [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; }

    [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetImageAsync();

    [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncAction SetImageAsync(IInputStream stream);

    public extern IRandomAccessStreamReference Image { [Deprecated("IFeedMediaThumbnail : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }
  }
}
