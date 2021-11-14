// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandPinLockStateChangeTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandPinLockStateChangeTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3543711889, 16017, 19768, 144, 54, 174, 232, 58, 110, 121, 173)]
  internal interface IMobileBroadbandPinLockStateChangeTriggerDetails
  {
    IVectorView<MobileBroadbandPinLockStateChange> PinLockStateChanges { get; }
  }
}
