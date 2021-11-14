// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattWriteResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1234296241, 52011, 17655, 153, 252, 210, 154, 40, 113, 220, 155)]
  [ExclusiveTo(typeof (GattWriteResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattWriteResult
  {
    GattCommunicationStatus Status { get; }

    IReference<byte> ProtocolError { get; }
  }
}
