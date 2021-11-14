// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IDownloadImageOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Guid(47360346, 43905, 14103, 131, 21, 28, 43, 137, 47, 109, 16)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (DownloadImageOperation))]
  [Deprecated("IDownloadImageOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  internal interface IDownloadImageOperation : ISocialOperation
  {
    string PhotoId { [Deprecated("IDownloadImageOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    ImageType DesiredImageType { [Deprecated("IDownloadImageOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    ImageResolution DesiredResolution { [Deprecated("IDownloadImageOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
