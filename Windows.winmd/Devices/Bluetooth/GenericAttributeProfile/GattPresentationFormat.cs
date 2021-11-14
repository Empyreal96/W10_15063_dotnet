// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattPresentationFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Static(typeof (IGattPresentationFormatStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IGattPresentationFormatStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattPresentationFormat : IGattPresentationFormat
  {
    public extern byte FormatType { [MethodImpl] get; }

    public extern int Exponent { [MethodImpl] get; }

    public extern ushort Unit { [MethodImpl] get; }

    public extern byte Namespace { [MethodImpl] get; }

    public extern ushort Description { [MethodImpl] get; }

    [MethodImpl]
    public static extern GattPresentationFormat FromParts(
      byte formatType,
      int exponent,
      ushort unit,
      byte namespaceId,
      ushort description);

    public static extern byte BluetoothSigAssignedNumbers { [MethodImpl] get; }
  }
}
