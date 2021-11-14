// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.SocialItemThumbnail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.SocialInfo
{
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [Threading(ThreadingModel.Both)]
  [Deprecated("SocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  public sealed class SocialItemThumbnail : ISocialItemThumbnail
  {
    [MethodImpl]
    public extern SocialItemThumbnail();

    public extern Uri TargetUri { [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; }

    public extern Uri ImageUri { [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; }

    public extern BitmapSize BitmapSize { [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; }

    [Deprecated("ISocialItemThumbnail is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetImageAsync(IInputStream image);
  }
}
