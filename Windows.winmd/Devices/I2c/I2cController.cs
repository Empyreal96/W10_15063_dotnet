// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.I2cController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.I2c.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (II2cControllerStatics), 131072, "Windows.Devices.DevicesLowLevelContract")]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  public sealed class I2cController : II2cController
  {
    [MethodImpl]
    public extern I2cDevice GetDevice(I2cConnectionSettings settings);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<I2cController>> GetControllersAsync(
      II2cProvider provider);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<I2cController> GetDefaultAsync();
  }
}
