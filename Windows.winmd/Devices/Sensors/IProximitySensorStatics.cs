// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (ProximitySensor))]
  [Guid(689464905, 25193, 20055, 165, 173, 130, 190, 128, 129, 51, 146)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProximitySensorStatics
  {
    string GetDeviceSelector();

    ProximitySensor FromId(string sensorId);
  }
}
