// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeWithListener
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(235901052, 31231, 17732, 158, 235, 1, 37, 123, 21, 16, 90)]
  public interface IAudioNodeWithListener : IClosable, IAudioNode
  {
    AudioNodeListener Listener { set; get; }
  }
}
