// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReadResult))]
  [Guid(1671851784, 6890, 19532, 165, 15, 151, 186, 228, 116, 179, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGattReadResult
  {
    GattCommunicationStatus Status { get; }

    IBuffer Value { get; }
  }
}
