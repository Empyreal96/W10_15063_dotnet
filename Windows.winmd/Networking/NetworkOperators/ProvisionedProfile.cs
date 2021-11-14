// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ProvisionedProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class ProvisionedProfile : IProvisionedProfile
  {
    [MethodImpl]
    public extern void UpdateCost(NetworkCostType value);

    [MethodImpl]
    public extern void UpdateUsage(ProfileUsage value);
  }
}
