// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterruptInEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbInterruptInEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3081781394, 5144, 18742, 130, 9, 41, 156, 245, 96, 85, 131)]
  internal interface IUsbInterruptInEventArgs
  {
    IBuffer InterruptData { get; }
  }
}
