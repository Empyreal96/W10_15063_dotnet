// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioInputNode2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(2421249719, 51816, 19565, 168, 188, 227, 238, 23, 254, 63, 210)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IAudioInputNode2 : IAudioNode, IClosable, IAudioInputNode
  {
    AudioNodeEmitter Emitter { get; }
  }
}
