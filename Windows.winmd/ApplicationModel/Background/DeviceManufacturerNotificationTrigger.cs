// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceManufacturerNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(typeof (IDeviceManufacturerNotificationTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceManufacturerNotificationTrigger : 
    IDeviceManufacturerNotificationTrigger,
    IBackgroundTrigger
  {
    [MethodImpl]
    public extern DeviceManufacturerNotificationTrigger(string triggerQualifier, bool oneShot);

    public extern string TriggerQualifier { [MethodImpl] get; }

    public extern bool OneShot { [MethodImpl] get; }
  }
}
