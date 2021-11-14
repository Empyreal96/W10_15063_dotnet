// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceConnectionChangeTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDeviceConnectionChangeTriggerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DeviceConnectionChangeTrigger : 
    IDeviceConnectionChangeTrigger,
    IBackgroundTrigger
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern bool CanMaintainConnection { [MethodImpl] get; }

    public extern bool MaintainConnection { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceConnectionChangeTrigger> FromIdAsync(
      string deviceId);
  }
}
