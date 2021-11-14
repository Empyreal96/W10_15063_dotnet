// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReadResult))]
  [Guid(2702135456, 64323, 18607, 186, 170, 99, 138, 92, 99, 41, 254)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattReadResult2
  {
    IReference<byte> ProtocolError { get; }
  }
}
