// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePickerFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DevicePickerFilter : IDevicePickerFilter
  {
    public extern IVector<DeviceClass> SupportedDeviceClasses { [MethodImpl] get; }

    public extern IVector<string> SupportedDeviceSelectors { [MethodImpl] get; }
  }
}
