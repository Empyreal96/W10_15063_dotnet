// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptorParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class GattLocalDescriptorParameters : IGattLocalDescriptorParameters
  {
    [MethodImpl]
    public extern GattLocalDescriptorParameters();

    public extern IBuffer StaticValue { [MethodImpl] set; [MethodImpl] get; }

    public extern GattProtectionLevel ReadProtectionLevel { [MethodImpl] set; [MethodImpl] get; }

    public extern GattProtectionLevel WriteProtectionLevel { [MethodImpl] set; [MethodImpl] get; }
  }
}
