// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandPinLockStateChange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3189139262, 7940, 20373, 139, 144, 231, 245, 89, 221, 231, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandPinLockStateChange))]
  internal interface IMobileBroadbandPinLockStateChange
  {
    string DeviceId { get; }

    MobileBroadbandPinType PinType { get; }

    MobileBroadbandPinLockState PinLockState { get; }
  }
}
