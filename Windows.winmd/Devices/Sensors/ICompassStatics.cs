// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Compass))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2596050911, 22252, 19493, 181, 77, 64, 166, 139, 181, 178, 105)]
  internal interface ICompassStatics
  {
    Compass GetDefault();
  }
}
