// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristicParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattLocalCharacteristicParameters : IGattLocalCharacteristicParameters
  {
    [MethodImpl]
    public extern GattLocalCharacteristicParameters();

    public extern IBuffer StaticValue { [MethodImpl] set; [MethodImpl] get; }

    public extern GattCharacteristicProperties CharacteristicProperties { [MethodImpl] set; [MethodImpl] get; }

    public extern GattProtectionLevel ReadProtectionLevel { [MethodImpl] set; [MethodImpl] get; }

    public extern GattProtectionLevel WriteProtectionLevel { [MethodImpl] set; [MethodImpl] get; }

    public extern string UserDescription { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<GattPresentationFormat> PresentationFormats { [MethodImpl] get; }
  }
}
