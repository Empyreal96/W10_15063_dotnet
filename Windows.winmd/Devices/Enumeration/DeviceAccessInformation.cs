// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceAccessInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDeviceAccessInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DeviceAccessInformation : IDeviceAccessInformation
  {
    public extern event TypedEventHandler<DeviceAccessInformation, DeviceAccessChangedEventArgs> AccessChanged;

    public extern DeviceAccessStatus CurrentStatus { [MethodImpl] get; }

    [MethodImpl]
    public static extern DeviceAccessInformation CreateFromId(string deviceId);

    [MethodImpl]
    public static extern DeviceAccessInformation CreateFromDeviceClassId(
      Guid deviceClassId);

    [MethodImpl]
    public static extern DeviceAccessInformation CreateFromDeviceClass(
      DeviceClass deviceClass);
  }
}
