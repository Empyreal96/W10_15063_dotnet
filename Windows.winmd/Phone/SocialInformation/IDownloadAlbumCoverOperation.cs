// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IDownloadAlbumCoverOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Guid(2567577356, 26191, 13914, 186, 217, 59, 175, 41, 96, 246, 172)]
  [ExclusiveTo(typeof (DownloadAlbumCoverOperation))]
  [Deprecated("IDownloadAlbumCoverOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IDownloadAlbumCoverOperation : ISocialOperation
  {
    string AlbumId { [Deprecated("IDownloadAlbumCoverOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
