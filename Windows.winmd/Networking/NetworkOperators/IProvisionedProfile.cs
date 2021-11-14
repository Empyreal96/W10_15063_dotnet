// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IProvisionedProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [Guid(561447136, 33282, 4575, 173, 185, 244, 206, 70, 45, 145, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProvisionedProfile))]
  internal interface IProvisionedProfile
  {
    void UpdateCost(NetworkCostType value);

    void UpdateUsage(ProfileUsage value);
  }
}
