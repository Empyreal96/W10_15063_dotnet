// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAccountUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2076384648, 42685, 18913, 128, 171, 107, 145, 53, 74, 87, 212)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandAccountUpdatedEventArgs))]
  internal interface IMobileBroadbandAccountUpdatedEventArgs
  {
    string NetworkAccountId { get; }

    bool HasDeviceInformationChanged { get; }

    bool HasNetworkChanged { get; }
  }
}
