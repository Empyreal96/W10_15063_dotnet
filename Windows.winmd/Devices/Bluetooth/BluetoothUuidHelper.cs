// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothUuidHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IBluetoothUuidHelperStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class BluetoothUuidHelper
  {
    [MethodImpl]
    public static extern Guid FromShortId(uint shortId);

    [MethodImpl]
    public static extern IReference<uint> TryGetShortId(Guid uuid);
  }
}
