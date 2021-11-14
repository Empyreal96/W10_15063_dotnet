// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AudioDeviceModule
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class AudioDeviceModule : IAudioDeviceModule
  {
    public extern string ClassId { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern uint InstanceId { [MethodImpl] get; }

    public extern uint MajorVersion { [MethodImpl] get; }

    public extern uint MinorVersion { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ModuleCommandResult> SendCommandAsync(
      IBuffer Command);
  }
}
