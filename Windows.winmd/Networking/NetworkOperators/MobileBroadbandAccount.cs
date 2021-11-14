// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandAccount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IMobileBroadbandAccountStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MobileBroadbandAccount : 
    IMobileBroadbandAccount,
    IMobileBroadbandAccount2,
    IMobileBroadbandAccount3
  {
    public extern string NetworkAccountId { [MethodImpl] get; }

    public extern Guid ServiceProviderGuid { [MethodImpl] get; }

    public extern string ServiceProviderName { [MethodImpl] get; }

    public extern MobileBroadbandNetwork CurrentNetwork { [MethodImpl] get; }

    public extern MobileBroadbandDeviceInformation CurrentDeviceInformation { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<ConnectionProfile> GetConnectionProfiles();

    public extern global::Windows.Foundation.Uri AccountExperienceUrl { [MethodImpl] get; }

    public static extern IVectorView<string> AvailableNetworkAccountIds { [MethodImpl] get; }

    [MethodImpl]
    public static extern MobileBroadbandAccount CreateFromNetworkAccountId(
      string networkAccountId);
  }
}
