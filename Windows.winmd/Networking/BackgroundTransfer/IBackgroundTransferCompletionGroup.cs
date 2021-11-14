// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferCompletionGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferCompletionGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(764609061, 39019, 22349, 121, 80, 10, 221, 71, 245, 215, 6)]
  internal interface IBackgroundTransferCompletionGroup
  {
    IBackgroundTrigger Trigger { get; }

    bool IsEnabled { get; }

    void Enable();
  }
}
