// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioDeviceInputNodeResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(384747432, 7335, 16623, 145, 164, 211, 70, 224, 170, 27, 186)]
  [ExclusiveTo(typeof (CreateAudioDeviceInputNodeResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICreateAudioDeviceInputNodeResult
  {
    AudioDeviceNodeCreationStatus Status { get; }

    AudioDeviceInputNode DeviceInputNode { get; }
  }
}
