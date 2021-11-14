// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ILineDisplayStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class LineDisplay : ILineDisplay, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern LineDisplayCapabilities Capabilities { [MethodImpl] get; }

    public extern string PhysicalDeviceName { [MethodImpl] get; }

    public extern string PhysicalDeviceDescription { [MethodImpl] get; }

    public extern string DeviceControlDescription { [MethodImpl] get; }

    public extern string DeviceControlVersion { [MethodImpl] get; }

    public extern string DeviceServiceVersion { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedLineDisplay> ClaimAsync();

    [MethodImpl]
    public extern void Close();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LineDisplay> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LineDisplay> GetDefaultAsync();

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
