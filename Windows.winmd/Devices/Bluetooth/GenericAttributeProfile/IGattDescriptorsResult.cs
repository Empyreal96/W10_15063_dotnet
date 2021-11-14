// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDescriptorsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattDescriptorsResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2613088755, 38375, 17545, 141, 37, 255, 129, 149, 90, 87, 185)]
  internal interface IGattDescriptorsResult
  {
    GattCommunicationStatus Status { get; }

    IReference<byte> ProtocolError { get; }

    IVectorView<GattDescriptor> Descriptors { get; }
  }
}
