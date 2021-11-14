// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAccount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(918703309, 52962, 17376, 166, 3, 238, 134, 163, 109, 101, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandAccount))]
  internal interface IMobileBroadbandAccount
  {
    string NetworkAccountId { get; }

    Guid ServiceProviderGuid { get; }

    string ServiceProviderName { get; }

    MobileBroadbandNetwork CurrentNetwork { get; }

    MobileBroadbandDeviceInformation CurrentDeviceInformation { get; }
  }
}
