// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioDeviceInputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2954587105, 28494, 18914, 172, 1, 85, 157, 98, 190, 179, 169)]
  [ExclusiveTo(typeof (AudioDeviceInputNode))]
  internal interface IAudioDeviceInputNode : IAudioInputNode, IAudioNode, IClosable
  {
    DeviceInformation Device { get; }
  }
}
