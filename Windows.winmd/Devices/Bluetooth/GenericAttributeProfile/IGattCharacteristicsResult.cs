// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristicsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattCharacteristicsResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(294949980, 45655, 20286, 157, 183, 246, 139, 201, 169, 174, 242)]
  internal interface IGattCharacteristicsResult
  {
    GattCommunicationStatus Status { get; }

    IReference<byte> ProtocolError { get; }

    IVectorView<GattCharacteristic> Characteristics { get; }
  }
}
