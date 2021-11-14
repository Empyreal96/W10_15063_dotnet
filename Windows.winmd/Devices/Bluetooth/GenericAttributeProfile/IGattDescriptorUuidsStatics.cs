// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDescriptorUuidsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattDescriptorUuids))]
  [Guid(2801296078, 40188, 17137, 145, 133, 255, 55, 183, 81, 129, 211)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGattDescriptorUuidsStatics
  {
    Guid CharacteristicAggregateFormat { get; }

    Guid CharacteristicExtendedProperties { get; }

    Guid CharacteristicPresentationFormat { get; }

    Guid CharacteristicUserDescription { get; }

    Guid ClientCharacteristicConfiguration { get; }

    Guid ServerCharacteristicConfiguration { get; }
  }
}
