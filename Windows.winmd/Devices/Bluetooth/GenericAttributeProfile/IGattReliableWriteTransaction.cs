// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReliableWriteTransaction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReliableWriteTransaction))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1671851783, 6890, 19532, 165, 15, 151, 186, 228, 116, 179, 72)]
  internal interface IGattReliableWriteTransaction
  {
    void WriteValue(GattCharacteristic characteristic, IBuffer value);

    [RemoteAsync]
    IAsyncOperation<GattCommunicationStatus> CommitAsync();
  }
}
