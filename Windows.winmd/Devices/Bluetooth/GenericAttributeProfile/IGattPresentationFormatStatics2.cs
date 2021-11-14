// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattPresentationFormatStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(2848069395, 47151, 17246, 182, 52, 33, 253, 133, 164, 60, 7)]
  [ExclusiveTo(typeof (GattPresentationFormat))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattPresentationFormatStatics2 : IGattPresentationFormatStatics
  {
    GattPresentationFormat FromParts(
      byte formatType,
      int exponent,
      ushort unit,
      byte namespaceId,
      ushort description);
  }
}
