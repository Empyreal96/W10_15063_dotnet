// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AudioDeviceModulesManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IAudioDeviceModulesManagerFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioDeviceModulesManager : IAudioDeviceModulesManager
  {
    [MethodImpl]
    public extern AudioDeviceModulesManager(string deviceId);

    public extern event TypedEventHandler<AudioDeviceModulesManager, AudioDeviceModuleNotificationEventArgs> ModuleNotificationReceived;

    [MethodImpl]
    public extern IVectorView<AudioDeviceModule> FindAllById(
      string moduleId);

    [MethodImpl]
    public extern IVectorView<AudioDeviceModule> FindAll();
  }
}
