// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothUuidHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(400493784, 53108, 19233, 175, 230, 245, 122, 17, 188, 222, 160)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BluetoothUuidHelper))]
  internal interface IBluetoothUuidHelperStatics
  {
    Guid FromShortId(uint shortId);

    IReference<uint> TryGetShortId(Guid uuid);
  }
}
