// Decompiled with JetBrains decompiler
// Type: Windows.Devices.LowLevelDevicesController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Devices
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Static(typeof (ILowLevelDevicesControllerStatics), 131072, "Windows.Devices.DevicesLowLevelContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class LowLevelDevicesController : ILowLevelDevicesController
  {
    public static extern ILowLevelDevicesAggregateProvider DefaultProvider { [MethodImpl] get; [MethodImpl] set; }
  }
}
