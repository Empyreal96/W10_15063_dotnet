// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.SpiController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Spi.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Static(typeof (ISpiControllerStatics), 131072, "Windows.Devices.DevicesLowLevelContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class SpiController : ISpiController
  {
    [MethodImpl]
    public extern SpiDevice GetDevice(SpiConnectionSettings settings);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SpiController> GetDefaultAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SpiController>> GetControllersAsync(
      ISpiProvider provider);
  }
}
