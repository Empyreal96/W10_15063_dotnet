// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattPresentationFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(426573857, 64173, 17884, 174, 91, 42, 195, 24, 78, 132, 219)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattPresentationFormat))]
  internal interface IGattPresentationFormat
  {
    byte FormatType { get; }

    int Exponent { get; }

    ushort Unit { get; }

    byte Namespace { get; }

    ushort Description { get; }
  }
}
