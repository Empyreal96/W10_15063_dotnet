// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferCompletionGroupTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferCompletionGroupTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2070667910, 28231, 20790, 127, 203, 250, 67, 137, 244, 111, 91)]
  internal interface IBackgroundTransferCompletionGroupTriggerDetails
  {
    IVectorView<DownloadOperation> Downloads { get; }

    IVectorView<UploadOperation> Uploads { get; }
  }
}
