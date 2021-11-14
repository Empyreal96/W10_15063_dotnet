// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploaderStaticMethods
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4068957435, 39685, 18241, 145, 33, 116, 10, 131, 226, 71, 223)]
  [ExclusiveTo(typeof (BackgroundUploader))]
  internal interface IBackgroundUploaderStaticMethods
  {
    [RemoteAsync]
    [Overload("GetCurrentUploadsAsync")]
    IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync();

    [Overload("GetCurrentUploadsForGroupAsync")]
    [RemoteAsync]
    [Deprecated("GetCurrentUploadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentUploadsForTransferGroupAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync(
      string group);
  }
}
