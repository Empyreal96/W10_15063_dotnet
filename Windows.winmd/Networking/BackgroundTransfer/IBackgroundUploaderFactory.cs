// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploaderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BackgroundUploader))]
  [Guid(1935803335, 4327, 18592, 172, 60, 26, 199, 16, 149, 236, 87)]
  internal interface IBackgroundUploaderFactory
  {
    BackgroundUploader CreateWithCompletionGroup(
      BackgroundTransferCompletionGroup completionGroup);
  }
}
