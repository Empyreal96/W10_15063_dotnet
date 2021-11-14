// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattLocalDescriptor : IGattLocalDescriptor
  {
    public extern Guid Uuid { [MethodImpl] get; }

    public extern IBuffer StaticValue { [MethodImpl] get; }

    public extern GattProtectionLevel ReadProtectionLevel { [MethodImpl] get; }

    public extern GattProtectionLevel WriteProtectionLevel { [MethodImpl] get; }

    public extern event TypedEventHandler<GattLocalDescriptor, GattReadRequestedEventArgs> ReadRequested;

    public extern event TypedEventHandler<GattLocalDescriptor, GattWriteRequestedEventArgs> WriteRequested;
  }
}
