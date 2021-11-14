// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattSubscribedClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattSubscribedClient))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1936625665, 5540, 20162, 146, 72, 227, 242, 13, 70, 59, 233)]
  internal interface IGattSubscribedClient
  {
    GattSession Session { get; }

    ushort MaxNotificationSize { get; }

    event TypedEventHandler<GattSubscribedClient, object> MaxNotificationSizeChanged;
  }
}
