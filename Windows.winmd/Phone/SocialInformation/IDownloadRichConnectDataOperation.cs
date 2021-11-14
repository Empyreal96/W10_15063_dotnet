// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IDownloadRichConnectDataOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Deprecated("IDownloadRichConnectDataOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [ExclusiveTo(typeof (DownloadRichConnectDataOperation))]
  [Guid(3726445109, 23266, 18657, 149, 142, 186, 7, 172, 14, 116, 29)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IDownloadRichConnectDataOperation : ISocialOperation
  {
    IVector<string> Ids { [Deprecated("IDownloadRichConnectDataOperation : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
