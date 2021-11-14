// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandRadioStateChangeTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandRadioStateChangeTriggerDetails))]
  [Guid(1898977998, 2364, 17094, 176, 219, 173, 31, 117, 166, 84, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandRadioStateChangeTriggerDetails
  {
    IVectorView<MobileBroadbandRadioStateChange> RadioStateChanges { get; }
  }
}
