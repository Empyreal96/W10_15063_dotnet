// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloader2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundDownloader))]
  [Guid(2840221767, 13453, 18997, 137, 14, 138, 30, 243, 121, 132, 121)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundDownloader2
  {
    BackgroundTransferGroup TransferGroup { get; set; }

    ToastNotification SuccessToastNotification { get; set; }

    ToastNotification FailureToastNotification { get; set; }

    TileNotification SuccessTileNotification { get; set; }

    TileNotification FailureTileNotification { get; set; }
  }
}
