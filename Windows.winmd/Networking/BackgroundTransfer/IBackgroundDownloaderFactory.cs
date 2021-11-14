// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloaderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundDownloader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(646147108, 55454, 18164, 162, 154, 79, 77, 79, 20, 65, 85)]
  internal interface IBackgroundDownloaderFactory
  {
    BackgroundDownloader CreateWithCompletionGroup(
      BackgroundTransferCompletionGroup completionGroup);
  }
}
