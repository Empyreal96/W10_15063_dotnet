// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceModulesManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(1789135949, 38410, 19740, 179, 24, 0, 34, 96, 69, 71, 237)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AudioDeviceModulesManager))]
  internal interface IAudioDeviceModulesManager
  {
    event TypedEventHandler<AudioDeviceModulesManager, AudioDeviceModuleNotificationEventArgs> ModuleNotificationReceived;

    IVectorView<AudioDeviceModule> FindAllById(string moduleId);

    IVectorView<AudioDeviceModule> FindAll();
  }
}
