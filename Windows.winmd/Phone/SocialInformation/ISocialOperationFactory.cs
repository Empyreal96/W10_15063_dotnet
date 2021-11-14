// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.ISocialOperationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Guid(4056486705, 30964, 19334, 132, 150, 186, 163, 13, 17, 251, 31)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Deprecated("ISocialOperationFactory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  public interface ISocialOperationFactory
  {
    SocialOperationType Type { [Deprecated("ISocialOperationFactory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    [Deprecated("ISocialOperationFactory : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<ISocialOperation> GetOperationAsync();
  }
}
