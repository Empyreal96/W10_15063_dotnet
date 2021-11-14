// Decompiled with JetBrains decompiler
// Type: Windows.Devices.ILowLevelDevicesControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices
{
  [Guid(155095658, 64715, 17300, 166, 151, 25, 222, 99, 124, 45, 179)]
  [ExclusiveTo(typeof (LowLevelDevicesController))]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  internal interface ILowLevelDevicesControllerStatics
  {
    ILowLevelDevicesAggregateProvider DefaultProvider { get; set; }
  }
}
