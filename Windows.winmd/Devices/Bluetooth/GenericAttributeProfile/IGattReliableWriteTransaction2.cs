// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReliableWriteTransaction2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReliableWriteTransaction))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1360083335, 61202, 17967, 159, 178, 161, 164, 58, 103, 148, 22)]
  internal interface IGattReliableWriteTransaction2
  {
    [RemoteAsync]
    IAsyncOperation<GattWriteResult> CommitWithResultAsync();
  }
}
