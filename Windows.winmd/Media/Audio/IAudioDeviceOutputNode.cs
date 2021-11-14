// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioDeviceOutputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioDeviceOutputNode))]
  [Guid(909040639, 65308, 17460, 158, 15, 189, 46, 245, 34, 172, 130)]
  internal interface IAudioDeviceOutputNode : IAudioNode, IClosable
  {
    DeviceInformation Device { get; }
  }
}
