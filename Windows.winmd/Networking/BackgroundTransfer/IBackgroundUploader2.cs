// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploader2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundUploader))]
  [Guid(2382762702, 3124, 17507, 128, 127, 25, 138, 27, 139, 212, 173)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundUploader2
  {
    BackgroundTransferGroup TransferGroup { get; set; }

    ToastNotification SuccessToastNotification { get; set; }

    ToastNotification FailureToastNotification { get; set; }

    TileNotification SuccessTileNotification { get; set; }

    TileNotification FailureTileNotification { get; set; }
  }
}
