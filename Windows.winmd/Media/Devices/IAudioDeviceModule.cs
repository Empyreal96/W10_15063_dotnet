// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceModule
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AudioDeviceModule))]
  [Guid(2261756982, 18369, 19251, 152, 82, 135, 115, 236, 75, 225, 35)]
  internal interface IAudioDeviceModule
  {
    string ClassId { get; }

    string DisplayName { get; }

    uint InstanceId { get; }

    uint MajorVersion { get; }

    uint MinorVersion { get; }

    [RemoteAsync]
    IAsyncOperation<ModuleCommandResult> SendCommandAsync(
      IBuffer Command);
  }
}
