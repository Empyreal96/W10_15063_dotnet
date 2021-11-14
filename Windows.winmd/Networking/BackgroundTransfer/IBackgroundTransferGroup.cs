// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3636716516, 25689, 17728, 133, 235, 170, 161, 200, 144, 54, 119)]
  internal interface IBackgroundTransferGroup
  {
    string Name { get; }

    BackgroundTransferBehavior TransferBehavior { get; set; }
  }
}
