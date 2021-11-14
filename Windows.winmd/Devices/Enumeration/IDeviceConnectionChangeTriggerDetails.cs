// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceConnectionChangeTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3092745228, 48065, 18507, 191, 250, 123, 49, 220, 194, 0, 178)]
  [ExclusiveTo(typeof (DeviceConnectionChangeTriggerDetails))]
  internal interface IDeviceConnectionChangeTriggerDetails
  {
    string DeviceId { get; }
  }
}
