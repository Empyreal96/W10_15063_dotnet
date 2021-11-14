// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattPresentationFormatTypes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGattPresentationFormatTypesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public static class GattPresentationFormatTypes
  {
    public static extern byte Boolean { [MethodImpl] get; }

    public static extern byte Bit2 { [MethodImpl] get; }

    public static extern byte Nibble { [MethodImpl] get; }

    public static extern byte UInt8 { [MethodImpl] get; }

    public static extern byte UInt12 { [MethodImpl] get; }

    public static extern byte UInt16 { [MethodImpl] get; }

    public static extern byte UInt24 { [MethodImpl] get; }

    public static extern byte UInt32 { [MethodImpl] get; }

    public static extern byte UInt48 { [MethodImpl] get; }

    public static extern byte UInt64 { [MethodImpl] get; }

    public static extern byte UInt128 { [MethodImpl] get; }

    public static extern byte SInt8 { [MethodImpl] get; }

    public static extern byte SInt12 { [MethodImpl] get; }

    public static extern byte SInt16 { [MethodImpl] get; }

    public static extern byte SInt24 { [MethodImpl] get; }

    public static extern byte SInt32 { [MethodImpl] get; }

    public static extern byte SInt48 { [MethodImpl] get; }

    public static extern byte SInt64 { [MethodImpl] get; }

    public static extern byte SInt128 { [MethodImpl] get; }

    public static extern byte Float32 { [MethodImpl] get; }

    public static extern byte Float64 { [MethodImpl] get; }

    public static extern byte SFloat { [MethodImpl] get; }

    public static extern byte Float { [MethodImpl] get; }

    public static extern byte DUInt16 { [MethodImpl] get; }

    public static extern byte Utf8 { [MethodImpl] get; }

    public static extern byte Utf16 { [MethodImpl] get; }

    public static extern byte Struct { [MethodImpl] get; }
  }
}
