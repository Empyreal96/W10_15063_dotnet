﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceAccessChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceAccessChangedEventArgs : 
    IDeviceAccessChangedEventArgs,
    IDeviceAccessChangedEventArgs2
  {
    public extern DeviceAccessStatus Status { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }
  }
}
