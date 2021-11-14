// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceProviderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattServiceProvider))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(830029923, 21078, 16468, 164, 244, 123, 190, 119, 85, 165, 126)]
  internal interface IGattServiceProviderStatics
  {
    [Overload("CreateAsync")]
    [RemoteAsync]
    IAsyncOperation<GattServiceProviderResult> CreateAsync(
      Guid serviceUuid);
  }
}
