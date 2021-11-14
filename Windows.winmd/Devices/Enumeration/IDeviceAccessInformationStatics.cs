// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceAccessInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceAccessInformation))]
  [Guid(1464587219, 24368, 17869, 138, 148, 114, 79, 229, 151, 48, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceAccessInformationStatics
  {
    DeviceAccessInformation CreateFromId(string deviceId);

    DeviceAccessInformation CreateFromDeviceClassId(Guid deviceClassId);

    DeviceAccessInformation CreateFromDeviceClass(DeviceClass deviceClass);
  }
}
