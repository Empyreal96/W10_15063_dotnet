// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploaderUserConsent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Deprecated("IBackgroundUploaderUserConsent is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (BackgroundUploader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1001620683, 1888, 17949, 144, 127, 81, 56, 248, 77, 68, 193)]
  internal interface IBackgroundUploaderUserConsent
  {
    [RemoteAsync]
    [Deprecated("RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<UnconstrainedTransferRequestResult> RequestUnconstrainedUploadsAsync(
      IIterable<UploadOperation> operations);
  }
}
