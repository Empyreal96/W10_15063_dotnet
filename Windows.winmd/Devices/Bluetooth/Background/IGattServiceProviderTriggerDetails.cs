// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattServiceProviderTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [Guid(2928412197, 1535, 19195, 177, 106, 222, 149, 243, 207, 1, 88)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattServiceProviderTriggerDetails))]
  internal interface IGattServiceProviderTriggerDetails
  {
    GattServiceProviderConnection Connection { get; }
  }
}
