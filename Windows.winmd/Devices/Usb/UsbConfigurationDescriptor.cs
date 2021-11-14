// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbConfigurationDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IUsbConfigurationDescriptorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbConfigurationDescriptor : IUsbConfigurationDescriptor
  {
    public extern byte ConfigurationValue { [MethodImpl] get; }

    public extern uint MaxPowerMilliamps { [MethodImpl] get; }

    public extern bool SelfPowered { [MethodImpl] get; }

    public extern bool RemoteWakeup { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool TryParse(
      UsbDescriptor descriptor,
      out UsbConfigurationDescriptor parsed);

    [MethodImpl]
    public static extern UsbConfigurationDescriptor Parse(
      UsbDescriptor descriptor);
  }
}
