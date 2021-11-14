// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidInputReportReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1884931531, 22962, 19906, 152, 92, 10, 220, 97, 54, 250, 45)]
  [ExclusiveTo(typeof (HidInputReportReceivedEventArgs))]
  internal interface IHidInputReportReceivedEventArgs
  {
    HidInputReport Report { get; }
  }
}
