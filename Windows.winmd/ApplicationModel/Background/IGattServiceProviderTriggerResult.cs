// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattServiceProviderTriggerResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1011257777, 45464, 20100, 186, 212, 207, 74, 210, 153, 237, 58)]
  [ExclusiveTo(typeof (GattServiceProviderTriggerResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattServiceProviderTriggerResult
  {
    GattServiceProviderTrigger Trigger { get; }

    BluetoothError Error { get; }
  }
}
