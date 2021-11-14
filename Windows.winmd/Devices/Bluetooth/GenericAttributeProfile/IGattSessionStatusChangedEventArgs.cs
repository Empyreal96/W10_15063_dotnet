// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattSessionStatusChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattSessionStatusChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1980086062, 33663, 16460, 171, 52, 49, 99, 243, 157, 223, 50)]
  internal interface IGattSessionStatusChangedEventArgs
  {
    BluetoothError Error { get; }

    GattSessionStatus Status { get; }
  }
}
