// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.ISocialItemThumbnail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.SocialInfo
{
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  [Guid(1556054810, 16136, 18815, 145, 127, 87, 224, 157, 132, 177, 65)]
  [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [ExclusiveTo(typeof (SocialItemThumbnail))]
  internal interface ISocialItemThumbnail
  {
    Uri TargetUri { [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    Uri ImageUri { [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    BitmapSize BitmapSize { [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    IAsyncAction SetImageAsync(IInputStream image);
  }
}
