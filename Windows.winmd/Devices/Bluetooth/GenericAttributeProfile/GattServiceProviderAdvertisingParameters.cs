// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattServiceProviderAdvertisingParameters : 
    IGattServiceProviderAdvertisingParameters
  {
    [MethodImpl]
    public extern GattServiceProviderAdvertisingParameters();

    public extern bool IsConnectable { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsDiscoverable { [MethodImpl] set; [MethodImpl] get; }
  }
}
