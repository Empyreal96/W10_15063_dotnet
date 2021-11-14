// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattServiceProviderTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattServiceProviderTrigger))]
  [Guid(3720782825, 5463, 19416, 133, 66, 70, 138, 160, 198, 150, 246)]
  internal interface IGattServiceProviderTrigger
  {
    string TriggerId { get; }

    GattLocalService Service { get; }

    GattServiceProviderAdvertisingParameters AdvertisingParameters { set; get; }
  }
}
