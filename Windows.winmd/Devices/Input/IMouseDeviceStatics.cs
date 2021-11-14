// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IMouseDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Guid(1212846149, 28016, 18907, 142, 104, 70, 255, 189, 23, 211, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MouseDevice))]
  internal interface IMouseDeviceStatics
  {
    MouseDevice GetForCurrentView();
  }
}
