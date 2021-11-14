// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.IOperationQueue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Deprecated("IOperationQueue : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [ExclusiveTo(typeof (OperationQueue))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(1411924864, 47931, 13608, 188, 244, 72, 3, 93, 132, 116, 43)]
  internal interface IOperationQueue
  {
    [Deprecated("IOperationQueue : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<ISocialOperation> GetNextOperationAsync();
  }
}
