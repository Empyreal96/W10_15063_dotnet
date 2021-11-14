// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IDownloadAlbumItemsOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [ExclusiveTo(typeof (DownloadAlbumItemsOperation))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(4090637002, 47065, 16293, 184, 191, 141, 61, 6, 45, 197, 249)]
  [Deprecated("IDownloadAlbumItemsOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  internal interface IDownloadAlbumItemsOperation : ISocialOperation
  {
    string ParentAlbumId { [Deprecated("IDownloadAlbumItemsOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    uint StartIndex { [Deprecated("IDownloadAlbumItemsOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    uint MaximumItemCount { [Deprecated("IDownloadAlbumItemsOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
