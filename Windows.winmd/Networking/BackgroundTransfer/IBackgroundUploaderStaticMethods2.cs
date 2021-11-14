// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploaderStaticMethods2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundUploader))]
  [Guid(3910773858, 59912, 17136, 162, 172, 7, 228, 103, 84, 144, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundUploaderStaticMethods2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsForTransferGroupAsync(
      BackgroundTransferGroup group);
  }
}
