// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattPresentationFormatTypesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(4210145802, 12474, 16540, 190, 247, 207, 251, 109, 3, 184, 251)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattPresentationFormatTypes))]
  internal interface IGattPresentationFormatTypesStatics
  {
    byte Boolean { get; }

    byte Bit2 { get; }

    byte Nibble { get; }

    byte UInt8 { get; }

    byte UInt12 { get; }

    byte UInt16 { get; }

    byte UInt24 { get; }

    byte UInt32 { get; }

    byte UInt48 { get; }

    byte UInt64 { get; }

    byte UInt128 { get; }

    byte SInt8 { get; }

    byte SInt12 { get; }

    byte SInt16 { get; }

    byte SInt24 { get; }

    byte SInt32 { get; }

    byte SInt48 { get; }

    byte SInt64 { get; }

    byte SInt128 { get; }

    byte Float32 { get; }

    byte Float64 { get; }

    byte SFloat { get; }

    byte Float { get; }

    byte DUInt16 { get; }

    byte Utf8 { get; }

    byte Utf16 { get; }

    byte Struct { get; }
  }
}
