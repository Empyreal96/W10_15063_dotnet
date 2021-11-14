// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4102995462, 30877, 19019, 134, 82, 189, 1, 123, 93, 47, 198)]
  [ExclusiveTo(typeof (GattLocalDescriptor))]
  internal interface IGattLocalDescriptor
  {
    Guid Uuid { get; }

    IBuffer StaticValue { get; }

    GattProtectionLevel ReadProtectionLevel { get; }

    GattProtectionLevel WriteProtectionLevel { get; }

    event TypedEventHandler<GattLocalDescriptor, GattReadRequestedEventArgs> ReadRequested;

    event TypedEventHandler<GattLocalDescriptor, GattWriteRequestedEventArgs> WriteRequested;
  }
}
