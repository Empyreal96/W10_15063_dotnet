// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioDeviceOutputNodeResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4151799079, 7578, 18423, 156, 212, 40, 89, 204, 27, 123, 255)]
  [ExclusiveTo(typeof (CreateAudioDeviceOutputNodeResult))]
  internal interface ICreateAudioDeviceOutputNodeResult
  {
    AudioDeviceNodeCreationStatus Status { get; }

    AudioDeviceOutputNode DeviceOutputNode { get; }
  }
}
