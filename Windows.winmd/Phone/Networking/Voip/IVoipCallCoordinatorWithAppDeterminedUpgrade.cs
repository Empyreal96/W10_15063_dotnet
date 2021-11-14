// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IVoipCallCoordinatorWithAppDeterminedUpgrade
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ExclusiveTo(typeof (VoipCallCoordinator))]
  [Guid(1321463206, 40176, 16476, 188, 205, 203, 122, 134, 50, 164, 86)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IVoipCallCoordinatorWithAppDeterminedUpgrade
  {
    void ConfirmNonSeamlessUpgrade(Guid callUpgradeGuid);

    void CancelUpgrade(Guid callUpgradeGuid);
  }
}
