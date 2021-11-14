// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFrameOutputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioFrameOutputNode))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3091674907, 12953, 17909, 136, 179, 201, 209, 42, 63, 28, 200)]
  internal interface IAudioFrameOutputNode : IAudioNode, IClosable
  {
    AudioFrame GetFrame();
  }
}
