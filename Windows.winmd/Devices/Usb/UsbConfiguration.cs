// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbConfiguration : IUsbConfiguration
  {
    public extern IVectorView<UsbInterface> UsbInterfaces { [MethodImpl] get; }

    public extern UsbConfigurationDescriptor ConfigurationDescriptor { [MethodImpl] get; }

    public extern IVectorView<UsbDescriptor> Descriptors { [MethodImpl] get; }
  }
}
