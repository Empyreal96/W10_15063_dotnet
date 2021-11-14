// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceModulesManagerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2377135728, 58957, 18291, 150, 192, 188, 126, 191, 14, 6, 63)]
  [ExclusiveTo(typeof (AudioDeviceModulesManager))]
  internal interface IAudioDeviceModulesManagerFactory
  {
    AudioDeviceModulesManager Create(string deviceId);
  }
}
