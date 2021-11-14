// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.Foreground.IExtendedExecutionForegroundSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution.Foreground
{
  [Guid(4227088609, 40208, 16897, 176, 30, 200, 50, 117, 41, 111, 46)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ExtendedExecutionForegroundSession))]
  internal interface IExtendedExecutionForegroundSession : IClosable
  {
    string Description { get; set; }

    event TypedEventHandler<object, ExtendedExecutionForegroundRevokedEventArgs> Revoked;

    [RemoteAsync]
    IAsyncOperation<ExtendedExecutionForegroundResult> RequestExtensionAsync();

    ExtendedExecutionForegroundReason Reason { get; set; }
  }
}
