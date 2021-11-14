// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IQuerySeamlessUpgradeSupportOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [Guid(2121981134, 53035, 20128, 132, 117, 225, 189, 180, 20, 3, 121)]
  [ExclusiveTo(typeof (QuerySeamlessUpgradeSupportOperation))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IQuerySeamlessUpgradeSupportOperation : IVoipOperation
  {
    string RemoteId { get; }

    void NotifyCompletion(
      bool succeeded,
      SeamlessCallUpgradeSupport seamlessCallUpgradeSupport);
  }
}
