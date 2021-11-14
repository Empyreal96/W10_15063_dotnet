// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.I2cDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (II2cDeviceStatics), 65536, "Windows.Devices.DevicesLowLevelContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class I2cDevice : II2cDevice, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern I2cConnectionSettings ConnectionSettings { [MethodImpl] get; }

    [MethodImpl]
    public extern void Write(byte[] buffer);

    [MethodImpl]
    public extern I2cTransferResult WritePartial(byte[] buffer);

    [MethodImpl]
    public extern void Read([Range(0, 2147483647), Out] byte[] buffer);

    [MethodImpl]
    public extern I2cTransferResult ReadPartial([Range(0, 2147483647), Out] byte[] buffer);

    [MethodImpl]
    public extern void WriteRead(byte[] writeBuffer, [Range(0, 2147483647), Out] byte[] readBuffer);

    [MethodImpl]
    public extern I2cTransferResult WriteReadPartial(
      byte[] writeBuffer,
      [Range(0, 2147483647), Out] byte[] readBuffer);

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    [Overload("GetDeviceSelectorFromFriendlyName")]
    [MethodImpl]
    public static extern string GetDeviceSelector(string friendlyName);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<I2cDevice> FromIdAsync(
      string deviceId,
      I2cConnectionSettings settings);
  }
}
